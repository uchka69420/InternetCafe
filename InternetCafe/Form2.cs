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

namespace InternetCafe
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.16.17.13;Initial Catalog=InternetCafe;Persist Security Info=True;User ID=sa;Password=101010");
        public Form2()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";

        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetCafeDataSet3.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.internetCafeDataSet3.Orders);
            // TODO: This line of code loads data into the 'internetCafeDataSet2.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.internetCafeDataSet2.Orders);
        }

        private void Optionlbl_Click(object sender, EventArgs e)
        {
            Options Obj = new Options();
            Obj.Show();
            this.Hide();
        }
        int key = 0;

        private void Deletebtn_Click(object sender, EventArgs e)
        {          
            if (key == 0)
            {
                MessageBox.Show("Алдаа гарлаа!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Orders where order_id=@Orid", con);
                cmd.Parameters.AddWithValue("@Orid", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Амжилттай устгагдлаа!");
                con.Close();
                Reset();
            }
        }

        private void Cafeterialbl_Click(object sender, EventArgs e)
        {
            CfrmMain Obj = new CfrmMain();
            Obj.Show();
            this.Hide();
        }

        private void Cashlbl_Click(object sender, EventArgs e)
        {
            Cash Obj = new Cash();
            Obj.Show();
            this.Hide();
        }

        private void Memberslbl_Click(object sender, EventArgs e)
        {
            UserProfile Obj = new UserProfile();
            Obj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Алдаа гарлаа!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Orders(number,order_date,pc_id,end_date,bill) values(@N,@Od,@Pi,@Ed,@Bill)", con);
                    cmd.Parameters.AddWithValue("@N", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Od", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Pi", comboBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Амжилттай бүртгэгдлээ!");
                    con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
