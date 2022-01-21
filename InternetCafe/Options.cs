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

namespace InternetCafe
{
    public partial class Options : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["InternetCafe"].ConnectionString;
        public Options()
        {
            InitializeComponent();
        }
        private void Options_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetCafeDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersBindingSource1);
            // TODO: This line of code loads data into the 'internetCafeDataSet.PC' table. You can move, or remove it, as needed.
            this.pCTableAdapter.Fill(this.pCBindingSource);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PC(status)values('" + 1 + "')");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Амжилттай");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void dataselect()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * from Users", con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string name = textBox1.Text;
            string password = textBox2.Text;
            int balance = Int32.Parse(textBox3.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Users(username, password, balance) VALUES ('" + name + "','" + password + "','" + balance + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Амжилттай хадгаллаа", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
