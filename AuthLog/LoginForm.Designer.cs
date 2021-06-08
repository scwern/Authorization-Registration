namespace AuthLog
{
    partial class BG
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BG));
            this.close = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.PictureBox();
            this.auth = new System.Windows.Forms.Label();
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
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(768, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 31);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(262, 249);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(333, 49);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(262, 161);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(333, 45);
            this.loginField.TabIndex = 5;
            this.loginField.UseSystemPasswordChar = true;
            // 
            // enter
            // 
            this.enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter.BackgroundImage")));
            this.enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(309, 329);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(213, 66);
            this.enter.TabIndex = 6;
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // pass
            // 
            this.pass.Image = ((System.Drawing.Image)(resources.GetObject("pass.Image")));
            this.pass.Location = new System.Drawing.Point(192, 239);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(64, 64);
            this.pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pass.TabIndex = 1;
            this.pass.TabStop = false;
            // 
            // user
            // 
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(192, 152);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(64, 64);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user.TabIndex = 0;
            this.user.TabStop = false;
            // 
            // auth
            // 
            this.auth.AutoSize = true;
            this.auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.auth.Location = new System.Drawing.Point(222, 30);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(373, 53);
            this.auth.TabIndex = 9;
            this.auth.Text = "АВТОРИЗАЦИЯ";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerLabel.Location = new System.Drawing.Point(341, 424);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(144, 17);
            this.registerLabel.TabIndex = 10;
            this.registerLabel.Text = "Зарегистрироваться";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // BG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";

            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BG_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BG_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.PictureBox pass;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label auth;
        private System.Windows.Forms.Label registerLabel;
    }
}

