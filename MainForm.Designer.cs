namespace GymBase
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.updateBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.pauBut = new System.Windows.Forms.Button();
            this.deleteBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logoAddMem = new System.Windows.Forms.Label();
            this.arrowBut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowBut)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GymBase.Properties.Resources.backgroundThree;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1320, 713);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.object_MouseMove);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImage = global::GymBase.Properties.Resources.rectangle;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.updateBut);
            this.panel.Controls.Add(this.addBut);
            this.panel.Controls.Add(this.pauBut);
            this.panel.Controls.Add(this.deleteBut);
            this.panel.Controls.Add(this.exitBut);
            this.panel.Location = new System.Drawing.Point(101, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1118, 117);
            this.panel.TabIndex = 7;
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.object_MouseMove);
            // 
            // updateBut
            // 
            this.updateBut.BackColor = System.Drawing.Color.Transparent;
            this.updateBut.BackgroundImage = global::GymBase.Properties.Resources.Обновить_Удалить;
            this.updateBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBut.FlatAppearance.BorderSize = 0;
            this.updateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBut.Location = new System.Drawing.Point(248, 13);
            this.updateBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(180, 90);
            this.updateBut.TabIndex = 8;
            this.updateBut.UseVisualStyleBackColor = false;
            this.updateBut.Click += new System.EventHandler(this.updateBut_Click);
            // 
            // addBut
            // 
            this.addBut.BackColor = System.Drawing.Color.Transparent;
            this.addBut.BackgroundImage = global::GymBase.Properties.Resources.Добавить_Клиента;
            this.addBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBut.FlatAppearance.BorderSize = 0;
            this.addBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(33, 13);
            this.addBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBut.Name = "addBut";
            this.addBut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addBut.Size = new System.Drawing.Size(180, 90);
            this.addBut.TabIndex = 8;
            this.addBut.UseMnemonic = false;
            this.addBut.UseVisualStyleBackColor = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // pauBut
            // 
            this.pauBut.BackColor = System.Drawing.Color.Transparent;
            this.pauBut.BackgroundImage = global::GymBase.Properties.Resources.Оплата_Посещение;
            this.pauBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauBut.FlatAppearance.BorderSize = 0;
            this.pauBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauBut.Location = new System.Drawing.Point(685, 13);
            this.pauBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pauBut.Name = "pauBut";
            this.pauBut.Size = new System.Drawing.Size(180, 90);
            this.pauBut.TabIndex = 10;
            this.pauBut.UseVisualStyleBackColor = false;
            this.pauBut.Click += new System.EventHandler(this.payBut_Click);
            // 
            // deleteBut
            // 
            this.deleteBut.BackColor = System.Drawing.Color.Transparent;
            this.deleteBut.BackgroundImage = global::GymBase.Properties.Resources.Список_Клиентов;
            this.deleteBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBut.FlatAppearance.BorderSize = 0;
            this.deleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBut.Location = new System.Drawing.Point(468, 13);
            this.deleteBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(180, 90);
            this.deleteBut.TabIndex = 9;
            this.deleteBut.UseVisualStyleBackColor = false;
            this.deleteBut.Click += new System.EventHandler(this.deleteBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.BackColor = System.Drawing.Color.Transparent;
            this.exitBut.BackgroundImage = global::GymBase.Properties.Resources.Выйти_Из_Аккаунта;
            this.exitBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBut.FlatAppearance.BorderSize = 0;
            this.exitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBut.Location = new System.Drawing.Point(904, 13);
            this.exitBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBut.Name = "exitBut";
            this.exitBut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitBut.Size = new System.Drawing.Size(180, 90);
            this.exitBut.TabIndex = 11;
            this.exitBut.UseVisualStyleBackColor = false;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GymBase.Properties.Resources.exitBut;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1250, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 65);
            this.button1.TabIndex = 54;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoAddMem
            // 
            this.logoAddMem.AutoSize = true;
            this.logoAddMem.BackColor = System.Drawing.Color.Transparent;
            this.logoAddMem.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoAddMem.ForeColor = System.Drawing.Color.White;
            this.logoAddMem.Location = new System.Drawing.Point(557, 248);
            this.logoAddMem.Name = "logoAddMem";
            this.logoAddMem.Size = new System.Drawing.Size(262, 70);
            this.logoAddMem.TabIndex = 27;
            this.logoAddMem.Text = "Siberian";
            // 
            // arrowBut
            // 
            this.arrowBut.BackColor = System.Drawing.Color.Transparent;
            this.arrowBut.BackgroundImage = global::GymBase.Properties.Resources.arrowDown;
            this.arrowBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowBut.Location = new System.Drawing.Point(25, 19);
            this.arrowBut.Name = "arrowBut";
            this.arrowBut.Size = new System.Drawing.Size(43, 59);
            this.arrowBut.TabIndex = 55;
            this.arrowBut.TabStop = false;
            this.arrowBut.Click += new System.EventHandler(this.arrowBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GymBase.Properties.Resources.backgroundThree;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 713);
            this.Controls.Add(this.arrowBut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoAddMem);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.arrowBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.Button pauBut;
        private System.Windows.Forms.Button updateBut;
        private System.Windows.Forms.Button deleteBut;
        private System.Windows.Forms.Label logoAddMem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.PictureBox arrowBut;
    }
}