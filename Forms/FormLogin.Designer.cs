using System.Drawing;


namespace branch_for_registration_1.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelTextVisualAuth = new System.Windows.Forms.Label();
            this.labelTextVisualEmailOne = new System.Windows.Forms.Label();
            this.labelTextVisualEmailTwo = new System.Windows.Forms.Label();
            this.labelTextVisualPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.Location = new System.Drawing.Point(697, 350);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxEmail.Size = new System.Drawing.Size(516, 67);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(697, 476);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(516, 64);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRegister.Location = new System.Drawing.Point(446, 615);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(767, 74);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "Нет аккаунта? Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatAppearance.BorderSize = 20;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(446, 715);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(767, 121);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelError.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelError.Location = new System.Drawing.Point(450, 835);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 4;
            // 
            // labelTextVisualAuth
            // 
            this.labelTextVisualAuth.AutoSize = true;
            this.labelTextVisualAuth.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualAuth.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualAuth.Location = new System.Drawing.Point(601, 202);
            this.labelTextVisualAuth.Name = "labelTextVisualAuth";
            this.labelTextVisualAuth.Size = new System.Drawing.Size(433, 75);
            this.labelTextVisualAuth.TabIndex = 8;
            this.labelTextVisualAuth.Text = "Авторизация";
            // 
            // labelTextVisualEmailOne
            // 
            this.labelTextVisualEmailOne.AutoSize = true;
            this.labelTextVisualEmailOne.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualEmailOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualEmailOne.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualEmailOne.Location = new System.Drawing.Point(428, 337);
            this.labelTextVisualEmailOne.Name = "labelTextVisualEmailOne";
            this.labelTextVisualEmailOne.Size = new System.Drawing.Size(251, 44);
            this.labelTextVisualEmailOne.TabIndex = 9;
            this.labelTextVisualEmailOne.Text = "Электронная";
            this.labelTextVisualEmailOne.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTextVisualEmailTwo
            // 
            this.labelTextVisualEmailTwo.AutoSize = true;
            this.labelTextVisualEmailTwo.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualEmailTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualEmailTwo.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualEmailTwo.Location = new System.Drawing.Point(428, 381);
            this.labelTextVisualEmailTwo.Name = "labelTextVisualEmailTwo";
            this.labelTextVisualEmailTwo.Size = new System.Drawing.Size(119, 44);
            this.labelTextVisualEmailTwo.TabIndex = 10;
            this.labelTextVisualEmailTwo.Text = "почта";
            // 
            // labelTextVisualPassword
            // 
            this.labelTextVisualPassword.AutoSize = true;
            this.labelTextVisualPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelTextVisualPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextVisualPassword.ForeColor = System.Drawing.Color.Black;
            this.labelTextVisualPassword.Location = new System.Drawing.Point(428, 487);
            this.labelTextVisualPassword.Name = "labelTextVisualPassword";
            this.labelTextVisualPassword.Size = new System.Drawing.Size(151, 44);
            this.labelTextVisualPassword.TabIndex = 11;
            this.labelTextVisualPassword.Text = "Пароль";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1626, 1016);
            this.Controls.Add(this.labelTextVisualPassword);
            this.Controls.Add(this.labelTextVisualEmailTwo);
            this.Controls.Add(this.labelTextVisualEmailOne);
            this.Controls.Add(this.labelTextVisualAuth);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelTextVisualAuth;
        private System.Windows.Forms.Label labelTextVisualEmailOne;
        private System.Windows.Forms.Label labelTextVisualEmailTwo;
        private System.Windows.Forms.Label labelTextVisualPassword;
    }
}