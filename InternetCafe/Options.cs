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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
