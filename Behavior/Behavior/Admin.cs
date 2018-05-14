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
                SaveStudent.Parameters.AddWithValue(@"teacher", Combo_Teachers.Text);
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
                    "(@username,@password,@access,@first_name,@last_name)", cnn);
                SaveStudent.Parameters.AddWithValue(@"first_name", txt_FirstName.Text);
                SaveStudent.Parameters.AddWithValue(@"last_name", txt_LastName.Text);
                string user = txt_LastName + "_" + txt_FirstName;
                SaveStudent.Parameters.AddWithValue(@"username", user);
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
            Combo_Teachers.Text = "";
        }

        private void RadioButton()
        {
            if (radio_Change.Checked)
            {
                radio_Delete.Checked = false;
            }
            else
            {
                radio_Change.Checked = false;
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT first_name, last_name FROM Login WHERE access = 2", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                Combo_Teachers.Items.Add(reader["first_name"].ToString() + reader["last_name"].ToString());
            }
            cnn.Close();
            HideStuff();
            panel_Student.Visible = true;
            label1.Text = "First Name";
            label1.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label4.Text = "Student ID";
            txt_Days.Visible = true;
            txt_FirstName.Visible = true;
            txt_LastName.Visible = true;
            txt_StudentID.Visible = true;
            Combo_Teachers.Visible = true;
        }

        private void btn_AddTeacher_Click(object sender, EventArgs e)
        {
            HideStuff();
            label1.Visible = true;
            label1.Text = "First Name";
            label2.Visible = true;
            panel_Student.Visible = true;
            txt_TeacherPassword.Visible = true;
            txt_FirstName.Visible = true;
            txt_LastName.Visible = true;
            label4.Text = "Password";
            label4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT first_name, last_name FROM Student WHERE TEACHER = 'Corey'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                combo_StudentNames.Items.Add( reader["first_name"].ToString() + reader["last_name"].ToString());
            }
            cnn.Close();
            HideStuff();
            combo_Questions.Visible = false;
            label1.Text = "First Name";
            combo_StudentNames.Visible = true;
            dataGridView1.Visible = true;
            label3.Visible = true;
        }

        private void HideStuff()
        {
            combo_Questions.Visible = false;
            label1.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label1.Text = "First Name";
            label2.Visible = false;
            label4.Visible = false;
            txt_Days.Visible = false;
            txt_FirstName.Visible = false;
            txt_LastName.Visible = false;
            txt_StudentID.Visible = false;
            Combo_Teachers.Visible = false;
            txt_TeacherPassword.Visible = false;
            btn_Save.Visible = false;
            combo_StudentNames.Visible = false;
            dataGridView1.Visible = false;
            Combo_Teachers.Visible = false;
            radio_Change.Visible = false;
            radio_Delete.Visible = false;
            label3.Visible = false;
        }
        private void combo_StudentNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ChangeStudent_Click(object sender, EventArgs e)
        {
            HideStuff();
            label1.Visible = true;
            label1.Text = "StudentID";
            txt_FirstName.Visible = true;
            // Get from the user if they want to change the teacher or delete the student and us the studentID to get other information
            string studentID = txt_FirstName.Text;
            RadioButton();
        }
    }
}

