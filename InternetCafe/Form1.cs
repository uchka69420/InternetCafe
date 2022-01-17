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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string constr = "Data Source=172.16.17.13;Initial Catalog=InternetCafe;User ID=sa;Password=101010";
            string que = "SELECT * FROM Users WHERE username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "' ";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter(que, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                label3.Text = "Хэрэглэгчийн нэр эсвэл нууц үг буруу байна!";
            }



        }
    }
}
