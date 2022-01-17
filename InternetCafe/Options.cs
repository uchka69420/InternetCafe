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
    }
}
