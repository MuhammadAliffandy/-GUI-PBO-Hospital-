using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_ManajemenRumahSakit
{
    public partial class Pasien : Form
    {
        private string id = "";
        private int intRow = 0;
        public Pasien()
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list.", "Delete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Do you want to permanently delete the selected record?", "Delete Data",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                DB_connect.sql = "DELETE FROM pasien WHERE id_pasien = @id_pasien::integer";

                execute(DB_connect.sql, "Update");

                MessageBox.Show("The record has been deleted.", "Delete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");

                resetMe();
            }
        }

        private void Pasien_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string keyword)
        {
            DB_connect.sql = "SELECT id_pasien, nama_pasien, jenis_kelamin, tgl_lahir, tinggi_badan, berat_badan, keluhan,no_hp, alamat_pasien, dokter_id_dokter, jenis_rawat, kamar_id_kamar FROM pasien " +
                       "WHERE CONCAT(CAST(id_pasien as varchar), ' ', nama_pasien) LIKE @keyword::varchar " +
                       "OR TRIM(jenis_kelamin) LIKE @keyword::varchar ORDER BY id_pasien ASC";

            string strKeyword = string.Format("%{0}%", keyword);

            DB_connect.cmd = new NpgsqlCommand(DB_connect.sql, DB_connect.con);
            DB_connect.cmd.Parameters.Clear();
            DB_connect.cmd.Parameters.AddWithValue("keyword", strKeyword);

            DataTable dt = DB_connect.PerformCRUD(DB_connect.cmd);

            DataGridView dgv1 = dataGridView1;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "ID Pasien";
            dgv1.Columns[1].HeaderText = "Nama Pasien";
            dgv1.Columns[2].HeaderText = "Jenis Kelamin";
            dgv1.Columns[3].HeaderText = "Tanggal Lahir";
            dgv1.Columns[4].HeaderText = "Tinggi Badan";
            dgv1.Columns[5].HeaderText = "Berat Badan";
            dgv1.Columns[6].HeaderText = "Keluhan";
            dgv1.Columns[7].HeaderText = "Nomor HP";
            dgv1.Columns[8].HeaderText = "Alamat";
            dgv1.Columns[9].HeaderText = "ID Dokter";
            dgv1.Columns[10].HeaderText = "Jenis Rawat";
            dgv1.Columns[11].HeaderText = "ID Kamar";

            dgv1.Columns[0].Width = 85;
            dgv1.Columns[1].Width = 220;
            dgv1.Columns[2].Width = 170;
            dgv1.Columns[3].Width = 170;
            dgv1.Columns[4].Width = 85;
            dgv1.Columns[5].Width = 85;
            dgv1.Columns[6].Width = 220;
            dgv1.Columns[7].Width = 170;
            dgv1.Columns[8].Width = 220;
            dgv1.Columns[9].Width = 85;
            dgv1.Columns[10].Width = 170;
            dgv1.Columns[11].Width = 85;
        }

        private void execute(string mySQL, string param)
        {
            DB_connect.cmd = new Npgsql.NpgsqlCommand(mySQL, DB_connect.con);
            addParameters(param);
            DB_connect.PerformCRUD(DB_connect.cmd);
        }

        //IKI DORONG

        private void addParameters(string str)
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

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                DB_connect.cmd.Parameters.AddWithValue("id_pasien", this.id);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView1;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                updateButton.Text = "Update (" + this.id + ")";
                deleteButton.Text = "Delete (" + this.id + ")";

                nameTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                genderComboBox.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                tanggalLahirTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                tinggiBadanTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                beratBadanTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);
                keluhanTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[6].Value);
                nomorHPTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[7].Value);
                alamatTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[8].Value);
                idDokterTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[9].Value);
                rawatComboBox.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[10].Value);
                idKamarTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[11].Value);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keywordTextBox.Text.Trim()))
            {
                loadData("");
            }
            else
            {
                loadData(keywordTextBox.Text.Trim());
            }

            resetMe();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list.", "Update Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(nameTextBox.Text.Trim()) || string.IsNullOrEmpty(tanggalLahirTextBox.Text.Trim()) || string.IsNullOrEmpty(tinggiBadanTextBox.Text.Trim()) || string.IsNullOrEmpty(beratBadanTextBox.Text.Trim()) || string.IsNullOrEmpty(keluhanTextBox.Text.Trim()) || string.IsNullOrEmpty(nomorHPTextBox.Text.Trim()) || string.IsNullOrEmpty(alamatTextBox.Text.Trim()) || string.IsNullOrEmpty(idDokterTextBox.Text.Trim()) || string.IsNullOrEmpty(rawatComboBox.Text.Trim()) || string.IsNullOrEmpty(idKamarTextBox.Text.Trim()))
            {
                MessageBox.Show("Please fill all data.", "Insert Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DB_connect.sql = "UPDATE pasien SET nama_pasien = @nama_pasien, jenis_kelamin = @jenis_kelamin, tgl_lahir = @tgl_lahir, tinggi_badan = @tinggi_badan, berat_badan = @berat_badan, keluhan = @keluhan, no_hp = @no_hp, alamat_pasien = @alamat_pasien, dokter_id_dokter = @dokter_id_dokter, jenis_rawat = @jenis_rawat, kamar_id_kamar = @kamar_id_kamar WHERE id_pasien = @id_pasien::integer";

            execute(DB_connect.sql, "Update");

            MessageBox.Show("The record has been updated.", "Update Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");

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

