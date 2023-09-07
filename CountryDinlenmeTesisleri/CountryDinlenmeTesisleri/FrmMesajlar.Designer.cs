namespace CountryTatilKöyü
{
    partial class FrmMesajlar
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
            label1 = new Label();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            rchtxtMesaj = new RichTextBox();
            btnKaydet = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.ForestGreen;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Mesaj :";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdSoyad.Location = new Point(107, 14);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(437, 25);
            txtAdSoyad.TabIndex = 2;
            // 
            // rchtxtMesaj
            // 
            rchtxtMesaj.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rchtxtMesaj.Location = new Point(81, 57);
            rchtxtMesaj.Name = "rchtxtMesaj";
            rchtxtMesaj.Size = new Size(510, 215);
            rchtxtMesaj.TabIndex = 3;
            rchtxtMesaj.Text = "";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Silver;
            btnKaydet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKaydet.Location = new Point(275, 278);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(288, 35);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(9, 328);
            listView1.Name = "listView1";
            listView1.Size = new Size(582, 188);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad Soyad";
            columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mesaj";
            columnHeader3.Width = 300;
            // 
            // FrmMesajlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(603, 519);
            Controls.Add(listView1);
            Controls.Add(btnKaydet);
            Controls.Add(rchtxtMesaj);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMesajlar";
            Text = "FrmMesajlar";
            Load += FrmMesajlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAdSoyad;
        private RichTextBox rchtxtMesaj;
        private Button btnKaydet;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}