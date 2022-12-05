using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PBO_ManajemenRumahSakit
{
    public partial class Dokter : Form
    {
        private string id = "";
        private int intRow = 0;
        public Dokter()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;

            nameTextBox.Text = "";
            tanggalLahirTextBox.Text = "";
            alamatTextBox.Text = "";
            nomorHPTextBox.Text = "";
            idSpesialisTextBox.Text = "";

            if (genderComboBox.Items.Count > 0)
            {
                genderComboBox.SelectedIndex = 0;
            }
            updateButton.Text = "Update ()";
            deleteButton.Text = "Delete ()";

            keywordTextBox.Clear();

            if (keywordTextBox.CanSelect)
            {
                keywordTextBox.Select();
            }
        }

        private void Dokter_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string keyword)
        {
            DB_connect.sql = "SELECT id_dokter, nama_dokter, jenis_kelamin, tgl_lahir, no_hp, alamat_dokter, spesialisasi_id_spesialisasi FROM dokter " +
                       "WHERE CONCAT(CAST(id_dokter as varchar), ' ', nama_dokter) LIKE @keyword::varchar " +
                       "OR TRIM(jenis_kelamin) LIKE @keyword::varchar ORDER BY id_dokter ASC";

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

            dgv1.Columns[0].HeaderText = "ID Dokter";
            dgv1.Columns[1].HeaderText = "Nama Dokter";
            dgv1.Columns[2].HeaderText = "Jenis Kelamin";
            dgv1.Columns[3].HeaderText = "Tanggal Lahir";
            dgv1.Columns[4].HeaderText = "Nomor HP";
            dgv1.Columns[5].HeaderText = "Alamat";
            dgv1.Columns[6].HeaderText = "ID Spesialisasi";

            dgv1.Columns[0].Width = 85;
            dgv1.Columns[1].Width = 220;
            dgv1.Columns[2].Width = 170;
            dgv1.Columns[3].Width = 220;
            dgv1.Columns[4].Width = 170;
            dgv1.Columns[5].Width = 170;
            dgv1.Columns[6].Width = 85;
        }

        private void execute(string mySQL, string param)
        {
            DB_connect.cmd = new Npgsql.NpgsqlCommand(mySQL, DB_connect.con);
            addParameters(param);
            DB_connect.PerformCRUD(DB_connect.cmd);
        }

        private void addParameters(string str)
        {
            DB_connect.cmd.Parameters.Clear();
            DB_connect.cmd.Parameters.AddWithValue("nama_dokter", nameTextBox.Text.Trim());
            DB_connect.cmd.Parameters.AddWithValue("jenis_kelamin", genderComboBox.SelectedItem.ToString());
            DB_connect.cmd.Parameters.AddWithValue("tgl_lahir", Convert.ToDateTime(tanggalLahirTextBox.Text.Trim()));
            DB_connect.cmd.Parameters.AddWithValue("no_hp", nomorHPTextBox.Text.Trim());
            DB_connect.cmd.Parameters.AddWithValue("alamat_dokter", alamatTextBox.Text.Trim());
            DB_connect.cmd.Parameters.AddWithValue("spesialisasi_id_spesialisasi", Convert.ToInt32(idSpesialisTextBox.Text.Trim()));

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                DB_connect.cmd.Parameters.AddWithValue("id_dokter", this.id);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text.Trim()) || string.IsNullOrEmpty(tanggalLahirTextBox.Text.Trim()) || string.IsNullOrEmpty(nomorHPTextBox.Text.Trim()) || string.IsNullOrEmpty(alamatTextBox.Text.Trim()) || string.IsNullOrEmpty(idSpesialisTextBox.Text.Trim()))
            {
                MessageBox.Show("Please fill all data.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DB_connect.sql = "INSERT INTO dokter(nama_dokter, jenis_kelamin, tgl_lahir, no_hp, alamat_dokter, spesialisasi_id_spesialisasi) VALUES(@nama_dokter,@jenis_kelamin,@tgl_lahir,@no_hp,@alamat_dokter,@spesialisasi_id_spesialisasi)";

            execute(DB_connect.sql, "insert");

            MessageBox.Show("The record has been saved.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);


            loadData("");

            resetMe();
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
                nomorHPTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                alamatTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);
                idSpesialisTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[6].Value);
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

            if (string.IsNullOrEmpty(nameTextBox.Text.Trim()) || string.IsNullOrEmpty(tanggalLahirTextBox.Text.Trim()) || string.IsNullOrEmpty(nomorHPTextBox.Text.Trim()) || string.IsNullOrEmpty(alamatTextBox.Text.Trim()) || string.IsNullOrEmpty(idSpesialisTextBox.Text.Trim()))
            {
                MessageBox.Show("Please fill all data.", "Insert Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DB_connect.sql = "UPDATE dokter SET nama_dokter = @nama_dokter, jenis_kelamin = @jenis_kelamin, tgl_lahir = @tgl_lahir, no_hp = @no_hp, alamat_dokter = @alamat_dokter, spesialisasi_id_spesialisasi = @spesialisasi_id_spesialisasi WHERE id_dokter = @id_dokter::integer";

            execute(DB_connect.sql, "Update");

            MessageBox.Show("The record has been updated.", "Update Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");

            resetMe();
        }

        private void deleteButton_Click(object sender, EventArgs e)
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

                DB_connect.sql = "DELETE FROM dokter WHERE id_dokter = @id_dokter::integer";

                execute(DB_connect.sql, "Update");

                MessageBox.Show("The record has been deleted.", "Delete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");

                resetMe();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            this.Hide();
            obj1.ShowDialog();
        }
    }
}
