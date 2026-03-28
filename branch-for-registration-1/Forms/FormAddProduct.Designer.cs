namespace branch_for_registration_1.Forms
{
    partial class FormAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.labelTextVisualAddProduct = new System.Windows.Forms.Label();
            this.labelTextVisualArticle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTextVisualCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTextVisualUnit = new System.Windows.Forms.Label();
            this.labelTextVisualUnit2 = new System.Windows.Forms.Label();
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
            this.btnCancel.Location = new System.Drawing.Point(145, 940);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(654, 86);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.AutoSize = true;
            this.btnOK.BackColor = System.Drawing.Color.Black;
            this.btnOK.FlatAppearance.BorderSize = 20;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(1017, 940);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(654, 86);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Добавить";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(879, 304);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(516, 67);
            this.txtName.TabIndex = 11;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArticle
            // 
            this.txtArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArticle.BackColor = System.Drawing.Color.White;
            this.txtArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtArticle.ForeColor = System.Drawing.Color.Black;
            this.txtArticle.Location = new System.Drawing.Point(879, 394);
            this.txtArticle.Multiline = true;
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArticle.Size = new System.Drawing.Size(516, 67);
            this.txtArticle.TabIndex = 12;
            this.txtArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUnit.ForeColor = System.Drawing.Color.Black;
            this.txtUnit.Location = new System.Drawing.Point(879, 665);
            this.txtUnit.Multiline = true;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUnit.Size = new System.Drawing.Size(516, 67);
            this.txtUnit.TabIndex = 14;
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudPrice
            // 
            this.nudPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPrice.Location = new System.Drawing.Point(879, 575);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(516, 63);
            this.nudPrice.TabIndex = 15;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(879, 486);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(516, 65);
            this.cbCategory.TabIndex = 16;
            // 
            // labelTextVisualAddProduct
            // 
            this.labelTextVisualAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualAddProduct.AutoSize = true;
            this.labelTextVisualAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualAddProduct.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualAddProduct.Location = new System.Drawing.Point(687, 104);
            this.labelTextVisualAddProduct.Name = "labelTextVisualAddProduct";
            this.labelTextVisualAddProduct.Size = new System.Drawing.Size(470, 67);
            this.labelTextVisualAddProduct.TabIndex = 17;
            this.labelTextVisualAddProduct.Text = "Добавить товар";
            // 
            // labelTextVisualArticle
            // 
            this.labelTextVisualArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualArticle.AutoSize = true;
            this.labelTextVisualArticle.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualArticle.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualArticle.Location = new System.Drawing.Point(517, 403);
            this.labelTextVisualArticle.Name = "labelTextVisualArticle";
            this.labelTextVisualArticle.Size = new System.Drawing.Size(179, 48);
            this.labelTextVisualArticle.TabIndex = 18;
            this.labelTextVisualArticle.Text = "Артикул";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(517, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 48);
            this.label1.TabIndex = 19;
            this.label1.Text = "Название";
            // 
            // labelTextVisualCategory
            // 
            this.labelTextVisualCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualCategory.AutoSize = true;
            this.labelTextVisualCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualCategory.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualCategory.Location = new System.Drawing.Point(517, 496);
            this.labelTextVisualCategory.Name = "labelTextVisualCategory";
            this.labelTextVisualCategory.Size = new System.Drawing.Size(221, 48);
            this.labelTextVisualCategory.TabIndex = 20;
            this.labelTextVisualCategory.Text = "Категория";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(517, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 48);
            this.label3.TabIndex = 21;
            this.label3.Text = "Цена закупки";
            // 
            // labelTextVisualUnit
            // 
            this.labelTextVisualUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualUnit.AutoSize = true;
            this.labelTextVisualUnit.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualUnit.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualUnit.Location = new System.Drawing.Point(517, 665);
            this.labelTextVisualUnit.Name = "labelTextVisualUnit";
            this.labelTextVisualUnit.Size = new System.Drawing.Size(188, 48);
            this.labelTextVisualUnit.TabIndex = 22;
            this.labelTextVisualUnit.Text = "Единица";
            // 
            // labelTextVisualUnit2
            // 
            this.labelTextVisualUnit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualUnit2.AutoSize = true;
            this.labelTextVisualUnit2.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualUnit2.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualUnit2.Location = new System.Drawing.Point(517, 713);
            this.labelTextVisualUnit2.Name = "labelTextVisualUnit2";
            this.labelTextVisualUnit2.Size = new System.Drawing.Size(232, 48);
            this.labelTextVisualUnit2.TabIndex = 23;
            this.labelTextVisualUnit2.Text = "измерения";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1833, 1126);
            this.Controls.Add(this.labelTextVisualUnit2);
            this.Controls.Add(this.labelTextVisualUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTextVisualCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTextVisualArticle);
            this.Controls.Add(this.labelTextVisualAddProduct);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddProduct";
            this.Text = "AddGood";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label labelTextVisualAddProduct;
        private System.Windows.Forms.Label labelTextVisualArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTextVisualCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTextVisualUnit;
        private System.Windows.Forms.Label labelTextVisualUnit2;
    }
}