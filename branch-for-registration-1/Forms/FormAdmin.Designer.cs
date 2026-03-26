namespace branch_for_registration_1.Forms
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.textBoxVisualAdmin = new System.Windows.Forms.TextBox();
            this.textBoxVisualFon = new System.Windows.Forms.TextBox();
            this.textBoxDecor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxVisualAdmin
            // 
            this.textBoxVisualAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxVisualAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVisualAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVisualAdmin.Location = new System.Drawing.Point(0, 25);
            this.textBoxVisualAdmin.Multiline = true;
            this.textBoxVisualAdmin.Name = "textBoxVisualAdmin";
            this.textBoxVisualAdmin.Size = new System.Drawing.Size(250, 57);
            this.textBoxVisualAdmin.TabIndex = 1;
            this.textBoxVisualAdmin.Text = "АДМИН-ПАНЕЛЬ";
            this.textBoxVisualAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVisualFon
            // 
            this.textBoxVisualFon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxVisualFon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVisualFon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVisualFon.Location = new System.Drawing.Point(0, -10);
            this.textBoxVisualFon.Multiline = true;
            this.textBoxVisualFon.Name = "textBoxVisualFon";
            this.textBoxVisualFon.ReadOnly = true;
            this.textBoxVisualFon.Size = new System.Drawing.Size(250, 881);
            this.textBoxVisualFon.TabIndex = 2;
            this.textBoxVisualFon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDecor
            // 
            this.textBoxDecor.BackColor = System.Drawing.Color.Black;
            this.textBoxDecor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDecor.Location = new System.Drawing.Point(29, 76);
            this.textBoxDecor.Multiline = true;
            this.textBoxDecor.Name = "textBoxDecor";
            this.textBoxDecor.ReadOnly = true;
            this.textBoxDecor.Size = new System.Drawing.Size(190, 3);
            this.textBoxDecor.TabIndex = 24;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1567, 857);
            this.Controls.Add(this.textBoxDecor);
            this.Controls.Add(this.textBoxVisualAdmin);
            this.Controls.Add(this.textBoxVisualFon);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxVisualAdmin;
        private System.Windows.Forms.TextBox textBoxVisualFon;
        private System.Windows.Forms.TextBox textBoxDecor;
    }
}