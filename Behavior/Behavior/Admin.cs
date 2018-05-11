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

namespace Behavior
{
    public partial class Admin : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=behaviordatabase.cfzuumxbilpn.us-east-2.rds.amazonaws.com," + "1433;Initial Catalog=Login;User ID=BehaviorTest;Password=jL55hrHErQMD");
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommand SaveStudent = new SqlCommand();
            SaveStudent.Connection = cnn;
            SaveStudent.CommandText = "insert into Student (id,first_name, last_name, teacher, days, studentid) values (@id,@first_name,@last_name, @teacher,@days,@studentid)";
           //SaveStudent.Parameters.AddWithValue(@"id", txt_StudentID.Text);
           //SaveStudent.Parameters.AddWithValue(@"first_name", txt_FirstName.Text);
           //SaveStudent.Parameters.AddWithValue(@"last_name", txt_LastName.Text);
           //SaveStudent.Parameters.AddWithValue(@"teacher", txt_Teacher.Text);
           //SaveStudent.Parameters.AddWithValue(@"days", txt_Days.Text);
           //SaveStudent.Parameters.AddWithValue(@"studentid", txt_StudentID.Text);
            cnn.Open();
            SaveStudent.ExecuteNonQuery();
            cnn.Close();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}

