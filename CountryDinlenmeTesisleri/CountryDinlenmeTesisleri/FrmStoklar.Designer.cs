namespace CountryTatilKöyü
{
    partial class FrmStoklar
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
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            txtİcecek = new TextBox();
            txtAtistirmalik = new TextBox();
            txtGida = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button2 = new Button();
            txtSu = new TextBox();
            txtİnternet = new TextBox();
            txtElektrik = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtİcecek);
            groupBox1.Controls.Add(txtAtistirmalik);
            groupBox1.Controls.Add(txtGida);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 474);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stoklar";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(8, 270);
            listView1.Name = "listView1";
            listView1.Size = new Size(438, 182);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Gıdalar";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İçecekler";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Atıştırmalıklar";
            columnHeader3.Width = 130;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(312, 173);
            button1.Name = "button1";
            button1.Size = new Size(122, 52);
            button1.TabIndex = 14;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtİcecek
            // 
            txtİcecek.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtİcecek.Location = new Point(194, 78);
            txtİcecek.Name = "txtİcecek";
            txtİcecek.Size = new Size(151, 25);
            txtİcecek.TabIndex = 13;
            // 
            // txtAtistirmalik
            // 
            txtAtistirmalik.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAtistirmalik.Location = new Point(194, 124);
            txtAtistirmalik.Name = "txtAtistirmalik";
            txtAtistirmalik.Size = new Size(151, 25);
            txtAtistirmalik.TabIndex = 12;
            // 
            // txtGida
            // 
            txtGida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtGida.Location = new Point(194, 34);
            txtGida.Name = "txtGida";
            txtGida.Size = new Size(151, 25);
            txtGida.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 128);
            label3.Name = "label3";
            label3.Size = new Size(175, 21);
            label3.TabIndex = 10;
            label3.Text = "Atıştırmalık Tutarları :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 82);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 9;
            label2.Text = "İçecek Tutarları :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 38);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 8;
            label1.Text = "Gıda Tutarları :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView2);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(txtSu);
            groupBox2.Controls.Add(txtİnternet);
            groupBox2.Controls.Add(txtElektrik);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(492, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 452);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Faturalar";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Location = new Point(8, 275);
            listView2.Name = "listView2";
            listView2.Size = new Size(398, 177);
            listView2.TabIndex = 22;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Elektrik";
            columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Su";
            columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İnternet";
            columnHeader6.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(272, 173);
            button2.Name = "button2";
            button2.Size = new Size(122, 52);
            button2.TabIndex = 21;
            button2.Text = "KAYDET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtSu
            // 
            txtSu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSu.Location = new Point(103, 74);
            txtSu.Name = "txtSu";
            txtSu.Size = new Size(151, 25);
            txtSu.TabIndex = 20;
            // 
            // txtİnternet
            // 
            txtİnternet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtİnternet.Location = new Point(103, 120);
            txtİnternet.Name = "txtİnternet";
            txtİnternet.Size = new Size(151, 25);
            txtİnternet.TabIndex = 19;
            // 
            // txtElektrik
            // 
            txtElektrik.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtElektrik.Location = new Point(103, 30);
            txtElektrik.Name = "txtElektrik";
            txtElektrik.Size = new Size(151, 25);
            txtElektrik.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 124);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 17;
            label4.Text = "İnternet :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(60, 78);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 16;
            label5.Text = "Su :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 34);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 15;
            label6.Text = "Elektrik :";
            // 
            // FrmStoklar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(911, 475);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmStoklar";
            Text = "Stoklar & Faturalar";
            Load += FrmStoklar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private TextBox txtİcecek;
        private TextBox txtAtistirmalik;
        private TextBox txtGida;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox txtSu;
        private TextBox txtİnternet;
        private TextBox txtElektrik;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}