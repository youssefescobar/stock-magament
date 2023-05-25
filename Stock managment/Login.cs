using System.Data;
using System.Data.SqlClient;

namespace Stock_managment
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdminTable;Integrated Security=True");


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            try
            {
                string querry = "SELECT * FROM LoginCreds_admin WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(querry, connect);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                if (tbl.Rows.Count > 0)
                {
                    user = textBox1.Text;
                    pass = textBox2.Text;
                  
               
                    textBox1.Clear();
                    textBox2.Clear();
                    this.Hide();

                }

            }
            catch
            {
                MessageBox.Show("error invalid details, try again");


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ex_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}