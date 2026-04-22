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
    public partial class AddFuturaForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public AddFuturaForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        private void Update()
        {
            String sql = "Select*from client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            comboBoxClientName.DataSource = dt;
            comboBoxClientName.DisplayMember = "name";
            comboBoxClientName.ValueMember = "ID";
        }

        private void AddFuturaForm_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
           // try
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Futura (idclient,data_,totalsum)" +
                    "VALUES(:idclient,:data_,0)", con);
                DateTime dt = this.dateTimePicker1.Value.Date;
                command.Parameters.AddWithValue("idclient", comboBoxClientName.SelectedValue);
                command.Parameters.AddWithValue("data_", dt);
                command.ExecuteNonQuery();
                Close();
            }
           // catch { }
        }
    }
}
