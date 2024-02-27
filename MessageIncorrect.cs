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
    public partial class MessageIncorrect : Form
    {
        public MessageIncorrect()
        {
            InitializeComponent();         
        }

        private void object_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Capture = false;
            panel1.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
