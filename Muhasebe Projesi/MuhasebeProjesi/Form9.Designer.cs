namespace MuhasebeProjesi
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.adi = new System.Windows.Forms.TextBox();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.ibanno = new System.Windows.Forms.TextBox();
            this.bankaadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aktarilan = new System.Windows.Forms.ComboBox();
            this.firmaisim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.miktar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adi
            // 
            this.adi.Location = new System.Drawing.Point(106, 68);
            this.adi.MaxLength = 11;
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(100, 20);
            this.adi.TabIndex = 0;
            this.adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adi_KeyPress);
            // 
            // soyadi
            // 
            this.soyadi.Location = new System.Drawing.Point(294, 66);
            this.soyadi.MaxLength = 11;
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(100, 20);
            this.soyadi.TabIndex = 1;
            this.soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyadi_KeyPress);
            // 
            // ibanno
            // 
            this.ibanno.Location = new System.Drawing.Point(106, 117);
            this.ibanno.MaxLength = 11;
            this.ibanno.Name = "ibanno";
            this.ibanno.Size = new System.Drawing.Size(100, 20);
            this.ibanno.TabIndex = 2;
            this.ibanno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ibanno_KeyPress);
            // 
            // bankaadi
            // 
            this.bankaadi.Location = new System.Drawing.Point(294, 117);
            this.bankaadi.MaxLength = 15;
            this.bankaadi.Name = "bankaadi";
            this.bankaadi.Size = new System.Drawing.Size(100, 20);
            this.bankaadi.TabIndex = 3;
            this.bankaadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bankaadi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "BANKA İŞLEMLERİ";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "if_06_61470.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(277, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 54);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "if_06_61470.png");
            this.ımageList1.Images.SetKeyName(1, "if_Money_Bag_10999.png");
            this.ımageList1.Images.SetKeyName(2, "house.png");
            this.ımageList1.Images.SetKeyName(3, "15107-illustration-of-a-red-close-button-ts.png");
            this.ımageList1.Images.SetKeyName(4, "to-do-list_checked3.png");
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "if_Money_Bag_10999.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(351, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 54);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(240, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "IBAN NO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(218, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Banka Adı :";
            // 
            // aktarilan
            // 
            this.aktarilan.FormattingEnabled = true;
            this.aktarilan.Location = new System.Drawing.Point(106, 167);
            this.aktarilan.Name = "aktarilan";
            this.aktarilan.Size = new System.Drawing.Size(100, 21);
            this.aktarilan.TabIndex = 11;
            this.aktarilan.Text = "Seçiniz";
            this.aktarilan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.aktarilan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aktarilan_KeyPress);
            // 
            // firmaisim
            // 
            this.firmaisim.Location = new System.Drawing.Point(294, 167);
            this.firmaisim.MaxLength = 15;
            this.firmaisim.Name = "firmaisim";
            this.firmaisim.Size = new System.Drawing.Size(100, 20);
            this.firmaisim.TabIndex = 12;
            this.firmaisim.Visible = false;
            this.firmaisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firmaisim_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Aktarılan Yer :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(216, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Firma İsmi :";
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(190, 224);
            this.miktar.MaxLength = 7;
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(100, 20);
            this.miktar.TabIndex = 15;
            this.miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miktar_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(67, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Aktarılacak Miktar :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 152);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(277, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Para Aktar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(362, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Para Çek";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "house.png";
            this.button3.ImageList = this.ımageList2;
            this.button3.Location = new System.Drawing.Point(1, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 47);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "house.png");
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageKey = "15107-illustration-of-a-red-close-button-ts.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(194, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 54);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(202, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "İşlem Sil";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(437, 513);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firmaisim);
            this.Controls.Add(this.aktarilan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bankaadi);
            this.Controls.Add(this.ibanno);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.adi);
            this.Name = "Form9";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka İşlemleri";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox ibanno;
        private System.Windows.Forms.TextBox bankaadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox aktarilan;
        private System.Windows.Forms.TextBox firmaisim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList ımageList2;
        public System.Windows.Forms.TextBox miktar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
    }
}