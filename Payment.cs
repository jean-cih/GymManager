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
    public partial class Payment : Form
    {
        private SqlConnection Con = null;

        public Payment()
        {
            InitializeComponent();
        }

        private void object_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Capture = false;
            dataGridPay.Capture = false;
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

        private void Payment_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StudentsCS"].ConnectionString;

            Con = new SqlConnection(connectionString);

            FillName();
            populate();
        }

        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-S31A14E\SQLEXPRESS;Initial Catalog=GymDataBase;Integrated Security=true;");
        private async void FillName()
        {
            await Con.OpenAsync();
            SqlCommand cmd = new SqlCommand("select Name from MemberTb1", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Load(rdr);
            textName.ValueMember = "Name";
            textName.DataSource = dt;
            Con.Close();
        }

        private async void populate()
        {
            await Con.OpenAsync();
            string query = "select * from PaymentTb2";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridPay.DataSource = ds.Tables[0];
            Con.Close();
        }

        int keyPaid = 0;
        private async void payBut_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textAmount.Text == "" || textQuantity.Text == "")
            {
                MessageIncorrect messageIncorrect = new MessageIncorrect()
                {
                    BackgroundImage = Properties.Resources.missing
                };
                messageIncorrect.Show();
            }
            else
            {
                string payPeriod = Period.Value.Day.ToString("00") + "." + Period.Value.Month.ToString("00") + "." + Period.Value.Year.ToString();

                await Con.OpenAsync();
                string query = "select * from PaymentTb2 where Member='" + textName.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridPay.DataSource = ds.Tables[0];

                keyPaid = Convert.ToInt32(dataGridPay.Rows[0].Cells[0].Value.ToString());

                string query1 = "update PaymentTb2 set Member='" + textName.Text + "', Date='" + payPeriod + "',Amount='" + textAmount.Text + "',Quantity='" + textQuantity.Text + "',Code='" + textCode.Text + "' where Id='" + keyPaid + "';";
                SqlCommand cmd = new SqlCommand(query1, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populate();

                MessageIncorrect messageIncorrect = new MessageIncorrect()
                {
                    BackgroundImage = Properties.Resources.amountPaid
                };
                messageIncorrect.Show();
            }  
        } 

        private void refreshBut_Click(object sender, EventArgs e)
        {
            populate();
        }

        int key = 0;
        private void dataGridPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridPay.SelectedRows[0].Cells[0].Value.ToString());
            textName.Text = dataGridPay.SelectedRows[0].Cells[1].Value.ToString();
            textAmount.Text = dataGridPay.SelectedRows[0].Cells[3].Value.ToString();
            textQuantity.Text = dataGridPay.SelectedRows[0].Cells[4].Value.ToString();
            textCode.Text = dataGridPay.SelectedRows[0].Cells[5].Value.ToString();
        }

        private async void deleteBut_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageIncorrect messageIncorrect = new MessageIncorrect()
                {
                    BackgroundImage = Properties.Resources.select
                };
                messageIncorrect.Show();
            }
            else
            {
                try
                {
                    await Con.OpenAsync();
                    string query = "delete from PaymentTb2 where Id=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();

                    MessageIncorrect messageIncorrect = new MessageIncorrect()
                    {
                        BackgroundImage = Properties.Resources.memberDeleted
                    };
                    messageIncorrect.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterByCode();
            textMark.Text = "";
        }

        int keyQuantity = 0;
        private async void filterByCode()
        { 
            try
            {
                await Con.OpenAsync();
                string query = "select * from PaymentTb2 where Code='" + textMark.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridPay.DataSource = ds.Tables[0];

                Object quantity = dataGridPay.Rows[0].Cells[4].Value;

                if (quantity == null)
                {
                    Con.Close();
                    populate();
                    return;
                }

                if (quantity.ToString() == "0")
                {
                    MessageIncorrect messageInco = new MessageIncorrect()
                    {

                        BackgroundImage = Properties.Resources.visitsOver
                    };
                    messageInco.Show();
                    Con.Close();
                    return;
                }

                keyQuantity = Convert.ToInt32(dataGridPay.Rows[0].Cells[0].Value.ToString());

                if (quantity.ToString() == "Unlimited")
                {
                    string quantity1 = dataGridPay.Rows[0].Cells[2].Value.ToString();
                    string number = $"{quantity1[0]}{quantity1[1]}{quantity1[3]}{quantity1[4]}";

                    int prime = Convert.ToInt32(number) + 1;

                    if(prime % 100 > 12)
                    {
                        prime = 1;
                    }

                    DateTime now = DateTime.Now;

                    if(prime % 100 < now.Month)
                    {
                        MessageIncorrect messageIncorrect1 = new MessageIncorrect()
                        {
                            BackgroundImage = Properties.Resources.visitsOver
                        };
                        messageIncorrect1.Show();
                    }
                    else if(prime % 100 > now.Month)
                    {
                        MessageIncorrect messageIncorrect1 = new MessageIncorrect()
                        {
                            BackgroundImage = Properties.Resources.alreadiPaid
                        };
                        messageIncorrect1.Show();
                        await Task.Delay(2000);
                        messageIncorrect1.Hide();
                    }
                    else
                    {
                        if(prime / 100 < now.Day)
                        {
                            MessageIncorrect messageIncorrect1 = new MessageIncorrect()
                            {
                                BackgroundImage = Properties.Resources.visitsOver
                            };
                            messageIncorrect1.Show();
                        }
                        else
                        {
                            MessageIncorrect messageIncorrect1 = new MessageIncorrect()
                            {
                                BackgroundImage = Properties.Resources.alreadiPaid
                            };
                            messageIncorrect1.Show();
                            await Task.Delay(2000);
                            messageIncorrect1.Hide();
                        }
                    }
                    Con.Close();
                    return;
                }


                string query1 = "update PaymentTb2 set Quantity='" + (Convert.ToInt32(quantity) - 1) + "' where Id='" + keyQuantity + "';";
                SqlCommand cmd = new SqlCommand(query1, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populate();

                MessageIncorrect messageIncorrect = new MessageIncorrect()
                {
                    BackgroundImage = Properties.Resources.visitMarked
                };
                messageIncorrect.Show();
                await Task.Delay(2000);
                messageIncorrect.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textMark_TextChanged(object sender, EventArgs e)
        {
            if (textMark.Text.Length >= 13)
            {
                filterByCode();
                textMark.Text = "";
            }
        }
    }
}
