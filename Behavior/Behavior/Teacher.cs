using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Behavior
{
    public partial class Teacher : Form
    {
        string Firstname = null;

        public Teacher()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // string connetionString = null;
            // SqlConnection cnn;
            // connetionString = "Data Source=behaviordatabase.cfzuumxbilpn.us-east-2.rds.amazonaws.com;Initial Catalog=rds.behaviordatabase.Login;User ID=BehaviorTest;Password=jL55hrHErQMD";
            // cnn = new SqlConnection(connetionString);
            // using (resource)
            // {
            //     foreach (name item in cnn)
            //     {
            //
            //     }
            // }
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=behaviordatabase.cfzuumxbilpn.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Login;User ID=BehaviorTest;Password=jL55hrHErQMD";
                               cnn = new SqlConnection(connetionString);
            try
            {
                
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT name FROM Student",cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                while (reader.Read())
                {
                    Firstname = Firstname + reader["name"].ToString();
                }
                MessageBox.Show(Firstname.ToString());
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
