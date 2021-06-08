namespace AuthLog
{
    partial class RegisterForm
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
            this.close = new System.Windows.Forms.Label();
            this.auth = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.userSurname = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.PictureBox();
            this.registerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close.Location = new System.Drawing.Point(767, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 31);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // auth
            // 
            this.auth.AutoSize = true;
            this.auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.auth.Location = new System.Drawing.Point(235, 23);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(367, 53);
            this.auth.TabIndex = 8;
            this.auth.Text = "РЕГИСТРАЦИЯ";
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(81, 176);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(333, 49);
            this.loginField.TabIndex = 10;

            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(81, 262);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(333, 49);
            this.passField.TabIndex = 12;
            this.passField.UseSystemPasswordChar = true;
            // 
            // register
            // 
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.register.Location = new System.Drawing.Point(234, 345);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(368, 48);
            this.register.TabIndex = 13;
            this.register.Text = "зарегистрироваться";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(434, 176);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(333, 49);
            this.userName.TabIndex = 14;
            this.userName.Enter += new System.EventHandler(this.userName_Enter);
            this.userName.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // userSurname
            // 
            this.userSurname.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSurname.Location = new System.Drawing.Point(434, 262);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(333, 49);
            this.userSurname.TabIndex = 15;
            this.userSurname.Enter += new System.EventHandler(this.userSurname_Enter);
            this.userSurname.Leave += new System.EventHandler(this.userSurname_Leave);
            // 
            // pass
            // 
            this.pass.Image = global::AuthLog.Properties.Resources.Монтажная_область_5;
            this.pass.Location = new System.Drawing.Point(11, 252);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(64, 64);
            this.pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pass.TabIndex = 11;
            this.pass.TabStop = false;
            // 
            // user
            // 
            this.user.Image = global::AuthLog.Properties.Resources.Монтажная_область_9;
            this.user.Location = new System.Drawing.Point(11, 167);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(64, 64);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user.TabIndex = 9;
            this.user.TabStop = false;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerLabel.Location = new System.Drawing.Point(352, 424);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(114, 17);
            this.registerLabel.TabIndex = 16;
            this.registerLabel.Text = "Авторизоваться";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.register);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.user);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label auth;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pass;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userSurname;
        private System.Windows.Forms.Label registerLabel;
    }
}