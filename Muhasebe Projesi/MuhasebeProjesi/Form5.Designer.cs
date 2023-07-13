namespace MuhasebeProjesi
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.islemtarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.vadetarih = new System.Windows.Forms.DateTimePicker();
            this.tutar = new System.Windows.Forms.TextBox();
            this.ceksenetno = new System.Windows.Forms.TextBox();
            this.ceksenettur = new System.Windows.Forms.ComboBox();
            this.bankaadi = new System.Windows.Forms.TextBox();
            this.bankasubesi = new System.Windows.Forms.TextBox();
            this.hesapno = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.islemtext = new System.Windows.Forms.TextBox();
            this.vadetext = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // islemtarih
            // 
            this.islemtarih.CustomFormat = "dd-MM-yyyy";
            this.islemtarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.islemtarih.Location = new System.Drawing.Point(99, 70);
            this.islemtarih.Name = "islemtarih";
            this.islemtarih.Size = new System.Drawing.Size(130, 20);
            this.islemtarih.TabIndex = 0;
            this.islemtarih.ValueChanged += new System.EventHandler(this.islemtarih_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "house.png";
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 45);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "aevita-wipe-and-delete.png");
            this.ımageList2.Images.SetKeyName(1, "house.png");
            // 
            // vadetarih
            // 
            this.vadetarih.CustomFormat = "dd-MM-yyyy";
            this.vadetarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vadetarih.Location = new System.Drawing.Point(99, 118);
            this.vadetarih.Name = "vadetarih";
            this.vadetarih.Size = new System.Drawing.Size(130, 20);
            this.vadetarih.TabIndex = 2;
            this.vadetarih.ValueChanged += new System.EventHandler(this.vadetarih_ValueChanged);
            // 
            // tutar
            // 
            this.tutar.Location = new System.Drawing.Point(99, 156);
            this.tutar.MaxLength = 7;
            this.tutar.Multiline = true;
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(130, 20);
            this.tutar.TabIndex = 3;
            this.tutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tutar_KeyPress);
            // 
            // ceksenetno
            // 
            this.ceksenetno.Location = new System.Drawing.Point(99, 196);
            this.ceksenetno.MaxLength = 11;
            this.ceksenetno.Multiline = true;
            this.ceksenetno.Name = "ceksenetno";
            this.ceksenetno.Size = new System.Drawing.Size(130, 20);
            this.ceksenetno.TabIndex = 4;
            this.ceksenetno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ceksenetno_KeyPress);
            // 
            // ceksenettur
            // 
            this.ceksenettur.FormattingEnabled = true;
            this.ceksenettur.Location = new System.Drawing.Point(99, 239);
            this.ceksenettur.Name = "ceksenettur";
            this.ceksenettur.Size = new System.Drawing.Size(130, 21);
            this.ceksenettur.TabIndex = 5;
            // 
            // bankaadi
            // 
            this.bankaadi.Location = new System.Drawing.Point(319, 70);
            this.bankaadi.MaxLength = 15;
            this.bankaadi.Name = "bankaadi";
            this.bankaadi.Size = new System.Drawing.Size(130, 20);
            this.bankaadi.TabIndex = 7;
            this.bankaadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bankaadi_KeyPress);
            // 
            // bankasubesi
            // 
            this.bankasubesi.Location = new System.Drawing.Point(319, 115);
            this.bankasubesi.MaxLength = 15;
            this.bankasubesi.Name = "bankasubesi";
            this.bankasubesi.Size = new System.Drawing.Size(130, 20);
            this.bankasubesi.TabIndex = 8;
            this.bankasubesi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bankasubesi_KeyPress);
            // 
            // hesapno
            // 
            this.hesapno.Location = new System.Drawing.Point(319, 156);
            this.hesapno.MaxLength = 11;
            this.hesapno.Name = "hesapno";
            this.hesapno.Size = new System.Drawing.Size(130, 20);
            this.hesapno.TabIndex = 9;
            this.hesapno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hesapno_KeyPress);
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(315, 196);
            this.aciklama.MaxLength = 49;
            this.aciklama.Multiline = true;
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(200, 64);
            this.aciklama.TabIndex = 10;
            this.aciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aciklama_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 187);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "onebit_34.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(315, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 47);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.png");
            this.ımageList1.Images.SetKeyName(1, "onebit_34.png");
            this.ımageList1.Images.SetKeyName(2, "gtk-refresh.png");
            this.ımageList1.Images.SetKeyName(3, "15107-illustration-of-a-red-close-button-ts.png");
            this.ımageList1.Images.SetKeyName(4, "to-do-list_checked3.png");
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "aevita-wipe-and-delete.png";
            this.button3.ImageList = this.ımageList2;
            this.button3.Location = new System.Drawing.Point(381, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 47);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageKey = "gtk-refresh.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(447, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 47);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "İşlem Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vade Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tutar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Çek/Senet NO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Çek Senet Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Banka Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Banka Şubesi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Hesap No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Açıklama :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(326, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "EKLE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(401, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "SİL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(455, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "DÜZENLE";
            // 
            // islemtext
            // 
            this.islemtext.Location = new System.Drawing.Point(6, 328);
            this.islemtext.Name = "islemtext";
            this.islemtext.Size = new System.Drawing.Size(100, 20);
            this.islemtext.TabIndex = 27;
            this.islemtext.Visible = false;
            // 
            // vadetext
            // 
            this.vadetext.Location = new System.Drawing.Point(112, 328);
            this.vadetext.Name = "vadetext";
            this.vadetext.Size = new System.Drawing.Size(100, 20);
            this.vadetext.TabIndex = 28;
            this.vadetext.Visible = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageKey = "to-do-list_checked3.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(249, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 47);
            this.button5.TabIndex = 29;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(248, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "RAPOR AL";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(525, 549);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.vadetext);
            this.Controls.Add(this.islemtext);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.hesapno);
            this.Controls.Add(this.bankasubesi);
            this.Controls.Add(this.bankaadi);
            this.Controls.Add(this.ceksenettur);
            this.Controls.Add(this.ceksenetno);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.vadetarih);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.islemtarih);
            this.Name = "Form5";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÇEK SENET İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker islemtarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker vadetarih;
        private System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.TextBox ceksenetno;
        private System.Windows.Forms.ComboBox ceksenettur;
        private System.Windows.Forms.TextBox bankaadi;
        private System.Windows.Forms.TextBox bankasubesi;
        private System.Windows.Forms.TextBox hesapno;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.TextBox islemtext;
        private System.Windows.Forms.TextBox vadetext;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
    }
}