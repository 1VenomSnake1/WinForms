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
    public partial class FormClient : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public FormClient(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }
        public void Update()
        {
            String sql = "Select*from Client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Адрес";
            dataGridView1.Columns[3].HeaderText = "Номер Телефона";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            Update();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientForm f = new AddClientForm(con, -1);
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
                NpgsqlCommand command = new NpgsqlCommand("Delete from Client where ID=:id", con);
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
            string adress = (string)dataGridView1.CurrentRow.Cells["adress"].Value;
            string phone = (string)dataGridView1.CurrentRow.Cells["phone"].Value;
            AddClientForm f = new AddClientForm(con, id, name, adress, phone);
            f.ShowDialog();
            Update();
        }

        private void FormClient_Load_1(object sender, EventArgs e)
        {
            Update();
        }
    }
}
