namespace branch_for_registration_1.Forms
{
    partial class FormShipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShipment));
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelTextVisualStreet = new System.Windows.Forms.Label();
            this.labelTextVisualProduct = new System.Windows.Forms.Label();
            this.labelTextVisualCountProduct = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.labelTextVisualShipment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.labelTextVisualBuilding = new System.Windows.Forms.Label();
            this.labelTextVisualRegion = new System.Windows.Forms.Label();
            this.labelTextVisualCity = new System.Windows.Forms.Label();
            this.labelTextVisualCountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStreet.BackColor = System.Drawing.Color.White;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStreet.ForeColor = System.Drawing.Color.Black;
            this.txtStreet.Location = new System.Drawing.Point(238, 315);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Multiline = true;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStreet.Size = new System.Drawing.Size(269, 34);
            this.txtStreet.TabIndex = 12;
            this.txtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbProduct
            // 
            this.cbProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(238, 367);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(269, 37);
            this.cbProduct.TabIndex = 13;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudQuantity.Location = new System.Drawing.Point(238, 420);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(269, 36);
            this.nudQuantity.TabIndex = 14;
            // 
            // labelTextVisualStreet
            // 
            this.labelTextVisualStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualStreet.AutoSize = true;
            this.labelTextVisualStreet.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualStreet.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualStreet.Location = new System.Drawing.Point(62, 315);
            this.labelTextVisualStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextVisualStreet.Name = "labelTextVisualStreet";
            this.labelTextVisualStreet.Size = new System.Drawing.Size(76, 26);
            this.labelTextVisualStreet.TabIndex = 15;
            this.labelTextVisualStreet.Text = "Улица";
            // 
            // labelTextVisualProduct
            // 
            this.labelTextVisualProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualProduct.AutoSize = true;
            this.labelTextVisualProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualProduct.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualProduct.Location = new System.Drawing.Point(62, 367);
            this.labelTextVisualProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextVisualProduct.Name = "labelTextVisualProduct";
            this.labelTextVisualProduct.Size = new System.Drawing.Size(72, 26);
            this.labelTextVisualProduct.TabIndex = 16;
            this.labelTextVisualProduct.Text = "Товар";
            // 
            // labelTextVisualCountProduct
            // 
            this.labelTextVisualCountProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualCountProduct.AutoSize = true;
            this.labelTextVisualCountProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualCountProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualCountProduct.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualCountProduct.Location = new System.Drawing.Point(62, 420);
            this.labelTextVisualCountProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextVisualCountProduct.Name = "labelTextVisualCountProduct";
            this.labelTextVisualCountProduct.Size = new System.Drawing.Size(133, 26);
            this.labelTextVisualCountProduct.TabIndex = 17;
            this.labelTextVisualCountProduct.Text = "Количество";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 20;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(607, 499);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(376, 47);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.AutoSize = true;
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.FlatAppearance.BorderSize = 20;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(93, 499);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(376, 47);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Создать отгрузку";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelTextVisualShipment
            // 
            this.labelTextVisualShipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualShipment.AutoSize = true;
            this.labelTextVisualShipment.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualShipment.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualShipment.Location = new System.Drawing.Point(136, 37);
            this.labelTextVisualShipment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextVisualShipment.Name = "labelTextVisualShipment";
            this.labelTextVisualShipment.Size = new System.Drawing.Size(333, 37);
            this.labelTextVisualShipment.TabIndex = 20;
            this.labelTextVisualShipment.Text = "Оформление отгрузки";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(653, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Текущие позиции";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(536, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(4, 596);
            this.textBox1.TabIndex = 22;
            // 
            // dgvCart
            // 
            this.dgvCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(578, 112);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 72;
            this.dgvCart.RowTemplate.Height = 31;
            this.dgvCart.Size = new System.Drawing.Size(440, 344);
            this.dgvCart.TabIndex = 23;
            // 
            // txtBuilding
            // 
            this.txtBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuilding.BackColor = System.Drawing.Color.White;
            this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBuilding.ForeColor = System.Drawing.Color.Black;
            this.txtBuilding.Location = new System.Drawing.Point(238, 264);
            this.txtBuilding.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuilding.Multiline = true;
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuilding.Size = new System.Drawing.Size(269, 34);
            this.txtBuilding.TabIndex = 24;
            this.txtBuilding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRegion
            // 
            this.txtRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegion.BackColor = System.Drawing.Color.White;
            this.txtRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRegion.ForeColor = System.Drawing.Color.Black;
            this.txtRegion.Location = new System.Drawing.Point(238, 215);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegion.Multiline = true;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegion.Size = new System.Drawing.Size(269, 34);
            this.txtRegion.TabIndex = 25;
            this.txtRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(238, 165);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCity.Size = new System.Drawing.Size(269, 34);
            this.txtCity.TabIndex = 26;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCountry.BackColor = System.Drawing.Color.White;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(238, 112);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountry.Multiline = true;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCountry.Size = new System.Drawing.Size(269, 34);
            this.txtCountry.TabIndex = 27;
            this.txtCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTextVisualBuilding
            // 
            this.labelTextVisualBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualBuilding.AutoSize = true;
            this.labelTextVisualBuilding.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualBuilding.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualBuilding.Location = new System.Drawing.Point(62, 264);
            this.labelTextVisualBuilding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextVisualBuilding.Name = "labelTextVisualBuilding";
            this.labelTextVisualBuilding.Size = new System.Drawing.Size(87, 26);
            this.labelTextVisualBuilding.TabIndex = 28;
            this.labelTextVisualBuilding.Text = "Здание";
            // 
            // labelTextVisualRegion
            // 
            this.labelTextVisualRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualRegion.AutoSize = true;
            this.labelTextVisualRegion.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualRegion.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualRegion.Location = new System.Drawing.Point(62, 215);
            this.labelTextVisualRegion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextVisualRegion.Name = "labelTextVisualRegion";
            this.labelTextVisualRegion.Size = new System.Drawing.Size(83, 26);
            this.labelTextVisualRegion.TabIndex = 29;
            this.labelTextVisualRegion.Text = "Регион";
            // 
            // labelTextVisualCity
            // 
            this.labelTextVisualCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualCity.AutoSize = true;
            this.labelTextVisualCity.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualCity.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualCity.Location = new System.Drawing.Point(62, 165);
            this.labelTextVisualCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextVisualCity.Name = "labelTextVisualCity";
            this.labelTextVisualCity.Size = new System.Drawing.Size(73, 26);
            this.labelTextVisualCity.TabIndex = 30;
            this.labelTextVisualCity.Text = "Город";
            // 
            // labelTextVisualCountry
            // 
            this.labelTextVisualCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualCountry.AutoSize = true;
            this.labelTextVisualCountry.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualCountry.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualCountry.Location = new System.Drawing.Point(62, 112);
            this.labelTextVisualCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextVisualCountry.Name = "labelTextVisualCountry";
            this.labelTextVisualCountry.Size = new System.Drawing.Size(86, 26);
            this.labelTextVisualCountry.TabIndex = 31;
            this.labelTextVisualCountry.Text = "Страна";
            // 
            // FormShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 575);
            this.Controls.Add(this.labelTextVisualCountry);
            this.Controls.Add(this.labelTextVisualCity);
            this.Controls.Add(this.labelTextVisualRegion);
            this.Controls.Add(this.labelTextVisualBuilding);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtBuilding);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTextVisualShipment);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelTextVisualCountProduct);
            this.Controls.Add(this.labelTextVisualProduct);
            this.Controls.Add(this.labelTextVisualStreet);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.txtStreet);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormShipment";
            this.Text = "Otgruzka";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label labelTextVisualStreet;
        private System.Windows.Forms.Label labelTextVisualProduct;
        private System.Windows.Forms.Label labelTextVisualCountProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelTextVisualShipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label labelTextVisualBuilding;
        private System.Windows.Forms.Label labelTextVisualRegion;
        private System.Windows.Forms.Label labelTextVisualCity;
        private System.Windows.Forms.Label labelTextVisualCountry;
    }
}