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
    public partial class Options : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.16.17.13;Initial Catalog=InternetCafe;Persist Security Info=True;User ID=sa;Password=101010");
        public Options()
        {
            InitializeComponent();
        }
        private void Options_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetCafeDataSet5.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.internetCafeDataSet5.Users);
            // TODO: This line of code loads data into the 'internetCafeDataSet4.PC' table. You can move, or remove it, as needed.
            this.pCTableAdapter.Fill(this.internetCafeDataSet4.PC);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PC(status)values('" + 1 + "'");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Амжилттай");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
