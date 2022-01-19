
namespace InternetCafe
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.internetCafeDataSet3 = new InternetCafe.InternetCafeDataSet3();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Orderlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logoutlbl = new System.Windows.Forms.Label();
            this.Memberslbl = new System.Windows.Forms.Label();
            this.Cashlbl = new System.Windows.Forms.Label();
            this.Cafeterialbl = new System.Windows.Forms.Label();
            this.Optionslbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.internetCafeDataSet1 = new InternetCafe.InternetCafeDataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new InternetCafe.InternetCafeDataSet1TableAdapters.UsersTableAdapter();
            this.internetCafeDataSet2 = new InternetCafe.InternetCafeDataSet2();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new InternetCafe.InternetCafeDataSet2TableAdapters.OrdersTableAdapter();
            this.ordersTableAdapter1 = new InternetCafe.InternetCafeDataSet3TableAdapters.OrdersTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(82, 159);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(90, 37);
            this.Deletebtn.TabIndex = 0;
            this.Deletebtn.Text = "Устгах ";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(195, 159);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(90, 37);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "Нэмэх ";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 644);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.pcidDataGridViewTextBoxColumn,
            this.order_date,
            this.enddateDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 442);
            this.dataGridView1.TabIndex = 4;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.internetCafeDataSet3;
            // 
            // internetCafeDataSet3
            // 
            this.internetCafeDataSet3.DataSetName = "InternetCafeDataSet3";
            this.internetCafeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 38);
            this.textBox1.TabIndex = 1;
            // 
            // Orderlbl
            // 
            this.Orderlbl.AutoSize = true;
            this.Orderlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderlbl.Location = new System.Drawing.Point(87, 65);
            this.Orderlbl.Name = "Orderlbl";
            this.Orderlbl.Size = new System.Drawing.Size(76, 26);
            this.Orderlbl.TabIndex = 3;
            this.Orderlbl.Text = "Order";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Logoutlbl);
            this.panel2.Controls.Add(this.Memberslbl);
            this.panel2.Controls.Add(this.Cashlbl);
            this.panel2.Controls.Add(this.Cafeterialbl);
            this.panel2.Controls.Add(this.Optionslbl);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 65);
            this.panel2.TabIndex = 2;
            // 
            // Logoutlbl
            // 
            this.Logoutlbl.AutoSize = true;
            this.Logoutlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlbl.ForeColor = System.Drawing.Color.Red;
            this.Logoutlbl.Location = new System.Drawing.Point(1055, 0);
            this.Logoutlbl.Name = "Logoutlbl";
            this.Logoutlbl.Size = new System.Drawing.Size(78, 23);
            this.Logoutlbl.TabIndex = 4;
            this.Logoutlbl.Text = "Logout";
            this.Logoutlbl.Click += new System.EventHandler(this.Logoutlbl_Click);
            // 
            // Memberslbl
            // 
            this.Memberslbl.AutoSize = true;
            this.Memberslbl.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memberslbl.Location = new System.Drawing.Point(748, 18);
            this.Memberslbl.Name = "Memberslbl";
            this.Memberslbl.Size = new System.Drawing.Size(107, 28);
            this.Memberslbl.TabIndex = 3;
            this.Memberslbl.Text = "Members";
            this.Memberslbl.Click += new System.EventHandler(this.Memberslbl_Click);
            // 
            // Cashlbl
            // 
            this.Cashlbl.AutoSize = true;
            this.Cashlbl.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cashlbl.Location = new System.Drawing.Point(596, 18);
            this.Cashlbl.Name = "Cashlbl";
            this.Cashlbl.Size = new System.Drawing.Size(66, 28);
            this.Cashlbl.TabIndex = 3;
            this.Cashlbl.Text = "Cash";
            this.Cashlbl.Click += new System.EventHandler(this.Cashlbl_Click);
            // 
            // Cafeterialbl
            // 
            this.Cafeterialbl.AutoSize = true;
            this.Cafeterialbl.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cafeterialbl.Location = new System.Drawing.Point(388, 18);
            this.Cafeterialbl.Name = "Cafeterialbl";
            this.Cafeterialbl.Size = new System.Drawing.Size(115, 28);
            this.Cafeterialbl.TabIndex = 3;
            this.Cafeterialbl.Text = "Cafeteria";
            this.Cafeterialbl.Click += new System.EventHandler(this.Cafeterialbl_Click);
            // 
            // Optionslbl
            // 
            this.Optionslbl.AutoSize = true;
            this.Optionslbl.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Optionslbl.Location = new System.Drawing.Point(233, 18);
            this.Optionslbl.Name = "Optionslbl";
            this.Optionslbl.Size = new System.Drawing.Size(94, 28);
            this.Optionslbl.TabIndex = 3;
            this.Optionslbl.Text = "Options";
            this.Optionslbl.Click += new System.EventHandler(this.Optionlbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // internetCafeDataSet1
            // 
            this.internetCafeDataSet1.DataSetName = "InternetCafeDataSet1";
            this.internetCafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.internetCafeDataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // internetCafeDataSet2
            // 
            this.internetCafeDataSet2.DataSetName = "InternetCafeDataSet2";
            this.internetCafeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.internetCafeDataSet2;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(562, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(699, 102);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(835, 102);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(975, 102);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(425, 190);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(562, 190);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(699, 190);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(835, 190);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 4;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(975, 190);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 4;
            this.pictureBox10.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(206, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // pcidDataGridViewTextBoxColumn
            // 
            this.pcidDataGridViewTextBoxColumn.DataPropertyName = "pc_id";
            this.pcidDataGridViewTextBoxColumn.HeaderText = "pc_id";
            this.pcidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pcidDataGridViewTextBoxColumn.Name = "pcidDataGridViewTextBoxColumn";
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            this.order_date.HeaderText = "order_date";
            this.order_date.MinimumWidth = 8;
            this.order_date.Name = "order_date";
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            // 
            // billDataGridViewTextBoxColumn
            // 
            this.billDataGridViewTextBoxColumn.DataPropertyName = "bill";
            this.billDataGridViewTextBoxColumn.HeaderText = "bill";
            this.billDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.billDataGridViewTextBoxColumn.Name = "billDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 739);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Orderlbl);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Orderlbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Memberslbl;
        private System.Windows.Forms.Label Cashlbl;
        private System.Windows.Forms.Label Cafeterialbl;
        private System.Windows.Forms.Label Optionslbl;
        private System.Windows.Forms.Label Logoutlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private InternetCafeDataSet1 internetCafeDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private InternetCafeDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private InternetCafeDataSet2 internetCafeDataSet2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private InternetCafeDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private InternetCafeDataSet3 internetCafeDataSet3;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private InternetCafeDataSet3TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
    }
}