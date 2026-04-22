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
    public partial class FormFutura : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public FormFutura(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();

        }
        private void Update1()
        {
            String sql = "Select futura.ID,futura.data_,client.name FROM futura JOIN client ON futura.idclient=client.ID";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
        private void Update2()
        {
            String sql = "Select futurainfo.ID,futurainfo.quantity,futurainfo.price FROM futurainfo JOIN product ON futurainfo.idproduct=product.ID";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFutura_Load(object sender, EventArgs e)
        {
            Update1();
            Update2();
        }

        private void наклоднаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFuturaForm f = new AddFuturaForm(con);
            f.ShowDialog();
            Update();
        }
    }
}
