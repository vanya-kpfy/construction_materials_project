using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace branch_for_registration_1.UsersServices
{
    /// <summary>
    /// Сервис для работы с отгрузками
    /// </summary>
    public class ShipmentService : IDisposable
    {
        private AppDbContext db;

        public ShipmentService()
        {
            db = new AppDbContext();
        }

        /// <summary>
        /// Возвращает все отгрузки с пользователями и позициями
        /// </summary>
        /// <returns></returns>
        public List<Shipment> GetAllShipments()
        {
            return db.Shipments.Include(s => s.User).Include(s => s.ShipmentItems).ThenInclude(si => si.Product).OrderByDescending(s => s.ShipmentDate).ToList();
        }

        /// <summary>
        /// Возвращает отгрузки конкретного пользователя
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Shipment> GetShipmentsByUser(Guid userId)
        {
            return db.Shipments.Include(s => s.User).Include(s => s.ShipmentItems).ThenInclude(si => si.Product).Where(s => s.UserId == userId).OrderByDescending(s => s.ShipmentDate).ToList();
        }

        /// <summary>
        /// Создаёт новую отгрузку, списывая товары со склада
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="destination"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Shipment CreateShipment(Guid userId, string destination, List<ShipmentItem> items)
        {
            foreach (var item in items)
            {
                var product = db.Products.Find(item.ProductId);
                if (product == null)
                    throw new Exception($"Product with ID {item.ProductId} not found.");
                if (product.CurrentStock < item.Quantity)
                    throw new Exception($"Not enough stock for product '{product.Name}'. Available: {product.CurrentStock}, requested: {item.Quantity}.");
            }

            var shipment = new Shipment
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                ShipmentDate = DateTime.Now,
                Destination = destination,
                ShipmentItems = items.Select(i => new ShipmentItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = i.ProductId,
                    Quantity = i.Quantity
                }).ToList()
            };
            db.Shipments.Add(shipment);

            foreach (var item in items)
            {
                var product = db.Products.Find(item.ProductId);
                if (product != null)
                { 
                    product.CurrentStock -= item.Quantity; 
                }
            }
            db.SaveChanges();
            return shipment;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        internal void CreateShipment(Guid userId, string v1, string v2, string v3, string v4, string v5, List<ShipmentItem> cart)
        {
            throw new NotImplementedException();
        }
    }
}