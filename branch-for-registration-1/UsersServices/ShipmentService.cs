using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using branch_for_registration_1.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace branch_for_registration_1.UsersServices
{
    /// <summary>
    /// Сервис для работы с отгрузками
    /// </summary>
    public class ShipmentService
    {

        /// <summary>
        /// Возвращает все отгрузки с пользователями и позициями
        /// </summary>
        /// <returns></returns>
        public async Task<List<Shipment>> GetAllShipments()
        {
            using (var db = new AppDbContext())
            {
                return await db.Shipments.Include(s => s.User)
                    .Include(s => s.User)
                    .Include(s => s.Address)
                    .Include(s => s.ShipmentItems)
                    .ThenInclude(si => si.Product)
                    .OrderByDescending(s => s.ShipmentDate)
                    .ToListAsync();
            }
        }

        /// <summary>
        /// Возвращает отгрузки конкретного пользователя
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Shipment>> GetShipmentsByUser(Guid userId)
        {
            using (var db = new AppDbContext())
            {
                return await db.Shipments.Include(s => s.User).Include(s => s.ShipmentItems).ThenInclude(si => si.Product).Where(s => s.UserId == userId).OrderByDescending(s => s.ShipmentDate).ToListAsync();
            }
        }

        /// <summary>
        /// Создаёт новую отгрузку, списывая товары со склада
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="destination"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<Shipment> CreateShipment(Guid userId, Address address, List<ShipmentItem> items)
        {
            using (var db = new AppDbContext())
            {
                var productIds = items.Select(i => i.ProductId).ToList();

                var products = await db.Products.Where(p => productIds.Contains(p.Id)).ToListAsync();

                foreach (var item in items)
                {
                    var product = products.FirstOrDefault(p => p.Id == item.ProductId);

                    if (product is null)
                    {
                        throw new Exception("ProductWithIdNotFound");
                    }

                    if (product.CurrentStock < item.Quantity)
                    {
                        throw new Exception("QuantityOfProductNotEnough");
                    }
                }

                await db.Addresses.AddAsync(address);


                var shipment = new Shipment
                {
                    UserId = userId,
                    ShipmentDate = DateTime.Now,
                    Address = address,
                    ShipmentItems = items.Select(i => new ShipmentItem
                    {
                        ProductId = i.ProductId,
                        Quantity = i.Quantity
                    }).ToList()
                };

                await db.Shipments.AddAsync(shipment);

                foreach (var item in items)
                {
                    var product = products.First(p => p.Id == item.ProductId);
                    product.CurrentStock -= item.Quantity;
                }

                await db.SaveChangesAsync();

                return shipment;
            }
        }
    }
}