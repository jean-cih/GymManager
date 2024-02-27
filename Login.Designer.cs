namespace GymBase
{
    partial class Siberian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siberian));
            this.logo = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textLock = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.incoLogin = new System.Windows.Forms.Label();
            this.incoPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loginBut = new System.Windows.Forms.Button();
            this.pictureLock = new System.Windows.Forms.PictureBox();
            this.pictureFrame2 = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictureBear = new System.Windows.Forms.PictureBox();
            this.pictureFrame1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.ForeColor = System.Drawing.Color.Black;
            this.logo.Location = new System.Drawing.Point(408, 35);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(179, 44);
            this.logo.TabIndex = 1;
            this.logo.Text = "Сибиряк";
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.White;
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textUser.Location = new System.Drawing.Point(380, 106);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(210, 34);
            this.textUser.TabIndex = 2;
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLock
            // 
            this.textLock.BackColor = System.Drawing.Color.White;
            this.textLock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLock.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLock.Location = new System.Drawing.Point(380, 188);
            this.textLock.Name = "textLock";
            this.textLock.PasswordChar = '*';
            this.textLock.Size = new System.Drawing.Size(210, 34);
            this.textLock.TabIndex = 7;
            this.textLock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(380, 106);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(209, 34);
            this.login.TabIndex = 29;
            this.login.Text = "       Логин       ";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(380, 188);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(191, 34);
            this.password.TabIndex = 30;
            this.password.Text = "      Пароль   ";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // incoLogin
            // 
            this.incoLogin.AutoSize = true;
            this.incoLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incoLogin.Location = new System.Drawing.Point(443, 151);
            this.incoLogin.Name = "incoLogin";
            this.incoLogin.Size = new System.Drawing.Size(138, 21);
            this.incoLogin.TabIndex = 31;
            this.incoLogin.Text = "Пустая Строка";
            this.incoLogin.Visible = false;
            // 
            // incoPassword
            // 
            this.incoPassword.AutoSize = true;
            this.incoPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incoPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incoPassword.Location = new System.Drawing.Point(443, 233);
            this.incoPassword.Name = "incoPassword";
            this.incoPassword.Size = new System.Drawing.Size(138, 21);
            this.incoPassword.TabIndex = 32;
            this.incoPassword.Text = "Пустая Строка";
            this.incoPassword.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GymBase.Properties.Resources.exitButReverse;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-4, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 65);
            this.button1.TabIndex = 27;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.SystemColors.Window;
            this.loginBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBut.BackgroundImage")));
            this.loginBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBut.FlatAppearance.BorderSize = 0;
            this.loginBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBut.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.loginBut.Location = new System.Drawing.Point(432, 268);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(125, 60);
            this.loginBut.TabIndex = 10;
            this.loginBut.Text = "Войти";
            this.loginBut.UseVisualStyleBackColor = false;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // pictureLock
            // 
            this.pictureLock.BackColor = System.Drawing.Color.Transparent;
            this.pictureLock.Image = global::GymBase.Properties.Resources.Lock;
            this.pictureLock.Location = new System.Drawing.Point(592, 188);
            this.pictureLock.Name = "pictureLock";
            this.pictureLock.Size = new System.Drawing.Size(37, 34);
            this.pictureLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLock.TabIndex = 8;
            this.pictureLock.TabStop = false;
            // 
            // pictureFrame2
            // 
            this.pictureFrame2.Image = global::GymBase.Properties.Resources.Frame;
            this.pictureFrame2.Location = new System.Drawing.Point(360, 180);
            this.pictureFrame2.Name = "pictureFrame2";
            this.pictureFrame2.Size = new System.Drawing.Size(279, 60);
            this.pictureFrame2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFrame2.TabIndex = 9;
            this.pictureFrame2.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureUser.Image = global::GymBase.Properties.Resources.User;
            this.pictureUser.Location = new System.Drawing.Point(592, 107);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(37, 34);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 3;
            this.pictureUser.TabStop = false;
            // 
            // pictureBear
            // 
            this.pictureBear.Image = global::GymBase.Properties.Resources.LogoPicture;
            this.pictureBear.Location = new System.Drawing.Point(63, 88);
            this.pictureBear.Name = "pictureBear";
            this.pictureBear.Size = new System.Drawing.Size(256, 192);
            this.pictureBear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBear.TabIndex = 0;
            this.pictureBear.TabStop = false;
            this.pictureBear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.object_MouseMove);
            // 
            // pictureFrame1
            // 
            this.pictureFrame1.Image = global::GymBase.Properties.Resources.Frame;
            this.pictureFrame1.Location = new System.Drawing.Point(360, 98);
            this.pictureFrame1.Name = "pictureFrame1";
            this.pictureFrame1.Size = new System.Drawing.Size(279, 60);
            this.pictureFrame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFrame1.TabIndex = 6;
            this.pictureFrame1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GymBase.Properties.Resources.farBackOne;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.object_MouseMove);
            // 
            // Siberian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 388);
            this.Controls.Add(this.incoPassword);
            this.Controls.Add(this.incoLogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.pictureLock);
            this.Controls.Add(this.textLock);
            this.Controls.Add(this.pictureFrame2);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBear);
            this.Controls.Add(this.pictureFrame1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Siberian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siberian";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBear;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.PictureBox pictureFrame1;
        private System.Windows.Forms.PictureBox pictureLock;
        private System.Windows.Forms.TextBox textLock;
        private System.Windows.Forms.PictureBox pictureFrame2;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label incoLogin;
        private System.Windows.Forms.Label incoPassword;
    }
}

