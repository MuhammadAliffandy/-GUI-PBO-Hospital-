using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace PBO_ManajemenRumahSakit
{
    public partial class Regis : Form
    {
        private string id = "";
        private int intRow = 0;
        public Regis()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;

            nameTextBox.Text = "";
            tanggalLahirTextBox.Text = "";
            tinggiBadanTextBox.Text = "";
            beratBadanTextBox.Text = "";
            keluhanTextBox.Text = "";
            nomorHPTextBox.Text = "";
            alamatTextBox.Text = "";
            idDokterTextBox.Text = "";
            idKamarTextBox.Text = "";

            if (genderComboBox.Items.Count > 0)
            {
                genderComboBox.SelectedIndex = 0;
            }

            if (rawatComboBox.Items.Count > 0)
            {
                rawatComboBox.SelectedIndex = 0;
            }
        }

        private void execute(string mySQL, string param)
        {
            DB_connect.cmd = new Npgsql.NpgsqlCommand(mySQL, DB_connect.con);
            addParameters();
            DB_connect.PerformCRUD(DB_connect.cmd);
        }

        private void addParameters()
        {
            DB_connect.cmd.Parameters.Clear();
            DB_connect.cmd.Parameters.AddWithValue("nama_pasien", nameTextBox.Text.Trim());
            DB_connect.cmd.Parameters.AddWithValue("jenis_kelamin", genderComboBox.SelectedItem.ToString());
            DB_connect.cmd.Parameters.AddWithValue("tgl_lahir", Convert.ToDateTime(tanggalLahirTextBox.Text.Trim()));
            DB_connect.cmd.Parameters.AddWithValue("tinggi_badan", Convert.ToInt32(tinggiBadanTextBox.Text.Trim()));
            DB_connect.cmd.Parameters.AddWithValue("berat_badan", Convert.ToInt32(beratBadanTextBox.Text.Trim()));
            DB_connect.cmd.Parameters.AddWithValue("keluhan", keluhanTextBox.Text.Trim());
            DB_connect.cmd.Parameters.AddWithValue("no_hp", nomorHPTextBox.Text.Trim());
            DB_connect.cmd.Parameters.AddWithValue("alamat_pasien", alamatTextBox.Text.Trim());
            DB_connect.cmd.Parameters.AddWithValue("dokter_id_dokter", Convert.ToInt32(idDokterTextBox.Text.Trim()));
            DB_connect.cmd.Parameters.AddWithValue("jenis_rawat", rawatComboBox.SelectedItem.ToString());
            DB_connect.cmd.Parameters.AddWithValue("kamar_id_kamar", Convert.ToInt32(idKamarTextBox.Text.Trim()));

            if (!string.IsNullOrEmpty(this.id))
            {
                DB_connect.cmd.Parameters.AddWithValue("id_pasien", this.id);
            }
        }


        private void insertButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text.Trim()) || string.IsNullOrEmpty(tanggalLahirTextBox.Text.Trim()) || string.IsNullOrEmpty(tinggiBadanTextBox.Text.Trim()) || string.IsNullOrEmpty(beratBadanTextBox.Text.Trim()) || string.IsNullOrEmpty(alamatTextBox.Text.Trim()) || string.IsNullOrEmpty(nomorHPTextBox.Text.Trim()))
            {
                MessageBox.Show("Please fill all textbox.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DB_connect.sql = "INSERT INTO pasien(nama_pasien, jenis_kelamin, tgl_lahir, tinggi_badan, berat_badan, keluhan, no_hp, alamat_pasien, dokter_id_dokter, jenis_rawat, kamar_id_kamar) VALUES(@nama_pasien,@jenis_kelamin,@tgl_lahir,@tinggi_badan,@berat_badan,@keluhan,@no_hp,@alamat_pasien,@dokter_id_dokter,@jenis_rawat,@kamar_id_kamar)";

            execute(DB_connect.sql, "insert");

            MessageBox.Show("The record has been saved.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            resetMe();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            this.Hide();
            obj1.ShowDialog();
        }
    }
}
