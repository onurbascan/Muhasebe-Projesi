namespace MuhasebeProjesi
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.sektor = new System.Windows.Forms.ComboBox();
            this.adet = new System.Windows.Forms.TextBox();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.acikadres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kdvtext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hamfiyat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toplamfiyat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kdvfiyat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tarihtext = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sektor
            // 
            this.sektor.FormattingEnabled = true;
            this.sektor.Location = new System.Drawing.Point(148, 24);
            this.sektor.Name = "sektor";
            this.sektor.Size = new System.Drawing.Size(121, 21);
            this.sektor.TabIndex = 5;
            this.sektor.Text = "Seçiniz";
            this.sektor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.sektor.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.sektor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sektor_KeyPress);
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(148, 134);
            this.adet.MaxLength = 2;
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(121, 20);
            this.adet.TabIndex = 6;
            this.adet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.adet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.adet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Location = new System.Drawing.Point(148, 97);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(121, 21);
            this.kategori.TabIndex = 7;
            this.kategori.Text = "Seçiniz";
            this.kategori.SelectedIndexChanged += new System.EventHandler(this.kategori_SelectedIndexChanged);
            this.kategori.SelectionChangeCommitted += new System.EventHandler(this.kategori_SelectionChangeCommitted);
            this.kategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kategori_KeyPress);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(148, 177);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(200, 20);
            this.tarih.TabIndex = 8;
            // 
            // acikadres
            // 
            this.acikadres.Location = new System.Drawing.Point(148, 217);
            this.acikadres.MaxLength = 40;
            this.acikadres.Multiline = true;
            this.acikadres.Name = "acikadres";
            this.acikadres.Size = new System.Drawing.Size(233, 66);
            this.acikadres.TabIndex = 10;
            this.acikadres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acikadres_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sektör :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(87, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tarih :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Açık Adres :";
            // 
            // kdvtext
            // 
            this.kdvtext.Enabled = false;
            this.kdvtext.Location = new System.Drawing.Point(148, 57);
            this.kdvtext.Name = "kdvtext";
            this.kdvtext.Size = new System.Drawing.Size(121, 20);
            this.kdvtext.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(91, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "KDV :";
            // 
            // hamfiyat
            // 
            this.hamfiyat.AutoSize = true;
            this.hamfiyat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hamfiyat.Location = new System.Drawing.Point(445, 27);
            this.hamfiyat.Name = "hamfiyat";
            this.hamfiyat.Size = new System.Drawing.Size(71, 15);
            this.hamfiyat.TabIndex = 19;
            this.hamfiyat.Text = "HAM FİYAT :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(590, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "-";
            // 
            // toplamfiyat
            // 
            this.toplamfiyat.AutoSize = true;
            this.toplamfiyat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamfiyat.Location = new System.Drawing.Point(445, 117);
            this.toplamfiyat.Name = "toplamfiyat";
            this.toplamfiyat.Size = new System.Drawing.Size(161, 15);
            this.toplamfiyat.TabIndex = 24;
            this.toplamfiyat.Text = "TOPLAM ÖDENECEK TUTAR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(534, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 147);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "onebit_34.png");
            this.ımageList1.Images.SetKeyName(1, "15107-illustration-of-a-red-close-button-ts.png");
            this.ımageList1.Images.SetKeyName(2, "satin alma.png");
            this.ımageList1.Images.SetKeyName(3, "house.png");
            this.ımageList1.Images.SetKeyName(4, "iconfinder_22_Done_Circle_Complete_Downloaded_Added_2142698.png");
            // 
            // kdvfiyat
            // 
            this.kdvfiyat.AutoSize = true;
            this.kdvfiyat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvfiyat.Location = new System.Drawing.Point(445, 65);
            this.kdvfiyat.Name = "kdvfiyat";
            this.kdvfiyat.Size = new System.Drawing.Size(72, 15);
            this.kdvfiyat.TabIndex = 29;
            this.kdvfiyat.Text = "KDV FİYATI :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(590, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(552, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Satın Al";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(635, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "İptal Et";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(473, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Hesapla";
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
            this.button4.ImageKey = "house.png";
            this.button4.ImageList = this.ımageList2;
            this.button4.Location = new System.Drawing.Point(1, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 41);
            this.button4.TabIndex = 35;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "satin alma.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(458, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "15107-illustration-of-a-red-close-button-ts.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(618, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "onebit_34.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(540, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarihtext
            // 
            this.tarihtext.Location = new System.Drawing.Point(354, 177);
            this.tarihtext.Name = "tarihtext";
            this.tarihtext.Size = new System.Drawing.Size(100, 20);
            this.tarihtext.TabIndex = 36;
            this.tarihtext.Visible = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageKey = "iconfinder_22_Done_Circle_Complete_Downloaded_Added_2142698.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(694, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 46);
            this.button5.TabIndex = 37;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(703, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tamamla";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(837, 468);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tarihtext);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kdvfiyat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.toplamfiyat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.hamfiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acikadres);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.sektor);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satın Alma Menüsü";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sektor;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox acikadres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kdvtext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hamfiyat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label toplamfiyat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label kdvfiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.TextBox tarihtext;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
    }
}