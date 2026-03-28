namespace branch_for_registration_1.Forms
{
    partial class FormEditCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCategory));
            this.labelTextVisualAddProduct = new System.Windows.Forms.Label();
            this.labelTextVisualNameCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTextVisualAddProduct
            // 
            this.labelTextVisualAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualAddProduct.AutoSize = true;
            this.labelTextVisualAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualAddProduct.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualAddProduct.Location = new System.Drawing.Point(480, 59);
            this.labelTextVisualAddProduct.Name = "labelTextVisualAddProduct";
            this.labelTextVisualAddProduct.Size = new System.Drawing.Size(781, 67);
            this.labelTextVisualAddProduct.TabIndex = 18;
            this.labelTextVisualAddProduct.Text = "Редактирование категории";
            // 
            // labelTextVisualNameCategory
            // 
            this.labelTextVisualNameCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualNameCategory.AutoSize = true;
            this.labelTextVisualNameCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualNameCategory.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualNameCategory.Location = new System.Drawing.Point(345, 479);
            this.labelTextVisualNameCategory.Name = "labelTextVisualNameCategory";
            this.labelTextVisualNameCategory.Size = new System.Drawing.Size(208, 48);
            this.labelTextVisualNameCategory.TabIndex = 20;
            this.labelTextVisualNameCategory.Text = "Название";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(735, 469);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(692, 65);
            this.cbCategory.TabIndex = 21;
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
            this.btnCancel.Location = new System.Drawing.Point(53, 838);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(447, 86);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 20;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(650, 838);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(447, 86);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 20;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1251, 838);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(447, 86);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(735, 368);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(516, 67);
            this.txtName.TabIndex = 26;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(800, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "или ввести самому";
            // 
            // FormEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1769, 1093);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.labelTextVisualNameCategory);
            this.Controls.Add(this.labelTextVisualAddProduct);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditCategory";
            this.Text = "FormAddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextVisualAddProduct;
        private System.Windows.Forms.Label labelTextVisualNameCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}