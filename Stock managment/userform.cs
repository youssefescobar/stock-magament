using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_managment
{
    public partial class userform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdminTable;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public userform()
        {

            InitializeComponent();
            loaduser();
        }
        public void loaduser()
        {
            try
            {
                int i = 0;
                dataGridViewuser.Rows.Clear();
                cmd = new SqlCommand("select * from userTbnew", conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridViewuser.Rows.Add(i, dr[0].ToString(), dr[0].ToString(), dr[0].ToString(), dr[0].ToString());

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void dataGridViewuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            newusers newusers = new newusers();
            newusers.button1.Enabled = true;
            newusers.button2.Enabled = false;
            newusers.ShowDialog();
                }
    }
}
