 using Npgsql;
namespace WinFormsApp3

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public NpgsqlConnection con;
        public void MyLoad()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            con = new NpgsqlConnection("Server=localhost; Port=5432; UserID=postgres; Password=postpass; Database=NormBase");
            con.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProduct fp = new FormProduct(con);
            fp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClient fp1 = new FormClient(con);
            fp1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFutura fp2 = new FormFutura(con);
            fp2.ShowDialog();
        }
    }
}
