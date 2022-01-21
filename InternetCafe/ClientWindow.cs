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
using System.Configuration;

namespace InternetCafe
{
    public partial class ClientWindow : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["InternetCafe"].ConnectionString);
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
            //Cafeteria cafe = new Cafeteria();
            //cafe.Show();
        }

        private void ClientWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
