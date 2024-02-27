using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace GymBase
{
    public partial class AddMember : Form
    {
        private SqlConnection Con = null;
        public AddMember()
        {
            InitializeComponent();
        }

        private void object_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StudentsCS"].ConnectionString;

            Con = new SqlConnection(connectionString);
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-S31A14E\SQLEXPRESS;Initial Catalog=GymDataBase;Integrated Security=true;");
        private async void addBut_Click(object sender, EventArgs e)
        {
            if(NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "" )
            {
                emptyName.Visible = true;
                emptyNumber.Visible = true;
                emptyAge.Visible = true;
                emptyAmount.Visible = true;
                await Task.Delay(2000);
                emptyName.Visible = false;
                emptyNumber.Visible = false;
                emptyAge.Visible = false;
                emptyAmount.Visible = false;
            }
            else
            {
                try
                {
                    if(comboGender.Text == "")
                    {
                        comboGender.Text = " ";
                    }
                    if(comboTiming.Text == "")
                    {
                        comboTiming.Text = " ";
                    }
                    DateTime now = DateTime.Now;
                    await Con.OpenAsync();
                    string query = "insert into MemberTb1 values('"+NameTb.Text+"','"+PhoneTb.Text+"','"+comboGender.SelectedItem.ToString()+"','"+AgeTb.Text+"','"+AmountTb.Text+"','"+comboTiming.SelectedItem.ToString()+"')";
                    string query2 = "insert into PaymentTb2 values('" + NameTb.Text + "','" + now.ToString("d") + "','" + AmountTb.Text + "','" + textQuantity.Text + "','" + textCode.Text + "')";   
                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlCommand cmd2 = new SqlCommand(query2, Con);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    Con.Close();
                    AmountTb.Text = "";
                    AgeTb.Text = "";
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    comboGender.Text = "";
                    comboTiming.Text = "";
                    textQuantity.Text = "";
                    textCode.Text = "";

                    MessageIncorrect messageIncorrect = new MessageIncorrect()
                    {
                        BackgroundImage = Properties.Resources.memberAdded
                    };
                    messageIncorrect.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void viewBut_Click(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }
    }
}
