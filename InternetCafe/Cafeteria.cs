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
    public partial class CfrmMain : Form

    {
        string constr = ConfigurationManager.ConnectionStrings["InternetCafe"].ConnectionString;
       
        public CfrmMain()
        {
            InitializeComponent();
        }
        
        private void Cafeteria_Load(object sender, EventArgs e)
        {

        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            btnFoods.Height = btnFoods.Height;
            btnFoods.Top = btnFoods.Top;
            pnlFoods.Visible = true;
            pnlDrinks.Visible = false;
            SqlConnection con = new SqlConnection(constr);
            string s = "SELECT * FROM Cafeteria WHERE food_type_id = 1";
            SqlDataAdapter adap = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Text = dt.Rows[i]["product_name"].ToString();
                btn.Tag = dt.Rows[i]["product_id"];
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += new EventHandler(btn_Click);
            }

        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id = Convert.ToInt32( button.Tag);

        }
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            btnDrinks.Height = btnDrinks.Height;
            btnDrinks.Top = btnDrinks.Top;
            pnlFoods.Visible = false;
            pnlDrinks.Visible = true;
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPizza_Click(object sender, EventArgs e)
        {

            string constr = ConfigurationManager.ConnectionStrings["InternetCafe"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);

        }

        private void pnlSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
