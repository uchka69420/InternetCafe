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
using System.Timers;

namespace InternetCafe
{
    public partial class ClientWindow : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.16.17.13;Initial Catalog=InternetCafe;Persist Security Info=True;User ID=sa;Password=101010");
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            UserProfile profile = new UserProfile();
            profile.Show();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void захиалгаӨгөхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cafeteria cafe = new Cafeteria();
            cafe.Show();
        }

        private void ClientWindow_Load(object sender, EventArgs e)
        {
            int balance = 
            System.Timers.Timer timer = new System.Timers.Timer();
        }
    }
}
