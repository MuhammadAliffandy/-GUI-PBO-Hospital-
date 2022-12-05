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
    public partial class Kamar : Form
    {
        private string id = "";
        private int intRow = 0;
        public Kamar()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;

            keywordTextBox.Clear();

            if (keywordTextBox.CanSelect)
            {
                keywordTextBox.Select();
            }
        }

        private void Kamar_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string keyword)
        {
            DB_connect.sql = "SELECT id_kamar, nama_kamar FROM kamar " +
                       "WHERE CONCAT(CAST(id_kamar as varchar), ' ', nama_kamar) LIKE @keyword::varchar " +
                       "ORDER BY id_kamar ASC";

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

            dgv1.Columns[0].HeaderText = "ID Kamar";
            dgv1.Columns[1].HeaderText = "Nama Kamar";

            dgv1.Columns[0].Width = 85;
            dgv1.Columns[1].Width = 220;
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

        private void label2_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            this.Hide();
            obj1.ShowDialog();
        }
    }
}
