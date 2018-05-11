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
            panel_Student.Visible = false;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Days.Visible)
            {
                SqlCommand SaveStudent = new SqlCommand("insert into Student (first_name, last_name, teacher, days, daysleft,studentid) values " +
                "(@first_name,@last_name, @teacher,@days,@daysleft,@studentid)", cnn);
                SaveStudent.Parameters.AddWithValue(@"first_name", txt_FirstName.Text);
                SaveStudent.Parameters.AddWithValue(@"last_name", txt_LastName.Text);
                SaveStudent.Parameters.AddWithValue(@"teacher", txt_Teacher.Text);
                SaveStudent.Parameters.AddWithValue(@"days", txt_Days.Text);
                SaveStudent.Parameters.AddWithValue(@"daysleft", txt_Days.Text);
                SaveStudent.Parameters.AddWithValue(@"studentid", txt_StudentID.Text);
                cnn.Open();
                SaveStudent.ExecuteNonQuery();
                cnn.Close();

            }
            else
            {
                SqlCommand SaveStudent = new SqlCommand("insert into Login (username, password, access,first_name, last_name ) values " +
                    "(@username,@password,@acess@first_name,@last_name)", cnn);
                SaveStudent.Parameters.AddWithValue(@"first_name", txt_FirstName.Text);
                SaveStudent.Parameters.AddWithValue(@"last_name", txt_LastName.Text);
                SaveStudent.Parameters.AddWithValue(@"username", txt_LastName + "_" + txt_FirstName);
                SaveStudent.Parameters.AddWithValue(@"password", txt_TeacherPassword.Text);
                SaveStudent.Parameters.AddWithValue(@"access", 2);
                cnn.Open();
                SaveStudent.ExecuteNonQuery();
                cnn.Close();
            }
            txt_Days.Text = "";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_StudentID.Text = "";
            txt_Teacher.Text = "";
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            panel_Student.Visible = true;
            label1.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label2.Visible = true;
            label4.Text = "Student ID";
            txt_Days.Visible = true;
            txt_FirstName.Visible = true;
            txt_LastName.Visible = true;
            txt_StudentID.Visible = true;
            txt_Teacher.Visible = true;
            txt_TeacherPassword.Visible = false;
        }

        private void btn_AddTeacher_Click(object sender, EventArgs e)
        {
            panel_Student.Visible = true;
            txt_Days.Visible = false;
            txt_TeacherPassword.Visible = true;
            txt_FirstName.Visible = true;
            txt_LastName.Visible = true;
            txt_StudentID.Visible = false;
            txt_Teacher.Visible = false;
            label4.Text = "Password";
            label10.Visible = false;
            label11.Visible = false;

        }

    }
}

