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

namespace WinFormsApp3
{
    public partial class FormProduct : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public FormProduct(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }
        public void Update()
        {
            String sql = "Select*from Product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[2].HeaderText = "Ед.измерения";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm f = new AddProductForm(con, -1);
            f.ShowDialog();
            Update();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Хотите удалить?",
                 "Подтверждение",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                NpgsqlCommand command = new NpgsqlCommand("Delete from Product where ID=:id", con);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                Update();
            }
            else if (result == DialogResult.No) { }

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            string name = (string)dataGridView1.CurrentRow.Cells["name"].Value;
            string ed = (string)dataGridView1.CurrentRow.Cells["ed"].Value;
            AddProductForm f = new AddProductForm(con, id, name, ed);
            f.ShowDialog();
            Update();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
