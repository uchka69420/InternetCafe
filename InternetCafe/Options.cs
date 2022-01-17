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
        
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Library Database;Persist Security Info=True;User ID=sa;Password=101010");
            SqlCommand cmd;
            SqlDataAdapter adapt;
            int id = 0;
            public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetCafeDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.internetCafeDataSet1.Users);
            // TODO: This line of code loads data into the 'internetCafeDataSet.PC' table. You can move, or remove it, as needed.
            this.pCTableAdapter.Fill(this.internetCafeDataSet.PC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into PC values(status)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@status", 1);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string status = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                cmd = new SqlCommand("delete PC where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
