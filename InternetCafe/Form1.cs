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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["InternetCafe"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            string que = "SELECT * FROM Users WHERE username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "' ";
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter(que, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (textBox1.Text == "admin")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    //this.Close();
                    //ClientWindow clnt = ClientWindow();
                    //clnt.Show();
                }
            }
            else
            {
                label3.Text = "Хэрэглэгчийн нэр эсвэл нууц үг буруу байна!";
            }



        }
    }
}
