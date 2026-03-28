namespace branch_for_registration_1.Forms
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelTextVisualSearch = new System.Windows.Forms.Label();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.labelTextVisualArticle = new System.Windows.Forms.Label();
            this.labelTextVisualProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnCancel.Location = new System.Drawing.Point(133, 864);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(654, 86);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 20;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(994, 864);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(654, 86);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelTextVisualSearch
            // 
            this.labelTextVisualSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualSearch.AutoSize = true;
            this.labelTextVisualSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualSearch.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualSearch.Location = new System.Drawing.Point(797, 109);
            this.labelTextVisualSearch.Name = "labelTextVisualSearch";
            this.labelTextVisualSearch.Size = new System.Drawing.Size(198, 67);
            this.labelTextVisualSearch.TabIndex = 9;
            this.labelTextVisualSearch.Text = "Поиск";
            // 
            // txtArticle
            // 
            this.txtArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArticle.BackColor = System.Drawing.Color.White;
            this.txtArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtArticle.ForeColor = System.Drawing.Color.Black;
            this.txtArticle.Location = new System.Drawing.Point(755, 318);
            this.txtArticle.Multiline = true;
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArticle.Size = new System.Drawing.Size(516, 67);
            this.txtArticle.TabIndex = 10;
            this.txtArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(755, 439);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(516, 67);
            this.txtName.TabIndex = 11;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(755, 553);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(516, 65);
            this.cbCategory.TabIndex = 12;
            // 
            // labelTextVisualArticle
            // 
            this.labelTextVisualArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualArticle.AutoSize = true;
            this.labelTextVisualArticle.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualArticle.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualArticle.Location = new System.Drawing.Point(494, 318);
            this.labelTextVisualArticle.Name = "labelTextVisualArticle";
            this.labelTextVisualArticle.Size = new System.Drawing.Size(163, 44);
            this.labelTextVisualArticle.TabIndex = 13;
            this.labelTextVisualArticle.Text = "Артикул";
            // 
            // labelTextVisualProductName
            // 
            this.labelTextVisualProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextVisualProductName.AutoSize = true;
            this.labelTextVisualProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualProductName.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualProductName.Location = new System.Drawing.Point(494, 439);
            this.labelTextVisualProductName.Name = "labelTextVisualProductName";
            this.labelTextVisualProductName.Size = new System.Drawing.Size(190, 44);
            this.labelTextVisualProductName.TabIndex = 14;
            this.labelTextVisualProductName.Text = "Название";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(494, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Категория";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1812, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTextVisualProductName);
            this.Controls.Add(this.labelTextVisualArticle);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.labelTextVisualSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearch";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelTextVisualSearch;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label labelTextVisualArticle;
        private System.Windows.Forms.Label labelTextVisualProductName;
        private System.Windows.Forms.Label label1;
    }
}