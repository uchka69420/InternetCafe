using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void Cafeterialbl_Click(object sender, EventArgs e)
        {
            Cafeteria Obj = new Cafeteria();
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
            Members Obj = new Members();
            Obj.Show();
            this.Hide();
        }
    }
}
