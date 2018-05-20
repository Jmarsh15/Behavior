using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Behavior
{
    public partial class Teacher : Form
    {
        int i = 0;
        int dLeft = 0;
        private void HideStuff()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            txt_Fail.Visible = false;
            txt_Success.Visible = false;
            label7.Visible = false;
            label11.Visible = false;
            txt_Absent.Visible = false;
            checkBox1_Absent.Visible = false;
            checkBox1_Fail.Visible = false;
            checkBox1_Success.Visible = false;
            checkBox2_Absent.Visible = false;
            checkBox2_Fail.Visible = false;
            checkBox2_Success.Visible = false;
            checkBox3_Absent.Visible = false;
            checkBox3_Fail.Visible = false;
            checkBox3_Success.Visible = false;
            checkBox4_Absent.Visible = false;
            checkBox4_Fail.Visible = false;
            checkBox4_Success.Visible = false;
            checkBox5_Absent.Visible = false;
            checkBox5_Fail.Visible = false;
            checkBox5_Success.Visible = false;
            checkBox6_Absent.Visible = false;
            checkBox6_Fail.Visible = false;
            checkBox6_Success.Visible = false;
            checkBox7_Absent.Visible = false;
            checkBox7_Fail.Visible = false;
            checkBox7_Success.Visible = false;
            checkBox8_Absent.Visible = false;
            checkBox8_Fail.Visible = false;
            checkBox8_Success.Visible = false;
            txt_Student1.Visible = false;
            txt_Student2.Visible = false;
            txt_Student3.Visible = false;
            txt_Student4.Visible = false;
            txt_Student5.Visible = false;
            txt_Student6.Visible = false;
            txt_Student7.Visible = false;
            txt_Student8.Visible = false;
            txt_DaysLeft1.Visible = false;
            txt_DaysLeft2.Visible = false;
            txt_DaysLeft3.Visible = false;
            txt_DaysLeft4.Visible = false;
            txt_DaysLeft5.Visible = false;
            txt_DaysLeft6.Visible = false;
            txt_DaysLeft7.Visible = false;
            txt_DaysLeft8.Visible = false;

        }
        SqlConnection cnn = new SqlConnection("Data Source=behaviordatabase.cfzuumxbilpn.us-east-2.rds.amazonaws.com," + "1433;Initial Catalog=Login;User ID=BehaviorTest;Password=jL55hrHErQMD");

        public Teacher()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            HideStuff();
        }

        private void CheckedButton()
        {
            if (checkBox1_Absent.Checked)
            {
                checkBox1_Fail.Checked = false;
                checkBox1_Success.Checked = false;
            }
            else if (checkBox1_Success.Checked)
            {
                checkBox1_Fail.Checked = false;
                checkBox1_Absent.Checked = false;
            }
            else if (checkBox1_Fail.Checked)
            {
                checkBox1_Success.Checked = false;
                checkBox1_Absent.Checked = false;
            }
            if (checkBox2_Absent.Checked)
            {
                checkBox2_Fail.Checked = false;
                checkBox2_Success.Checked = false;
            }
            else if (checkBox2_Success.Checked)
            {
                checkBox2_Fail.Checked = false;
                checkBox2_Absent.Checked = false;
            }
            else if (checkBox2_Fail.Checked)
            {
                checkBox2_Success.Checked = false;
                checkBox2_Absent.Checked = false;
            }
            if (checkBox3_Absent.Checked)
            {
                checkBox3_Fail.Checked = false;
                checkBox3_Success.Checked = false;
            }
            else if (checkBox3_Success.Checked)
            {
                checkBox3_Fail.Checked = false;
                checkBox3_Absent.Checked = false;
            }
            else if (checkBox3_Fail.Checked)
            {
                checkBox3_Success.Checked = false;
                checkBox3_Absent.Checked = false;
            }
            if (checkBox4_Absent.Checked)
            {
                checkBox4_Fail.Checked = false;
                checkBox4_Success.Checked = false;
            }
            else if (checkBox4_Success.Checked)
            {
                checkBox4_Fail.Checked = false;
                checkBox4_Absent.Checked = false;
            }
            else if (checkBox4_Fail.Checked)
            {
                checkBox4_Success.Checked = false;
                checkBox4_Absent.Checked = false;
            }
            if (checkBox5_Absent.Checked)
            {
                checkBox5_Fail.Checked = false;
                checkBox5_Success.Checked = false;
            }
            else if (checkBox5_Success.Checked)
            {
                checkBox5_Fail.Checked = false;
                checkBox5_Absent.Checked = false;
            }
            else if (checkBox5_Fail.Checked)
            {
                checkBox5_Success.Checked = false;
                checkBox5_Absent.Checked = false;
            }
            if (checkBox6_Absent.Checked)
            {
                checkBox6_Fail.Checked = false;
                checkBox6_Success.Checked = false;
            }
            else if (checkBox6_Success.Checked)
            {
                checkBox6_Fail.Checked = false;
                checkBox6_Absent.Checked = false;
            }
            else if (checkBox6_Fail.Checked)
            {
                checkBox6_Success.Checked = false;
                checkBox6_Absent.Checked = false;
            }
            if (checkBox7_Absent.Checked)
            {
                checkBox7_Fail.Checked = false;
                checkBox7_Success.Checked = false;
            }
            else if (checkBox7_Success.Checked)
            {
                checkBox7_Fail.Checked = false;
                checkBox7_Absent.Checked = false;
            }
            else if (checkBox7_Fail.Checked)
            {
                checkBox7_Success.Checked = false;
                checkBox7_Absent.Checked = false;
            }
            if (checkBox8_Absent.Checked)
            {
                checkBox8_Fail.Checked = false;
                checkBox8_Success.Checked = false;
            }
            else if (checkBox8_Success.Checked)
            {
                checkBox8_Fail.Checked = false;
                checkBox8_Absent.Checked = false;
            }
            else if (checkBox8_Fail.Checked)
            {
                checkBox8_Success.Checked = false;
                checkBox8_Absent.Checked = false;
            }
        }
        private void Teacher_Load(object sender, EventArgs e)
        {

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=behaviordatabase.cfzuumxbilpn.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Login;User ID=BehaviorTest;Password=jL55hrHErQMD";
            cnn = new SqlConnection(connetionString);
            try
            {
                // TODO on login set the teachers name 
                string teacherName = "Justin";
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT first_name, last_name, studentid, daysleft FROM Student WHERE teacher = @Teacher", cnn);
                cmd.Parameters.AddWithValue("@Teacher", teacherName);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                    switch (i)
                    {
                        case 1:
                            {
                                txt_Absent.Visible = true;
                                txt_Fail.Visible = true;
                                txt_Success.Visible = true;
                                label1.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                txt_Student1.Text = reader["studentid"].ToString();
                                txt_DaysLeft1.Text = reader["daysleft"].ToString();
                                label1.Visible = true;
                                checkBox1_Absent.Visible = true;
                                checkBox1_Fail.Visible = true;
                                checkBox1_Success.Visible = true;
                            }
                            break;
                        case 2:
                            {
                                txt_Student2.Text = reader["studentid"].ToString();
                                txt_DaysLeft2.Text = reader["daysleft"].ToString();
                                label2.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                label2.Visible = true;
                                checkBox2_Absent.Visible = true;
                                checkBox2_Fail.Visible = true;
                                checkBox2_Success.Visible = true;
                            }
                            break;
                        case 3:
                            {
                                txt_DaysLeft3.Text = reader["daysleft"].ToString();
                                txt_Student3.Text = reader["studentid"].ToString();
                                label3.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                label3.Visible = true;
                                checkBox3_Absent.Visible = true;
                                checkBox3_Fail.Visible = true;
                                checkBox3_Success.Visible = true;
                            }
                            break;
                        case 4:
                            {
                                txt_DaysLeft4.Text = reader["daysleft"].ToString();
                                txt_Student4.Text = reader["studentid"].ToString();
                                label4.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                label4.Visible = true;
                                checkBox4_Absent.Visible = true;
                                checkBox4_Fail.Visible = true;
                                checkBox4_Success.Visible = true;
                            }
                            break;
                        case 5:
                            {
                                txt_DaysLeft5.Text = reader["daysleft"].ToString();
                                txt_Student5.Text = reader["studentid"].ToString();
                                label5.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                label5.Visible = true;
                                checkBox5_Absent.Visible = true;
                                checkBox5_Fail.Visible = true;
                                checkBox5_Success.Visible = true;
                            }
                            break;
                        case 6:
                            {
                                txt_DaysLeft6.Text = reader["daysleft"].ToString();
                                txt_Student6.Text = reader["studentid"].ToString();
                                label6.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                label6.Visible = true;
                                checkBox6_Absent.Visible = true;
                                checkBox6_Fail.Visible = true;
                                checkBox6_Success.Visible = true;
                            }
                            break;
                        case 7:
                            {
                                txt_DaysLeft7.Text = reader["daysleft"].ToString();
                                txt_Student7.Text = reader["studentid"].ToString();
                                label7.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                label7.Visible = true;
                                checkBox7_Absent.Visible = true;
                                checkBox7_Fail.Visible = true;
                                checkBox7_Success.Visible = true;
                            }
                            break;
                        case 8:
                            {
                                txt_DaysLeft8.Text = reader["daysleft"].ToString();
                                txt_Student8.Text = reader["studentid"].ToString();
                                label8.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                label8.Visible = true;
                                checkBox8_Absent.Visible = true;
                                checkBox8_Fail.Visible = true;
                                checkBox8_Success.Visible = true;
                            }
                            break;
                        default:
                            break;
                    }

                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideStuff();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Attandance_Click(object sender, EventArgs e)
        {
            Teacher_Load(sender, e);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            cnn.Open();
            for (int j = 0; j < i; j++)
            {
                if (j == 0 && checkBox1_Absent.Checked || checkBox1_Fail.Checked || checkBox1_Success.Checked)
                {
                    dLeft = Int32.Parse(txt_DaysLeft1.Text) - 1;
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft Where studentid = @Studentid ", cnn);
                    UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                    UpdateStudent.Parameters.AddWithValue(@"Studentid", txt_Student1.Text);
                    UpdateStudent.ExecuteNonQuery();
                    SqlCommand SaveStudent = new SqlCommand("insert into DailyStudentSuccess (attadance, time, studentid, daysleft) values " +
                    "(@attadance,@time, @studentid,@daysleft)", cnn);
                    SaveStudent.Parameters.AddWithValue(@"attadance", Attadance(j));
                    SaveStudent.Parameters.AddWithValue(@"time", DateTime.Now);
                    SaveStudent.Parameters.AddWithValue(@"studentid", txt_Student1.Text);
                    SaveStudent.Parameters.AddWithValue(@"daysleft", dLeft);
                    SaveStudent.ExecuteNonQuery();
                }
                if (j == 1 && checkBox2_Absent.Checked || checkBox2_Fail.Checked || checkBox2_Success.Checked)
                {
                    dLeft = Int32.Parse(txt_DaysLeft2.Text) - 1;
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft Where studentid = @Studentid ", cnn);
                    UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                    UpdateStudent.Parameters.AddWithValue(@"Studentid", txt_Student2.Text);
                    UpdateStudent.ExecuteNonQuery();
                    SqlCommand SaveStudent = new SqlCommand("insert into DailyStudentSuccess (attadance, time, studentid, daysleft) values " +
                    "(@attadance,@time, @studentid,@daysleft)", cnn);
                    SaveStudent.Parameters.AddWithValue(@"attadance", Attadance(j));
                    SaveStudent.Parameters.AddWithValue(@"time", DateTime.Now);
                    SaveStudent.Parameters.AddWithValue(@"studentid", txt_Student2.Text);
                    SaveStudent.Parameters.AddWithValue(@"daysleft", dLeft);
                    SaveStudent.ExecuteNonQuery();
                }
                if (j == 2 && checkBox3_Absent.Checked || checkBox3_Fail.Checked || checkBox3_Success.Checked)
                {
                    dLeft = Int32.Parse(txt_DaysLeft3.Text) - 1;
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft Where studentid = @Studentid ", cnn);
                    UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                    UpdateStudent.Parameters.AddWithValue(@"Studentid", txt_Student1.Text);
                    UpdateStudent.ExecuteNonQuery();
                    SqlCommand SaveStudent = new SqlCommand("insert into DailyStudentSuccess (attadance, time, studentid, daysleft) values " +
                    "(@attadance,@time, @studentid,@daysleft)", cnn);
                    SaveStudent.Parameters.AddWithValue(@"attadance", Attadance(j));
                    SaveStudent.Parameters.AddWithValue(@"time", DateTime.Now);
                    SaveStudent.Parameters.AddWithValue(@"studentid", txt_Student3.Text);
                    SaveStudent.Parameters.AddWithValue(@"daysleft", dLeft);
                    SaveStudent.ExecuteNonQuery();
                }
                if (j == 3 && checkBox4_Absent.Checked || checkBox4_Fail.Checked || checkBox4_Success.Checked)
                {
                    dLeft = Int32.Parse(txt_DaysLeft4.Text) - 1;
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft Where studentid = @Studentid ", cnn);
                    UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                    UpdateStudent.Parameters.AddWithValue(@"Studentid", txt_Student4.Text);
                    UpdateStudent.ExecuteNonQuery();
                    SqlCommand SaveStudent = new SqlCommand("insert into DailyStudentSuccess (attadance, time, studentid, daysleft) values " +
                    "(@attadance,@time, @studentid,@daysleft)", cnn);
                    SaveStudent.Parameters.AddWithValue(@"attadance", Attadance(j));
                    SaveStudent.Parameters.AddWithValue(@"time", DateTime.Now);
                    SaveStudent.Parameters.AddWithValue(@"studentid", txt_Student4.Text);
                    SaveStudent.Parameters.AddWithValue(@"daysleft", dLeft);
                    SaveStudent.ExecuteNonQuery();
                }
                if (j == 4 && checkBox5_Absent.Checked || checkBox5_Fail.Checked || checkBox5_Success.Checked)
                {
                    dLeft = Int32.Parse(txt_DaysLeft5.Text) - 1;
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft Where studentid = @Studentid ", cnn);
                    UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                    UpdateStudent.Parameters.AddWithValue(@"Studentid", txt_Student5.Text);
                    UpdateStudent.ExecuteNonQuery();
                    SqlCommand SaveStudent = new SqlCommand("insert into DailyStudentSuccess (attadance, time, studentid, daysleft) values " +
                    "(@attadance,@time, @studentid,@daysleft)", cnn);
                    SaveStudent.Parameters.AddWithValue(@"attadance", Attadance(j));
                    SaveStudent.Parameters.AddWithValue(@"time", DateTime.Now);
                    SaveStudent.Parameters.AddWithValue(@"studentid", txt_Student5.Text);
                    SaveStudent.Parameters.AddWithValue(@"daysleft", dLeft);
                    SaveStudent.ExecuteNonQuery();
                }
                if (j == 5 && checkBox6_Absent.Checked || checkBox6_Fail.Checked || checkBox6_Success.Checked)
                {
                    dLeft = Int32.Parse(txt_DaysLeft6.Text) - 1;
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft Where studentid = @Studentid ", cnn);
                    UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                    UpdateStudent.Parameters.AddWithValue(@"Studentid", txt_Student6.Text);
                    UpdateStudent.ExecuteNonQuery();
                    SqlCommand SaveStudent = new SqlCommand("insert into DailyStudentSuccess (attadance, time, studentid, daysleft) values " +
                    "(@attadance,@time, @studentid,@daysleft)", cnn);
                    SaveStudent.Parameters.AddWithValue(@"attadance", Attadance(j));
                    SaveStudent.Parameters.AddWithValue(@"time", DateTime.Now);
                    SaveStudent.Parameters.AddWithValue(@"studentid", txt_Student6.Text);
                    SaveStudent.Parameters.AddWithValue(@"daysleft", dLeft);
                    SaveStudent.ExecuteNonQuery();
                }
                if (j == 6 && checkBox7_Absent.Checked || checkBox7_Fail.Checked || checkBox7_Success.Checked)
                {
                    dLeft = Int32.Parse(txt_DaysLeft7.Text) - 1;
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft Where studentid = @Studentid ", cnn);
                    UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                    UpdateStudent.Parameters.AddWithValue(@"Studentid", txt_Student7.Text);
                    UpdateStudent.ExecuteNonQuery();
                    SqlCommand SaveStudent = new SqlCommand("insert into DailyStudentSuccess (attadance, time, studentid, daysleft) values " +
                    "(@attadance,@time, @studentid,@daysleft)", cnn);
                    SaveStudent.Parameters.AddWithValue(@"attadance", Attadance(j));
                    SaveStudent.Parameters.AddWithValue(@"time", DateTime.Now);
                    SaveStudent.Parameters.AddWithValue(@"studentid", txt_Student7.Text);
                    SaveStudent.Parameters.AddWithValue(@"daysleft", dLeft);
                    SaveStudent.ExecuteNonQuery();
                }
                if (j == 7 && checkBox8_Absent.Checked || checkBox8_Fail.Checked || checkBox8_Success.Checked)
                {
                    dLeft = Int32.Parse(txt_DaysLeft8.Text) - 1;
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft Where studentid = @Studentid ", cnn);
                    UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                    UpdateStudent.Parameters.AddWithValue(@"Studentid", txt_Student8.Text);
                    UpdateStudent.ExecuteNonQuery();
                    SqlCommand SaveStudent = new SqlCommand("insert into DailyStudentSuccess (attadance, time, studentid, daysleft) values " +
                    "(@attadance,@time, @studentid,@daysleft)", cnn);
                    SaveStudent.Parameters.AddWithValue(@"attadance", Attadance(j));
                    SaveStudent.Parameters.AddWithValue(@"time", DateTime.Now);
                    SaveStudent.Parameters.AddWithValue(@"studentid", txt_Student8.Text);
                    SaveStudent.Parameters.AddWithValue(@"daysleft", dLeft);
                    SaveStudent.ExecuteNonQuery();
                }
            }
            checkBox1_Absent.Checked = false;
            checkBox1_Fail.Checked = false;
            checkBox1_Success.Checked = false;
            checkBox2_Absent.Checked = false;
            checkBox2_Fail.Checked = false;
            checkBox2_Success.Checked = false;
            checkBox3_Absent.Checked = false;
            checkBox3_Fail.Checked = false;
            checkBox3_Success.Checked = false;
            checkBox4_Absent.Checked = false;
            checkBox4_Fail.Checked = false;
            checkBox4_Success.Checked = false;
            checkBox5_Absent.Checked = false;
            checkBox5_Fail.Checked = false;
            checkBox5_Success.Checked = false;
            checkBox6_Absent.Checked = false;
            checkBox6_Fail.Checked = false;
            checkBox6_Success.Checked = false;
            checkBox7_Absent.Checked = false;
            checkBox7_Fail.Checked = false;
            checkBox7_Success.Checked = false;
            checkBox8_Absent.Checked = false;
            checkBox8_Fail.Checked = false;
            checkBox8_Success.Checked = false;
            cnn.Close();
        }
        public string Attadance(int i)
        {
            if (i == 0)
            {
                if (checkBox1_Absent.Checked)
                {
                    return "Absent";
                }
                else if (checkBox1_Fail.Checked)
                {
                    return "Fail";
                }
                else if (checkBox1_Success.Checked)
                {
                    return "Success";
                }
            }
            if (i == 1)
            {
                if (checkBox2_Absent.Checked)
                {
                    return "Absent";
                }
                else if (checkBox2_Fail.Checked)
                {
                    return "Fail";
                }
                else if (checkBox2_Success.Checked)
                {
                    return "Success";
                }
            }
            return "Absent";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void checkBox1_Success_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_Success_Click(object sender, EventArgs e)
        {
            checkBox1_Absent.Checked = false;
            checkBox1_Fail.Checked = false;
        }

        private void checkBox1_Absent_Click(object sender, EventArgs e)
        {
            checkBox1_Success.Checked = false;
            checkBox1_Fail.Checked = false;
        }

        private void checkBox1_Fail_Click(object sender, EventArgs e)
        {
            checkBox1_Absent.Checked = false;
            checkBox1_Success.Checked = false;
        }
        private void checkBox2_Success_Click(object sender, EventArgs e)
        {
            checkBox2_Absent.Checked = false;
            checkBox2_Fail.Checked = false;
        }

        private void checkBox2_Absent_Click(object sender, EventArgs e)
        {
            checkBox2_Success.Checked = false;
            checkBox2_Fail.Checked = false;
        }

        private void checkBox2_Fail_Click(object sender, EventArgs e)
        {
            checkBox2_Absent.Checked = false;
            checkBox2_Success.Checked = false;
        }
        private void checkBox3_Success_Click(object sender, EventArgs e)
        {
            checkBox3_Absent.Checked = false;
            checkBox3_Fail.Checked = false;
        }

        private void checkBox3_Absent_Click(object sender, EventArgs e)
        {
            checkBox3_Success.Checked = false;
            checkBox3_Fail.Checked = false;
        }

        private void checkBox3_Fail_Click(object sender, EventArgs e)
        {
            checkBox3_Absent.Checked = false;
            checkBox3_Success.Checked = false;
        }
        private void checkBox4_Success_Click(object sender, EventArgs e)
        {
            checkBox4_Absent.Checked = false;
            checkBox4_Fail.Checked = false;
        }

        private void checkBox4_Absent_Click(object sender, EventArgs e)
        {
            checkBox4_Success.Checked = false;
            checkBox4_Fail.Checked = false;
        }

        private void checkBox4_Fail_Click(object sender, EventArgs e)
        {
            checkBox4_Absent.Checked = false;
            checkBox4_Success.Checked = false;
        }
        private void checkBox5_Success_Click(object sender, EventArgs e)
        {
            checkBox5_Absent.Checked = false;
            checkBox5_Fail.Checked = false;
        }

        private void checkBox5_Absent_Click(object sender, EventArgs e)
        {
            checkBox5_Success.Checked = false;
            checkBox5_Fail.Checked = false;
        }

        private void checkBox5_Fail_Click(object sender, EventArgs e)
        {
            checkBox5_Absent.Checked = false;
            checkBox5_Success.Checked = false;
        }
        private void checkBox6_Success_Click(object sender, EventArgs e)
        {
            checkBox6_Absent.Checked = false;
            checkBox6_Fail.Checked = false;
        }

        private void checkBox6_Absent_Click(object sender, EventArgs e)
        {
            checkBox6_Success.Checked = false;
            checkBox6_Fail.Checked = false;
        }

        private void checkBox6_Fail_Click(object sender, EventArgs e)
        {
            checkBox6_Absent.Checked = false;
            checkBox6_Success.Checked = false;
        }
        private void checkBox7_Success_Click(object sender, EventArgs e)
        {
            checkBox7_Absent.Checked = false;
            checkBox7_Fail.Checked = false;
        }

        private void checkBox7_Absent_Click(object sender, EventArgs e)
        {
            checkBox7_Success.Checked = false;
            checkBox7_Fail.Checked = false;
        }

        private void checkBox7_Fail_Click(object sender, EventArgs e)
        {
            checkBox7_Absent.Checked = false;
            checkBox7_Success.Checked = false;
        }
        private void checkBox8_Success_Click(object sender, EventArgs e)
        {
            checkBox8_Absent.Checked = false;
            checkBox8_Fail.Checked = false;
        }

        private void checkBox8_Absent_Click(object sender, EventArgs e)
        {
            checkBox8_Success.Checked = false;
            checkBox8_Fail.Checked = false;
        }

        private void checkBox8_Fail_Click(object sender, EventArgs e)
        {
            checkBox8_Absent.Checked = false;
            checkBox8_Success.Checked = false;
        }

    }
}
