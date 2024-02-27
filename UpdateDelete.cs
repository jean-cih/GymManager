using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GymBase
{
    public partial class UpdateDelete : Form
    {
        private SqlConnection Con = null;

        public UpdateDelete()
        {
            InitializeComponent();
        }

        private void object_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Capture = false;
            dataGridView.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
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

        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-S31A14E\SQLEXPRESS;Initial Catalog=GymDataBase;Integrated Security=true;");
        private async void populate()
        {
            await Con.OpenAsync();
            string query = "select * from MemberTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StudentsCS"].ConnectionString;

            Con = new SqlConnection(connectionString);

            populate();
        }

        int key = 0;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
            textName.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            textNumber.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            comboGender.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            textAge.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            textAmount.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            comboTiming.Text = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageIncorrect messageInc = new MessageIncorrect()
                {
                    BackgroundImage = Properties.Resources.select
                };
                messageInc.Show();
            }
            else
            {
                try
                {
                    await Con.OpenAsync();
                    string query = "delete from MemberTb1 where Id=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageIncorrect messageIncorrect = new MessageIncorrect()
                    {
                        BackgroundImage = Properties.Resources.memberDeleted
                    };
                    messageIncorrect.Show();
                    Con.Close();
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void addBut_Click(object sender, EventArgs e)
        {
            if (key == 0 || textName.Text == "" || textNumber.Text == "" || textAge.Text == "" || comboGender.Text == "" || textAmount.Text == "" || comboTiming.Text == "") 
            {
                MessageIncorrect messageInc = new MessageIncorrect()
                {
                    BackgroundImage = Properties.Resources.missing
                };
                messageInc.Show();
            }
            else
            {
                try
                {
                    await Con.OpenAsync();
                    string query = "update MemberTb1 set Name='" + textName.Text + "', Phone='" + textNumber.Text + "',Gen='" + comboGender.Text + "',Age='" + textAge.Text + "',Amount='" + textAmount.Text + "',Timing='" + comboTiming.Text + "' where Id='" + key + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();

                    MessageIncorrect messageIncorrect = new MessageIncorrect()
                    {
                        BackgroundImage = Properties.Resources.memberUpdated
                    };
                    messageIncorrect.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
