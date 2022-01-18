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
    public partial class UserProfile : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string query;
        public UserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetCafeDataSet6.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.internetCafeDataSet6.Users);

            {
                try
                {
                    string select = listBox1.SelectedIndex.ToString();
                    query = "SELECT * FROM Users where username = '"+select+"'";
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    dt = new DataTable();
                    da.Fill(dt);

                    listBox1.DataSource = dt;
                    listBox1.DisplayMember = "username";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    da.Dispose();

                }

            }
        }
    }
}
