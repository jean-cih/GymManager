using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GymBase
{
    public partial class ViewMembers : Form
    {
        private SqlConnection Con = null;

        public ViewMembers()
        {
            InitializeComponent();
        }

        private void object_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Capture = false;
            dataGridView.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-S31A14E\SQLEXPRESS;Initial Catalog=GymDataBase;Integrated Security=true;");
        private async void populate()
        {
            await Con.OpenAsync();
            string query = "select * from MemberTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private async void filterByName()
        {
            await Con.OpenAsync();
            string query = "select * from MemberTb1 where Name='" + textSearch.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StudentsCS"].ConnectionString;

            Con = new SqlConnection(connectionString);

            populate();
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private async void searchBut_Click(object sender, EventArgs e)
        {
            filterByName();
            textSearch.Text = "";
        }

        private void refreshBut_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
