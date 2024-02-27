using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GymBase
{
    public partial class Siberian : Form
    {
        public Siberian()
        { 
            InitializeComponent();
        }

        private void object_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Capture = false;
            pictureBear.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void loginBut_Click(object sender, EventArgs e)
        {
            if(textUser.Text == "jean" && textLock.Text == "jean")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();  
            }
            else if(textUser.Text == "" && textLock.Text == "")
            {
                incoLogin.Location = new Point(320, 121);
                incoPassword.Location = new Point(320, 187);
                incoLogin.Text = incoPassword.Text = "Пустая Строка";
                visible_Line();
            }
            else
            {
                textUser.Text = "";
                textLock.Text = "";
                incoLogin.Location = new Point(314, 121);
                incoPassword.Location = new Point(304, 187);
                incoLogin.Text = "Неверный Логин";
                incoPassword.Text = "Неверный Пароль";
                visible_Line();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            login.Visible = false;
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Visible = false;
        }

        private async void visible_Line()
        {
            incoLogin.Visible = true;
            incoPassword.Visible = true;
            await Task.Delay(2000);
            incoLogin.Visible = false;
            incoPassword.Visible = false;
        }
    }
}
