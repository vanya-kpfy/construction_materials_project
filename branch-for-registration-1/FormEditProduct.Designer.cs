namespace branch_for_registration_1.Forms
{
    partial class FormEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditProduct));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOKE = new System.Windows.Forms.Button();
            this.labelTextVisualUnit2 = new System.Windows.Forms.Label();
            this.labelTextVisualUnit = new System.Windows.Forms.Label();
            this.labelTextVisualPrice = new System.Windows.Forms.Label();
            this.labelTextVisualCategory = new System.Windows.Forms.Label();
            this.labelTextVisualName = new System.Windows.Forms.Label();
            this.labelTextVisualArticle = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelTextVisualEditProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 20;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(95, 944);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(654, 86);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOKE
            // 
            this.btnOKE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOKE.AutoSize = true;
            this.btnOKE.BackColor = System.Drawing.Color.Black;
            this.btnOKE.FlatAppearance.BorderSize = 20;
            this.btnOKE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOKE.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOKE.ForeColor = System.Drawing.Color.White;
            this.btnOKE.Location = new System.Drawing.Point(1123, 944);
            this.btnOKE.Name = "btnOKE";
            this.btnOKE.Size = new System.Drawing.Size(654, 86);
            this.btnOKE.TabIndex = 7;
            this.btnOKE.Text = "Сохранить";
            this.btnOKE.UseVisualStyleBackColor = false;
            this.btnOKE.Click += new System.EventHandler(this.btnOKE_Click);
            // 
            // labelTextVisualUnit2
            // 
            this.labelTextVisualUnit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualUnit2.AutoSize = true;
            this.labelTextVisualUnit2.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualUnit2.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualUnit2.Location = new System.Drawing.Point(514, 741);
            this.labelTextVisualUnit2.Name = "labelTextVisualUnit2";
            this.labelTextVisualUnit2.Size = new System.Drawing.Size(232, 48);
            this.labelTextVisualUnit2.TabIndex = 34;
            this.labelTextVisualUnit2.Text = "измерения";
            // 
            // labelTextVisualUnit
            // 
            this.labelTextVisualUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualUnit.AutoSize = true;
            this.labelTextVisualUnit.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualUnit.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualUnit.Location = new System.Drawing.Point(514, 693);
            this.labelTextVisualUnit.Name = "labelTextVisualUnit";
            this.labelTextVisualUnit.Size = new System.Drawing.Size(188, 48);
            this.labelTextVisualUnit.TabIndex = 33;
            this.labelTextVisualUnit.Text = "Единица";
            // 
            // labelTextVisualPrice
            // 
            this.labelTextVisualPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualPrice.AutoSize = true;
            this.labelTextVisualPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualPrice.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualPrice.Location = new System.Drawing.Point(514, 612);
            this.labelTextVisualPrice.Name = "labelTextVisualPrice";
            this.labelTextVisualPrice.Size = new System.Drawing.Size(284, 48);
            this.labelTextVisualPrice.TabIndex = 32;
            this.labelTextVisualPrice.Text = "Цена закупки";
            // 
            // labelTextVisualCategory
            // 
            this.labelTextVisualCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualCategory.AutoSize = true;
            this.labelTextVisualCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualCategory.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualCategory.Location = new System.Drawing.Point(514, 524);
            this.labelTextVisualCategory.Name = "labelTextVisualCategory";
            this.labelTextVisualCategory.Size = new System.Drawing.Size(221, 48);
            this.labelTextVisualCategory.TabIndex = 31;
            this.labelTextVisualCategory.Text = "Категория";
            // 
            // labelTextVisualName
            // 
            this.labelTextVisualName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualName.AutoSize = true;
            this.labelTextVisualName.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualName.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualName.Location = new System.Drawing.Point(514, 342);
            this.labelTextVisualName.Name = "labelTextVisualName";
            this.labelTextVisualName.Size = new System.Drawing.Size(208, 48);
            this.labelTextVisualName.TabIndex = 30;
            this.labelTextVisualName.Text = "Название";
            // 
            // labelTextVisualArticle
            // 
            this.labelTextVisualArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualArticle.AutoSize = true;
            this.labelTextVisualArticle.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualArticle.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualArticle.Location = new System.Drawing.Point(514, 431);
            this.labelTextVisualArticle.Name = "labelTextVisualArticle";
            this.labelTextVisualArticle.Size = new System.Drawing.Size(179, 48);
            this.labelTextVisualArticle.TabIndex = 29;
            this.labelTextVisualArticle.Text = "Артикул";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(876, 514);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(516, 65);
            this.cbCategory.TabIndex = 28;
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPrice.Location = new System.Drawing.Point(876, 612);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(516, 63);
            this.nudPrice.TabIndex = 27;
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUnit.ForeColor = System.Drawing.Color.Black;
            this.txtUnit.Location = new System.Drawing.Point(876, 706);
            this.txtUnit.Multiline = true;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUnit.Size = new System.Drawing.Size(516, 67);
            this.txtUnit.TabIndex = 26;
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArticle
            // 
            this.txtArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArticle.BackColor = System.Drawing.Color.White;
            this.txtArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtArticle.ForeColor = System.Drawing.Color.Black;
            this.txtArticle.Location = new System.Drawing.Point(876, 422);
            this.txtArticle.Multiline = true;
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArticle.Size = new System.Drawing.Size(516, 67);
            this.txtArticle.TabIndex = 25;
            this.txtArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(876, 332);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(516, 67);
            this.txtName.TabIndex = 24;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTextVisualEditProduct
            // 
            this.labelTextVisualEditProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualEditProduct.AutoSize = true;
            this.labelTextVisualEditProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualEditProduct.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualEditProduct.Location = new System.Drawing.Point(604, 140);
            this.labelTextVisualEditProduct.Name = "labelTextVisualEditProduct";
            this.labelTextVisualEditProduct.Size = new System.Drawing.Size(619, 67);
            this.labelTextVisualEditProduct.TabIndex = 35;
            this.labelTextVisualEditProduct.Text = "Редактировать товар";
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1886, 1130);
            this.Controls.Add(this.labelTextVisualEditProduct);
            this.Controls.Add(this.labelTextVisualUnit2);
            this.Controls.Add(this.labelTextVisualUnit);
            this.Controls.Add(this.labelTextVisualPrice);
            this.Controls.Add(this.labelTextVisualCategory);
            this.Controls.Add(this.labelTextVisualName);
            this.Controls.Add(this.labelTextVisualArticle);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOKE);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditProduct";
            this.Text = "FormEditProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOKE;
        private System.Windows.Forms.Label labelTextVisualUnit2;
        private System.Windows.Forms.Label labelTextVisualUnit;
        private System.Windows.Forms.Label labelTextVisualPrice;
        private System.Windows.Forms.Label labelTextVisualCategory;
        private System.Windows.Forms.Label labelTextVisualName;
        private System.Windows.Forms.Label labelTextVisualArticle;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelTextVisualEditProduct;
    }
}