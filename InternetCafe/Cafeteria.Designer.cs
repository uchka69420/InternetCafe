
namespace InternetCafe
{
    partial class CfrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnFoods = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlFoods = new System.Windows.Forms.Panel();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmCola = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSprite = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSide.SuspendLayout();
            this.pnlFoods.SuspendLayout();
            this.pnlDrinks.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlSide.Controls.Add(this.label3);
            this.pnlSide.Controls.Add(this.button4);
            this.pnlSide.Controls.Add(this.button3);
            this.pnlSide.Controls.Add(this.btnDrinks);
            this.pnlSide.Controls.Add(this.btnFoods);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 448);
            this.pnlSide.TabIndex = 0;
            this.pnlSide.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSide_Paint);
            // 
            // btnFoods
            // 
            this.btnFoods.Location = new System.Drawing.Point(0, 129);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.Size = new System.Drawing.Size(200, 40);
            this.btnFoods.TabIndex = 0;
            this.btnFoods.Text = "Foods";
            this.btnFoods.UseVisualStyleBackColor = true;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(0, 186);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(200, 40);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(601, 24);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlFoods
            // 
            this.pnlFoods.Controls.Add(this.flowLayoutPanel1);
            this.pnlFoods.Location = new System.Drawing.Point(200, 22);
            this.pnlFoods.Name = "pnlFoods";
            this.pnlFoods.Size = new System.Drawing.Size(601, 425);
            this.pnlFoods.TabIndex = 2;
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.panel4);
            this.pnlDrinks.Controls.Add(this.panel1);
            this.pnlDrinks.Location = new System.Drawing.Point(200, 22);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(601, 425);
            this.pnlDrinks.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btmCola);
            this.panel1.Location = new System.Drawing.Point(36, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 114);
            this.panel1.TabIndex = 2;
            // 
            // btmCola
            // 
            this.btmCola.Location = new System.Drawing.Point(33, 22);
            this.btmCola.Name = "btmCola";
            this.btmCola.Size = new System.Drawing.Size(137, 69);
            this.btmCola.TabIndex = 0;
            this.btmCola.Text = "Cola";
            this.btmCola.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSprite);
            this.panel4.Location = new System.Drawing.Point(291, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 114);
            this.panel4.TabIndex = 3;
            // 
            // btnSprite
            // 
            this.btnSprite.Location = new System.Drawing.Point(33, 22);
            this.btnSprite.Name = "btnSprite";
            this.btnSprite.Size = new System.Drawing.Size(137, 69);
            this.btnSprite.TabIndex = 0;
            this.btnSprite.Text = "Sprite";
            this.btnSprite.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 107);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(538, 211);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mon Motter", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cafe";
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 448);
            this.Controls.Add(this.pnlFoods);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSide);
            this.Name = "CfrmMain";
            this.Text = "Cafeteria";
            this.Load += new System.EventHandler(this.Cafeteria_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.pnlFoods.ResumeLayout(false);
            this.pnlDrinks.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnFoods;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFoods;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSprite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btmCola;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
    }
}