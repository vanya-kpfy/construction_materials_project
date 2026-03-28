using System.Windows.Forms;
using System.Drawing;

namespace branch_for_registration_1.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.buttonShipment = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.textBoxDecor = new System.Windows.Forms.TextBox();
            this.textBoxDecor2 = new System.Windows.Forms.TextBox();
            this.textBoxDecor3 = new System.Windows.Forms.TextBox();
            this.textBoxVisualCatalog = new System.Windows.Forms.TextBox();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.btnAllProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvProducts.Location = new System.Drawing.Point(304, 55);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 72;
            this.dgvProducts.RowTemplate.Height = 31;
            this.dgvProducts.Size = new System.Drawing.Size(1275, 882);
            this.dgvProducts.TabIndex = 1;
            // 
            // buttonShipment
            // 
            this.buttonShipment.BackColor = System.Drawing.Color.LightGray;
            this.buttonShipment.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonShipment.FlatAppearance.BorderSize = 0;
            this.buttonShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShipment.Location = new System.Drawing.Point(3, 2);
            this.buttonShipment.Name = "buttonShipment";
            this.buttonShipment.Size = new System.Drawing.Size(151, 47);
            this.buttonShipment.TabIndex = 2;
            this.buttonShipment.Text = "Отгрузка";
            this.buttonShipment.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightGray;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(142, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(216, 47);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Поиск товара";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.LightGray;
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(352, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(244, 47);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Выйти из аккаунта";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.LightGray;
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdmin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdmin.Location = new System.Drawing.Point(602, 2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(197, 47);
            this.buttonAdmin.TabIndex = 5;
            this.buttonAdmin.Text = "Админ-панель";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            // 
            // textBoxDecor
            // 
            this.textBoxDecor.BackColor = System.Drawing.Color.Black;
            this.textBoxDecor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDecor.Location = new System.Drawing.Point(22, 113);
            this.textBoxDecor.Multiline = true;
            this.textBoxDecor.Name = "textBoxDecor";
            this.textBoxDecor.ReadOnly = true;
            this.textBoxDecor.Size = new System.Drawing.Size(245, 3);
            this.textBoxDecor.TabIndex = 23;
            // 
            // textBoxDecor2
            // 
            this.textBoxDecor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDecor2.BackColor = System.Drawing.Color.LightGray;
            this.textBoxDecor2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDecor2.Location = new System.Drawing.Point(-7, 2);
            this.textBoxDecor2.Multiline = true;
            this.textBoxDecor2.Name = "textBoxDecor2";
            this.textBoxDecor2.ReadOnly = true;
            this.textBoxDecor2.Size = new System.Drawing.Size(311, 935);
            this.textBoxDecor2.TabIndex = 24;
            // 
            // textBoxDecor3
            // 
            this.textBoxDecor3.BackColor = System.Drawing.Color.LightGray;
            this.textBoxDecor3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDecor3.Location = new System.Drawing.Point(3, 2);
            this.textBoxDecor3.Multiline = true;
            this.textBoxDecor3.Name = "textBoxDecor3";
            this.textBoxDecor3.ReadOnly = true;
            this.textBoxDecor3.Size = new System.Drawing.Size(1576, 51);
            this.textBoxDecor3.TabIndex = 25;
            // 
            // textBoxVisualCatalog
            // 
            this.textBoxVisualCatalog.BackColor = System.Drawing.Color.LightGray;
            this.textBoxVisualCatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVisualCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVisualCatalog.Location = new System.Drawing.Point(22, 122);
            this.textBoxVisualCatalog.Multiline = true;
            this.textBoxVisualCatalog.Name = "textBoxVisualCatalog";
            this.textBoxVisualCatalog.ReadOnly = true;
            this.textBoxVisualCatalog.Size = new System.Drawing.Size(251, 51);
            this.textBoxVisualCatalog.TabIndex = 26;
            this.textBoxVisualCatalog.Text = "Каталог";
            this.textBoxVisualCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlCategories
            // 
            this.pnlCategories.Location = new System.Drawing.Point(3, 179);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(301, 758);
            this.pnlCategories.TabIndex = 27;
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.BackColor = System.Drawing.Color.LightGray;
            this.btnAllProducts.FlatAppearance.BorderSize = 0;
            this.btnAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllProducts.Location = new System.Drawing.Point(22, 53);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(245, 54);
            this.btnAllProducts.TabIndex = 28;
            this.btnAllProducts.Text = "Все товары";
            this.btnAllProducts.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1576, 933);
            this.Controls.Add(this.btnAllProducts);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.textBoxVisualCatalog);
            this.Controls.Add(this.textBoxDecor);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonShipment);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.textBoxDecor2);
            this.Controls.Add(this.textBoxDecor3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProducts;
        private Button buttonShipment;
        private Button buttonSearch;
        private Button buttonLogout;
        private Button buttonAdmin;
        private TextBox textBoxDecor;
        private TextBox textBoxDecor2;
        private TextBox textBoxDecor3;
        private TextBox textBoxVisualCatalog;
        private Panel pnlCategories;
        private Button btnAllProducts;
    }
}