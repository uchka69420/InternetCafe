
namespace InternetCafe
{
    partial class ClientWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cafeteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.захиалгаӨгөхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControl1 = new System.Windows.Forms.UserControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cafeteriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // cafeteriaToolStripMenuItem
            // 
            this.cafeteriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.захиалгаӨгөхToolStripMenuItem});
            this.cafeteriaToolStripMenuItem.Name = "cafeteriaToolStripMenuItem";
            this.cafeteriaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cafeteriaToolStripMenuItem.Text = "Cafeteria";
            // 
            // захиалгаӨгөхToolStripMenuItem
            // 
            this.захиалгаӨгөхToolStripMenuItem.Name = "захиалгаӨгөхToolStripMenuItem";
            this.захиалгаӨгөхToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.захиалгаӨгөхToolStripMenuItem.Text = "Захиалга өгөх";
            this.захиалгаӨгөхToolStripMenuItem.Click += new System.EventHandler(this.захиалгаӨгөхToolStripMenuItem_Click);
            // 
            // userControl1
            // 
            this.userControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl1.ForeColor = System.Drawing.Color.Red;
            this.userControl1.Location = new System.Drawing.Point(596, 27);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(117, 334);
            this.userControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(639, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(639, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Эхэлсэн хугацаа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Үлдсэн хугацаа";
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientWindow";
            this.Text = "ClientWindow";
            this.Load += new System.EventHandler(this.ClientWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cafeteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem захиалгаӨгөхToolStripMenuItem;
        private System.Windows.Forms.UserControl userControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}