
namespace PBO_ManajemenRumahSakit
{
    partial class Pasien
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
            this.label1 = new System.Windows.Forms.Label();
            this.rawatComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tanggalLahirTextBox = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.idKamarTextBox = new System.Windows.Forms.TextBox();
            this.idDokterTextBox = new System.Windows.Forms.TextBox();
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.nomorHPTextBox = new System.Windows.Forms.TextBox();
            this.keluhanTextBox = new System.Windows.Forms.TextBox();
            this.beratBadanTextBox = new System.Windows.Forms.TextBox();
            this.tinggiBadanTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pasien";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rawatComboBox
            // 
            this.rawatComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.rawatComboBox.FormattingEnabled = true;
            this.rawatComboBox.Items.AddRange(new object[] {
            "Jalan",
            "Inap"});
            this.rawatComboBox.Location = new System.Drawing.Point(683, 271);
            this.rawatComboBox.Name = "rawatComboBox";
            this.rawatComboBox.Size = new System.Drawing.Size(245, 31);
            this.rawatComboBox.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(504, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 23);
            this.label13.TabIndex = 70;
            this.label13.Text = "Jenis Rawat";
            // 
            // tanggalLahirTextBox
            // 
            this.tanggalLahirTextBox.CustomFormat = "yyyy-MM-dd";
            this.tanggalLahirTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tanggalLahirTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tanggalLahirTextBox.Location = new System.Drawing.Point(222, 224);
            this.tanggalLahirTextBox.Name = "tanggalLahirTextBox";
            this.tanggalLahirTextBox.Size = new System.Drawing.Size(244, 30);
            this.tanggalLahirTextBox.TabIndex = 69;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.genderComboBox.Location = new System.Drawing.Point(222, 169);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(245, 31);
            this.genderComboBox.TabIndex = 68;
            // 
            // idKamarTextBox
            // 
            this.idKamarTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.idKamarTextBox.Location = new System.Drawing.Point(683, 324);
            this.idKamarTextBox.Name = "idKamarTextBox";
            this.idKamarTextBox.Size = new System.Drawing.Size(248, 30);
            this.idKamarTextBox.TabIndex = 67;
            // 
            // idDokterTextBox
            // 
            this.idDokterTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.idDokterTextBox.Location = new System.Drawing.Point(683, 221);
            this.idDokterTextBox.Name = "idDokterTextBox";
            this.idDokterTextBox.Size = new System.Drawing.Size(248, 30);
            this.idDokterTextBox.TabIndex = 66;
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.alamatTextBox.Location = new System.Drawing.Point(683, 169);
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(248, 30);
            this.alamatTextBox.TabIndex = 65;
            // 
            // nomorHPTextBox
            // 
            this.nomorHPTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.nomorHPTextBox.Location = new System.Drawing.Point(683, 115);
            this.nomorHPTextBox.Name = "nomorHPTextBox";
            this.nomorHPTextBox.Size = new System.Drawing.Size(248, 30);
            this.nomorHPTextBox.TabIndex = 64;
            // 
            // keluhanTextBox
            // 
            this.keluhanTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.keluhanTextBox.Location = new System.Drawing.Point(222, 384);
            this.keluhanTextBox.Name = "keluhanTextBox";
            this.keluhanTextBox.Size = new System.Drawing.Size(248, 30);
            this.keluhanTextBox.TabIndex = 63;
            // 
            // beratBadanTextBox
            // 
            this.beratBadanTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.beratBadanTextBox.Location = new System.Drawing.Point(222, 329);
            this.beratBadanTextBox.Name = "beratBadanTextBox";
            this.beratBadanTextBox.Size = new System.Drawing.Size(248, 30);
            this.beratBadanTextBox.TabIndex = 62;
            // 
            // tinggiBadanTextBox
            // 
            this.tinggiBadanTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tinggiBadanTextBox.Location = new System.Drawing.Point(222, 274);
            this.tinggiBadanTextBox.Name = "tinggiBadanTextBox";
            this.tinggiBadanTextBox.Size = new System.Drawing.Size(248, 30);
            this.tinggiBadanTextBox.TabIndex = 61;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.nameTextBox.Location = new System.Drawing.Point(222, 115);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(248, 30);
            this.nameTextBox.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(508, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 59;
            this.label12.Text = "ID Kamar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(506, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 58;
            this.label10.Text = "ID Dokter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(506, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 57;
            this.label9.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 56;
            this.label8.Text = "Keluhan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(506, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = "Nomor HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "Berat Badan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tinggi Badan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nama Lengkap";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.keywordTextBox.Location = new System.Drawing.Point(49, 438);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(248, 30);
            this.keywordTextBox.TabIndex = 72;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(313, 437);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(159, 34);
            this.searchButton.TabIndex = 73;
            this.searchButton.Text = "Cari";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(478, 437);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(77, 34);
            this.updateButton.TabIndex = 74;
            this.updateButton.Text = "Ubah ()";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(561, 437);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(77, 34);
            this.deleteButton.TabIndex = 75;
            this.deleteButton.Text = "Hapus ()";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 483);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(888, 216);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(45, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 23);
            this.label11.TabIndex = 77;
            this.label11.Text = "Kembali";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Pasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(985, 711);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.rawatComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tanggalLahirTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.idKamarTextBox);
            this.Controls.Add(this.idDokterTextBox);
            this.Controls.Add(this.alamatTextBox);
            this.Controls.Add(this.nomorHPTextBox);
            this.Controls.Add(this.keluhanTextBox);
            this.Controls.Add(this.beratBadanTextBox);
            this.Controls.Add(this.tinggiBadanTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label12);
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
            this.MaximizeBox = false;
            this.Name = "Pasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasien";
            this.Load += new System.EventHandler(this.Pasien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rawatComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker tanggalLahirTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox idKamarTextBox;
        private System.Windows.Forms.TextBox idDokterTextBox;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.TextBox nomorHPTextBox;
        private System.Windows.Forms.TextBox keluhanTextBox;
        private System.Windows.Forms.TextBox beratBadanTextBox;
        private System.Windows.Forms.TextBox tinggiBadanTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
    }
}