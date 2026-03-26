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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonShipment = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.textBoxDecor = new System.Windows.Forms.TextBox();
            this.textBoxDecor2 = new System.Windows.Forms.TextBox();
            this.textBoxDecor3 = new System.Windows.Forms.TextBox();
            this.textBoxVisualCatalog = new System.Windows.Forms.TextBox();
            this.btnListovyeMaterialy = new System.Windows.Forms.Button();
            this.btnSuhieSmesi = new System.Windows.Forms.Button();
            this.btnTeploizolyaciya = new System.Windows.Forms.Button();
            this.btnBloki = new System.Windows.Forms.Button();
            this.btnMetalloprokat = new System.Windows.Forms.Button();
            this.btnKrovlya = new System.Windows.Forms.Button();
            this.btnFasadnyeMaterialy = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnStroitelnyeMaterialy = new System.Windows.Forms.Button();
            this.btnShumoizolyaciya = new System.Windows.Forms.Button();
            this.btnParoizolyaciya = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewProducts.Location = new System.Drawing.Point(304, 55);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 72;
            this.dataGridViewProducts.RowTemplate.Height = 31;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1275, 882);
            this.dataGridViewProducts.TabIndex = 1;
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
            this.buttonShipment.Click += new System.EventHandler(this.buttonShipment_Click);
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
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
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
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.BackColor = System.Drawing.Color.LightGray;
            this.btnAllProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAllProducts.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAllProducts.FlatAppearance.BorderSize = 0;
            this.btnAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllProducts.Location = new System.Drawing.Point(3, 41);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(295, 63);
            this.btnAllProducts.TabIndex = 6;
            this.btnAllProducts.Text = "Все товары";
            this.btnAllProducts.UseVisualStyleBackColor = false;
            // 
            // textBoxDecor
            // 
            this.textBoxDecor.BackColor = System.Drawing.Color.Black;
            this.textBoxDecor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDecor.Location = new System.Drawing.Point(22, 101);
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
            this.textBoxVisualCatalog.Location = new System.Drawing.Point(22, 110);
            this.textBoxVisualCatalog.Multiline = true;
            this.textBoxVisualCatalog.Name = "textBoxVisualCatalog";
            this.textBoxVisualCatalog.ReadOnly = true;
            this.textBoxVisualCatalog.Size = new System.Drawing.Size(251, 51);
            this.textBoxVisualCatalog.TabIndex = 26;
            this.textBoxVisualCatalog.Text = "Каталог";
            this.textBoxVisualCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnListovyeMaterialy
            // 
            this.btnListovyeMaterialy.BackColor = System.Drawing.Color.LightGray;
            this.btnListovyeMaterialy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListovyeMaterialy.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnListovyeMaterialy.FlatAppearance.BorderSize = 0;
            this.btnListovyeMaterialy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListovyeMaterialy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnListovyeMaterialy.Location = new System.Drawing.Point(3, 163);
            this.btnListovyeMaterialy.Name = "btnListovyeMaterialy";
            this.btnListovyeMaterialy.Size = new System.Drawing.Size(295, 38);
            this.btnListovyeMaterialy.TabIndex = 27;
            this.btnListovyeMaterialy.Text = "Листовые материалы";
            this.btnListovyeMaterialy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListovyeMaterialy.UseVisualStyleBackColor = false;
            // 
            // btnSuhieSmesi
            // 
            this.btnSuhieSmesi.BackColor = System.Drawing.Color.LightGray;
            this.btnSuhieSmesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuhieSmesi.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSuhieSmesi.FlatAppearance.BorderSize = 0;
            this.btnSuhieSmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuhieSmesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSuhieSmesi.Location = new System.Drawing.Point(3, 207);
            this.btnSuhieSmesi.Name = "btnSuhieSmesi";
            this.btnSuhieSmesi.Size = new System.Drawing.Size(295, 38);
            this.btnSuhieSmesi.TabIndex = 28;
            this.btnSuhieSmesi.Text = "Сухие смеси и грунтовки";
            this.btnSuhieSmesi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuhieSmesi.UseVisualStyleBackColor = false;
            // 
            // btnTeploizolyaciya
            // 
            this.btnTeploizolyaciya.BackColor = System.Drawing.Color.LightGray;
            this.btnTeploizolyaciya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTeploizolyaciya.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTeploizolyaciya.FlatAppearance.BorderSize = 0;
            this.btnTeploizolyaciya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeploizolyaciya.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTeploizolyaciya.Location = new System.Drawing.Point(3, 251);
            this.btnTeploizolyaciya.Name = "btnTeploizolyaciya";
            this.btnTeploizolyaciya.Size = new System.Drawing.Size(295, 38);
            this.btnTeploizolyaciya.TabIndex = 29;
            this.btnTeploizolyaciya.Text = "Теплоизоляция";
            this.btnTeploizolyaciya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeploizolyaciya.UseVisualStyleBackColor = false;
            // 
            // btnBloki
            // 
            this.btnBloki.BackColor = System.Drawing.Color.LightGray;
            this.btnBloki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBloki.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnBloki.FlatAppearance.BorderSize = 0;
            this.btnBloki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloki.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBloki.Location = new System.Drawing.Point(-1, 295);
            this.btnBloki.Name = "btnBloki";
            this.btnBloki.Size = new System.Drawing.Size(299, 38);
            this.btnBloki.TabIndex = 30;
            this.btnBloki.Text = "Блоки для строительства";
            this.btnBloki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBloki.UseVisualStyleBackColor = false;
            // 
            // btnMetalloprokat
            // 
            this.btnMetalloprokat.BackColor = System.Drawing.Color.LightGray;
            this.btnMetalloprokat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMetalloprokat.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMetalloprokat.FlatAppearance.BorderSize = 0;
            this.btnMetalloprokat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetalloprokat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMetalloprokat.Location = new System.Drawing.Point(3, 339);
            this.btnMetalloprokat.Name = "btnMetalloprokat";
            this.btnMetalloprokat.Size = new System.Drawing.Size(295, 38);
            this.btnMetalloprokat.TabIndex = 31;
            this.btnMetalloprokat.Text = "Металлопрокат";
            this.btnMetalloprokat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetalloprokat.UseVisualStyleBackColor = false;
            // 
            // btnKrovlya
            // 
            this.btnKrovlya.BackColor = System.Drawing.Color.LightGray;
            this.btnKrovlya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKrovlya.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnKrovlya.FlatAppearance.BorderSize = 0;
            this.btnKrovlya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKrovlya.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKrovlya.Location = new System.Drawing.Point(3, 383);
            this.btnKrovlya.Name = "btnKrovlya";
            this.btnKrovlya.Size = new System.Drawing.Size(295, 39);
            this.btnKrovlya.TabIndex = 32;
            this.btnKrovlya.Text = "Кровля";
            this.btnKrovlya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKrovlya.UseVisualStyleBackColor = false;
            // 
            // btnFasadnyeMaterialy
            // 
            this.btnFasadnyeMaterialy.BackColor = System.Drawing.Color.LightGray;
            this.btnFasadnyeMaterialy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFasadnyeMaterialy.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnFasadnyeMaterialy.FlatAppearance.BorderSize = 0;
            this.btnFasadnyeMaterialy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFasadnyeMaterialy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFasadnyeMaterialy.Location = new System.Drawing.Point(3, 428);
            this.btnFasadnyeMaterialy.Name = "btnFasadnyeMaterialy";
            this.btnFasadnyeMaterialy.Size = new System.Drawing.Size(295, 39);
            this.btnFasadnyeMaterialy.TabIndex = 33;
            this.btnFasadnyeMaterialy.Text = "Фасадные материалы";
            this.btnFasadnyeMaterialy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFasadnyeMaterialy.UseVisualStyleBackColor = false;
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.LightGray;
            this.btnProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfil.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfil.Location = new System.Drawing.Point(3, 475);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(295, 93);
            this.btnProfil.TabIndex = 34;
            this.btnProfil.Text = "Профиль для гипсокартона  и аксессуары";
            this.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.UseVisualStyleBackColor = false;
            // 
            // btnStroitelnyeMaterialy
            // 
            this.btnStroitelnyeMaterialy.BackColor = System.Drawing.Color.LightGray;
            this.btnStroitelnyeMaterialy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStroitelnyeMaterialy.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnStroitelnyeMaterialy.FlatAppearance.BorderSize = 0;
            this.btnStroitelnyeMaterialy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStroitelnyeMaterialy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStroitelnyeMaterialy.Location = new System.Drawing.Point(3, 574);
            this.btnStroitelnyeMaterialy.Name = "btnStroitelnyeMaterialy";
            this.btnStroitelnyeMaterialy.Size = new System.Drawing.Size(295, 67);
            this.btnStroitelnyeMaterialy.TabIndex = 35;
            this.btnStroitelnyeMaterialy.Text = "Строительные и расходные материалы";
            this.btnStroitelnyeMaterialy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStroitelnyeMaterialy.UseVisualStyleBackColor = false;
            // 
            // btnShumoizolyaciya
            // 
            this.btnShumoizolyaciya.BackColor = System.Drawing.Color.LightGray;
            this.btnShumoizolyaciya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShumoizolyaciya.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnShumoizolyaciya.FlatAppearance.BorderSize = 0;
            this.btnShumoizolyaciya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShumoizolyaciya.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShumoizolyaciya.Location = new System.Drawing.Point(3, 650);
            this.btnShumoizolyaciya.Name = "btnShumoizolyaciya";
            this.btnShumoizolyaciya.Size = new System.Drawing.Size(295, 39);
            this.btnShumoizolyaciya.TabIndex = 36;
            this.btnShumoizolyaciya.Text = "Шумоизоляция";
            this.btnShumoizolyaciya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShumoizolyaciya.UseVisualStyleBackColor = false;
            // 
            // btnParoizolyaciya
            // 
            this.btnParoizolyaciya.BackColor = System.Drawing.Color.LightGray;
            this.btnParoizolyaciya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnParoizolyaciya.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnParoizolyaciya.FlatAppearance.BorderSize = 0;
            this.btnParoizolyaciya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParoizolyaciya.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParoizolyaciya.Location = new System.Drawing.Point(3, 695);
            this.btnParoizolyaciya.Name = "btnParoizolyaciya";
            this.btnParoizolyaciya.Size = new System.Drawing.Size(295, 86);
            this.btnParoizolyaciya.TabIndex = 37;
            this.btnParoizolyaciya.Text = "Ветро-влагозащита и пароизоляция кровли и фасадов";
            this.btnParoizolyaciya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParoizolyaciya.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1576, 933);
            this.Controls.Add(this.btnParoizolyaciya);
            this.Controls.Add(this.btnShumoizolyaciya);
            this.Controls.Add(this.btnStroitelnyeMaterialy);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnFasadnyeMaterialy);
            this.Controls.Add(this.btnKrovlya);
            this.Controls.Add(this.btnMetalloprokat);
            this.Controls.Add(this.btnBloki);
            this.Controls.Add(this.btnTeploizolyaciya);
            this.Controls.Add(this.btnSuhieSmesi);
            this.Controls.Add(this.btnListovyeMaterialy);
            this.Controls.Add(this.textBoxVisualCatalog);
            this.Controls.Add(this.textBoxDecor);
            this.Controls.Add(this.btnAllProducts);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonShipment);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.textBoxDecor2);
            this.Controls.Add(this.textBoxDecor3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private Button buttonShipment;
        private Button buttonSearch;
        private Button buttonLogout;
        private Button buttonAdmin;
        private Button btnAllProducts;
        private TextBox textBoxDecor;
        private TextBox textBoxDecor2;
        private TextBox textBoxDecor3;
        private TextBox textBoxVisualCatalog;
        private Button btnListovyeMaterialy;
        private Button btnSuhieSmesi;
        private Button btnTeploizolyaciya;
        private Button btnBloki;
        private Button btnMetalloprokat;
        private Button btnKrovlya;
        private Button btnFasadnyeMaterialy;
        private Button btnProfil;
        private Button btnStroitelnyeMaterialy;
        private Button btnShumoizolyaciya;
        private Button btnParoizolyaciya;
    }
}