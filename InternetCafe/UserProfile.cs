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
    public partial class UserProfile : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["InternetCafe"].ConnectionString);
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

            {
                try
                {
                    query = "SELECT username FROM Users";
                    cmd = new SqlCommand();
                    cmd.Connection = con;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string username = listBox1.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE username = '" + username + "'");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1.Text = dr["username"].ToString();
                textBox2.Text = dr["password"].ToString();
            }
            con.Close();

        }
    }
}
