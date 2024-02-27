using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GymBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void object_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Capture = false;
            panel.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Hide();
        }

        private void updateBut_Click(object sender, EventArgs e)
        {
            UpdateDelete updateDelete = new UpdateDelete();
            updateDelete.Show();
            this.Hide();
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }

        private void payBut_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            Siberian siberian = new Siberian();
            siberian.Show();
            this.Hide();
        }

        Boolean b = true;
        private void arrowBut_Click(object sender, EventArgs e)
        {
            if (b)
            {
                panel.Location = new Point(76, 485);
                b = false;
                arrowBut.BackgroundImage = Properties.Resources.arrowUp;
            }
            else
            {
                panel.Location = new Point(76, 0);
                b = true;
                arrowBut.BackgroundImage = Properties.Resources.arrowDown;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
