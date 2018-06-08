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
            comboBox1.Visible = false;
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
            label14.Visible = false;
            txt_Other.Visible = false;
            comboBox1.Visible = false;
            label11.Visible = false;
            label9.Visible = false;
            txt_endofincident.Visible = false;
            txt_Startofincident.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            label10.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }
        SqlConnection cnn = new SqlConnection("Data Source=behaviordatabase.cfzuumxbilpn.us-east-2.rds.amazonaws.com," + "1433;Initial Catalog=Login;User ID=BehaviorTest;Password=jL55hrHErQMD");
        string studentTotalDays1;
        int ave;
        int re;
        int current;
        int longs;
        string studentTotalDays2;
        string studentTotalDays3;
        string studentTotalDays4;
        string studentTotalDays5;
        string studentTotalDays6;
        string studentTotalDays7;
        string studentTotalDays8;
        string studentLongestStreak1;
        string studentLongestStreak2;
        string studentLongestStreak3;
        string studentLongestStreak4;
        string studentLongestStreak5;
        string studentLongestStreak6;
        string studentLongestStreak7;
        string studentLongestStreak8;
        string studentCurrentStreak1;
        string studentCurrentStreak2;
        string studentCurrentStreak3;
        string studentCurrentStreak4;
        string studentCurrentStreak5;
        string studentCurrentStreak6;
        string studentCurrentStreak7;
        string studentCurrentStreak8;
        string studentAverageStreak1;
        string studentAverageStreak2;
        string studentAverageStreak3;
        string studentAverageStreak4;
        string studentAverageStreak5;
        string studentAverageStreak6;
        string studentAverageStreak7;
        string studentAverageStreak8;
        string studentResets1;
        string studentResets2;
        string studentResets3;
        string studentResets4;
        string studentResets5;
        string studentResets6;
        string studentResets7;
        string studentResets8;
        string studentDays1;
        string studentDays2;
        string studentDays3;
        string studentDays4;
        string studentDays5;
        string studentDays6;
        string studentDays7;
        string studentDays8;
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
            HideStuff();
            if (label1.Text == "label1")
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
                    SqlCommand cmd = new SqlCommand("SELECT first_name, last_name, studentid, daysleft,currentstreak,longeststreak,totaldays,average,resets,days FROM Student WHERE teacher = @Teacher", cnn);
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
                                    studentCurrentStreak1 = reader["currentstreak"].ToString();
                                    studentLongestStreak1 = reader["longeststreak"].ToString();
                                    studentTotalDays1 = reader["totaldays"].ToString();
                                    studentAverageStreak1 = reader["average"].ToString();
                                    studentResets1 = reader["resets"].ToString();
                                    studentDays1 = reader["days"].ToString();
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
                                    studentCurrentStreak2 = reader["currentstreak"].ToString();
                                    studentLongestStreak2 = reader["longeststreak"].ToString();
                                    studentTotalDays2 = reader["totaldays"].ToString();
                                    studentAverageStreak2 = reader["average"].ToString();
                                    studentResets2 = reader["resets"].ToString();
                                    studentDays2 = reader["days"].ToString();

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
                                    studentCurrentStreak3 = reader["currentstreak"].ToString();
                                    studentLongestStreak3 = reader["longeststreak"].ToString();
                                    studentTotalDays3 = reader["totaldays"].ToString();
                                    studentAverageStreak3 = reader["average"].ToString();
                                    studentResets3 = reader["resets"].ToString();
                                    studentDays3 = reader["days"].ToString();

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
                                    studentCurrentStreak4 = reader["currentstreak"].ToString();
                                    studentLongestStreak4 = reader["longeststreak"].ToString();
                                    studentTotalDays4 = reader["totaldays"].ToString();
                                    studentAverageStreak4 = reader["average"].ToString();
                                    studentResets4 = reader["resets"].ToString();
                                    studentDays4 = reader["days"].ToString();

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
                                    studentCurrentStreak5 = reader["currentstreak"].ToString();
                                    studentLongestStreak5 = reader["longeststreak"].ToString();
                                    studentTotalDays5 = reader["totaldays"].ToString();
                                    studentAverageStreak5 = reader["average"].ToString();
                                    studentResets5 = reader["resets"].ToString();
                                    studentDays5 = reader["days"].ToString();

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
                                    studentCurrentStreak6 = reader["currentstreak"].ToString();
                                    studentLongestStreak6 = reader["longeststreak"].ToString();
                                    studentTotalDays6 = reader["totaldays"].ToString();
                                    studentAverageStreak6 = reader["average"].ToString();
                                    studentResets6 = reader["resets"].ToString();
                                    studentDays6 = reader["days"].ToString();

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
                                    studentCurrentStreak7 = reader["currentstreak"].ToString();
                                    studentLongestStreak7 = reader["longeststreak"].ToString();
                                    studentTotalDays7 = reader["totaldays"].ToString();
                                    studentAverageStreak7 = reader["average"].ToString();
                                    studentResets7 = reader["resets"].ToString();
                                    studentDays7 = reader["days"].ToString();

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
                                    studentCurrentStreak8 = reader["currentstreak"].ToString();
                                    studentLongestStreak8 = reader["longeststreak"].ToString();
                                    studentTotalDays8 = reader["totaldays"].ToString();
                                    studentAverageStreak8 = reader["average"].ToString();
                                    studentResets8 = reader["resets"].ToString();
                                    studentDays8 = reader["days"].ToString();

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
            else
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == 0)
                    {
                        txt_Absent.Visible = true;
                        txt_Fail.Visible = true;
                        txt_Success.Visible = true;
                        label1.Visible = true;
                        checkBox1_Absent.Visible = true;
                        checkBox1_Fail.Visible = true;
                        checkBox1_Success.Visible = true;
                    }
                    else if (j == 1)
                    {
                        label2.Visible = true;
                        checkBox2_Absent.Visible = true;
                        checkBox2_Fail.Visible = true;
                        checkBox2_Success.Visible = true;
                    }
                    else if (j == 2)
                    {
                        label3.Visible = true;
                        checkBox3_Absent.Visible = true;
                        checkBox3_Fail.Visible = true;
                        checkBox3_Success.Visible = true;
                    }
                    else if (j == 3)
                    {
                        label4.Visible = true;
                        checkBox4_Absent.Visible = true;
                        checkBox4_Fail.Visible = true;
                        checkBox4_Success.Visible = true;
                    }
                    else if (j == 4)
                    {
                        label5.Visible = true;
                        checkBox5_Absent.Visible = true;
                        checkBox5_Fail.Visible = true;
                        checkBox5_Success.Visible = true;
                    }
                    else if (j == 5)
                    {
                        label6.Visible = true;
                        checkBox6_Absent.Visible = true;
                        checkBox6_Fail.Visible = true;
                        checkBox6_Success.Visible = true;
                    }
                    else if (j == 6)
                    {
                        label7.Visible = true;
                        checkBox7_Absent.Visible = true;
                        checkBox7_Fail.Visible = true;
                        checkBox7_Success.Visible = true;
                    }
                    else if (j == 7)
                    {
                        label8.Visible = true;
                        checkBox8_Absent.Visible = true;
                        checkBox8_Fail.Visible = true;
                        checkBox8_Success.Visible = true;
                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            HideStuff();
            comboBox1.Visible = true;
            label11.Visible = true;
            label9.Visible = true;
            txt_endofincident.Visible = true;
            txt_Startofincident.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Items.Add("Maladaptive verbal");
                comboBox2.Items.Add("Physical aggression");
                comboBox2.Items.Add("Noncompliance");
                comboBox2.Items.Add("Elopment");
                comboBox2.Items.Add("SIB");
                comboBox2.Items.Add("Other");
                comboBox3.Items.Add("1");
                comboBox3.Items.Add("2");
                comboBox3.Items.Add("3");
                comboBox3.Items.Add("4");
                comboBox3.Items.Add("5");
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=behaviordatabase.cfzuumxbilpn.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Login;User ID=BehaviorTest;Password=jL55hrHErQMD";
                cnn = new SqlConnection(connetionString);
                // TODO on login set the teachers name 
                string teacherName = "Justin";
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT first_name, last_name,studentid FROM Student WHERE teacher = @Teacher", cnn);
                cmd.Parameters.AddWithValue("@Teacher", teacherName);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["first_name"].ToString() + " " + reader["last_name"].ToString());
                }
            }

            if (comboBox3.SelectedIndex == 5)
            {
                label14.Visible = true;
                txt_Other.Visible = true;
            }

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
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft,average = @Average,totaldays = @TotalDays,longeststreak = LongestStreak,currentstreak = @CurrentStreak Where studentid = @Studentid ", cnn);
                    if (checkBox1_Fail.Checked)
                    {
                        ave = Int32.Parse(studentTotalDays1) / Int32.Parse(studentResets1);
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", studentDays1);
                        re = Int32.Parse(studentResets1) + 1;
                        studentResets1 = re.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"Average", ave);
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", 0);
                    }
                    else
                    {
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                        current = Int32.Parse(studentCurrentStreak1) + 1;
                        studentCurrentStreak1 = current.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", studentCurrentStreak1);
                    }
                    longs = Int32.Parse(studentLongestStreak1) + 1;
                    studentCurrentStreak1 = longs.ToString();
                    if (current <= longs)
                    {
                        UpdateStudent.Parameters.AddWithValue(@"LongestStreak", studentLongestStreak1);
                    }
                    UpdateStudent.Parameters.AddWithValue(@"TotalDays", studentTotalDays1);
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
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft,average = @Average,totaldays = @TotalDays,longeststreak = LongestStreak,currentstreak = @CurrentStreak Where studentid = @Studentid ", cnn);
                    if (checkBox2_Fail.Checked)
                    {
                        ave = Int32.Parse(studentTotalDays2) / Int32.Parse(studentResets2);
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", studentDays2);
                        re = Int32.Parse(studentResets2) + 1;
                        studentResets2 = re.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"Average", ave);
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", 0);
                    }
                    else
                    {
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                        current = Int32.Parse(studentCurrentStreak2) + 1;
                        studentCurrentStreak2 = current.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", studentCurrentStreak2);
                    }
                    longs = Int32.Parse(studentLongestStreak2) + 1;
                    studentCurrentStreak2 = longs.ToString();
                    if (current <= longs)
                    {
                        UpdateStudent.Parameters.AddWithValue(@"LongestStreak", studentLongestStreak2);
                    }
                    UpdateStudent.Parameters.AddWithValue(@"TotalDays", studentTotalDays2);
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
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft,average = @Average,totaldays = @TotalDays,longeststreak = LongestStreak,currentstreak = @CurrentStreak Where studentid = @Studentid ", cnn);
                    if (checkBox3_Fail.Checked)
                    {
                        ave = Int32.Parse(studentTotalDays3) / Int32.Parse(studentResets3);
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", studentDays3);
                        re = Int32.Parse(studentResets3) + 1;
                        studentResets3 = re.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"Average", ave);
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", 0);
                    }
                    else
                    {
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                        current = Int32.Parse(studentCurrentStreak3) + 1;
                        studentCurrentStreak3 = current.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", studentCurrentStreak3);
                    }
                    longs = Int32.Parse(studentLongestStreak3) + 1;
                    studentCurrentStreak3 = longs.ToString();
                    if (current <= longs)
                    {
                        UpdateStudent.Parameters.AddWithValue(@"LongestStreak", studentLongestStreak3);
                    }
                    UpdateStudent.Parameters.AddWithValue(@"TotalDays", studentTotalDays3);
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
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft,average = @Average,totaldays = @TotalDays,longeststreak = LongestStreak,currentstreak = @CurrentStreak Where studentid = @Studentid ", cnn);
                    if (checkBox4_Fail.Checked)
                    {
                        ave = Int32.Parse(studentTotalDays4) / Int32.Parse(studentResets4);
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", studentDays4);
                        re = Int32.Parse(studentResets4) + 1;
                        studentResets4 = re.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"Average", ave);
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", 0);
                    }
                    else
                    {
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                        current = Int32.Parse(studentCurrentStreak4) + 1;
                        studentCurrentStreak4 = current.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", studentCurrentStreak4);
                    }
                    longs = Int32.Parse(studentLongestStreak4) + 1;
                    studentCurrentStreak4 = longs.ToString();
                    if (current <= longs)
                    {
                        UpdateStudent.Parameters.AddWithValue(@"LongestStreak", studentLongestStreak4);
                    }
                    UpdateStudent.Parameters.AddWithValue(@"TotalDays", studentTotalDays4);
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
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft,average = @Average,totaldays = @TotalDays,longeststreak = LongestStreak,currentstreak = @CurrentStreak Where studentid = @Studentid ", cnn);
                    if (checkBox5_Fail.Checked)
                    {
                        ave = Int32.Parse(studentTotalDays5) / Int32.Parse(studentResets5);
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", studentDays5);
                        re = Int32.Parse(studentResets5) + 1;
                        studentResets5 = re.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"Average", ave);
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", 0);
                    }
                    else
                    {
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                        current = Int32.Parse(studentCurrentStreak5) + 1;
                        studentCurrentStreak5 = current.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", studentCurrentStreak5);
                    }
                    longs = Int32.Parse(studentLongestStreak5) + 1;
                    studentCurrentStreak5 = longs.ToString();
                    if (current <= longs)
                    {
                        UpdateStudent.Parameters.AddWithValue(@"LongestStreak", studentLongestStreak5);
                    }
                    UpdateStudent.Parameters.AddWithValue(@"TotalDays", studentTotalDays5);
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
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft,average = @Average,totaldays = @TotalDays,longeststreak = LongestStreak,currentstreak = @CurrentStreak Where studentid = @Studentid ", cnn);
                    if (checkBox6_Fail.Checked)
                    {
                        ave = Int32.Parse(studentTotalDays6) / Int32.Parse(studentResets6);
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", studentDays6);
                        re = Int32.Parse(studentResets6) + 1;
                        studentResets6 = re.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"Average", ave);
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", 0);
                    }
                    else
                    {
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                        current = Int32.Parse(studentCurrentStreak6) + 1;
                        studentCurrentStreak6 = current.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", studentCurrentStreak6);
                    }
                    longs = Int32.Parse(studentLongestStreak6) + 1;
                    studentCurrentStreak6 = longs.ToString();
                    if (current <= longs)
                    {
                        UpdateStudent.Parameters.AddWithValue(@"LongestStreak", studentLongestStreak6);
                    }
                    UpdateStudent.Parameters.AddWithValue(@"TotalDays", studentTotalDays6);
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
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft,average = @Average,totaldays = @TotalDays,longeststreak = LongestStreak,currentstreak = @CurrentStreak Where studentid = @Studentid ", cnn);
                    if (checkBox7_Fail.Checked)
                    {
                        ave = Int32.Parse(studentTotalDays7) / Int32.Parse(studentResets7);
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", studentDays7);
                        re = Int32.Parse(studentResets7) + 1;
                        studentResets7 = re.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"Average", ave);
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", 0);
                    }
                    else
                    {
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                        current = Int32.Parse(studentCurrentStreak7) + 1;
                        studentCurrentStreak7 = current.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", studentCurrentStreak7);
                    }
                    longs = Int32.Parse(studentLongestStreak7) + 1;
                    studentCurrentStreak7 = longs.ToString();
                    if (current <= longs)
                    {
                        UpdateStudent.Parameters.AddWithValue(@"LongestStreak", studentLongestStreak7);
                    }
                    UpdateStudent.Parameters.AddWithValue(@"TotalDays", studentTotalDays7);
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
                    SqlCommand UpdateStudent = new SqlCommand("UPDATE Student SET daysleft = @Daysleft,average = @Average,totaldays = @TotalDays,longeststreak = LongestStreak,currentstreak = @CurrentStreak Where studentid = @Studentid ", cnn);
                    if (checkBox8_Fail.Checked)
                    {
                        ave = Int32.Parse(studentTotalDays1) / Int32.Parse(studentResets8);
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", studentDays8);
                        re = Int32.Parse(studentResets8) + 1;
                        studentResets8 = re.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"Average", ave);
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", 0);
                    }
                    else
                    {
                        UpdateStudent.Parameters.AddWithValue(@"Daysleft", dLeft);
                        current = Int32.Parse(studentCurrentStreak8) + 1;
                        studentCurrentStreak8 = current.ToString();
                        UpdateStudent.Parameters.AddWithValue(@"CurrentStreak", studentCurrentStreak8);
                    }
                    longs = Int32.Parse(studentLongestStreak8) + 1;
                    studentCurrentStreak8 = longs.ToString();
                    if (current <= longs)
                    {
                        UpdateStudent.Parameters.AddWithValue(@"LongestStreak", studentLongestStreak8);
                    }
                    UpdateStudent.Parameters.AddWithValue(@"TotalDays", studentCurrentStreak8);
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
            if (i == 2)
            {
                if (checkBox3_Absent.Checked)
                {
                    return "Absent";
                }
                else if (checkBox3_Fail.Checked)
                {
                    return "Fail";
                }
                else if (checkBox3_Success.Checked)
                {
                    return "Success";
                }
            }
            if (i == 3)
            {
                if (checkBox4_Absent.Checked)
                {
                    return "Absent";
                }
                else if (checkBox4_Fail.Checked)
                {
                    return "Fail";
                }
                else if (checkBox4_Success.Checked)
                {
                    return "Success";
                }
            }
            if (i == 4)
            {
                if (checkBox5_Absent.Checked)
                {
                    return "Absent";
                }
                else if (checkBox5_Fail.Checked)
                {
                    return "Fail";
                }
                else if (checkBox5_Success.Checked)
                {
                    return "Success";
                }
            }
            if (i == 5)
            {
                if (checkBox6_Absent.Checked)
                {
                    return "Absent";
                }
                else if (checkBox6_Fail.Checked)
                {
                    return "Fail";
                }
                else if (checkBox6_Success.Checked)
                {
                    return "Success";
                }
            }
            if (i == 6)
            {
                if (checkBox7_Absent.Checked)
                {
                    return "Absent";
                }
                else if (checkBox7_Fail.Checked)
                {
                    return "Fail";
                }
                else if (checkBox7_Success.Checked)
                {
                    return "Success";
                }
            }
            if (i == 7)
            {
                if (checkBox8_Absent.Checked)
                {
                    return "Absent";
                }
                else if (checkBox8_Fail.Checked)
                {
                    return "Fail";
                }
                else if (checkBox8_Success.Checked)
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

        private void btn_SaveIndividual_Click(object sender, EventArgs e)
        {

            SqlCommand SaveStudent = new SqlCommand("insert into DailyStudentSuccess (studentid, start, end, date,type,intensity,other) values " +
                   "(@studentid,@start, @end,@date,@type,@intensity,@other)", cnn);
            SaveStudent.Parameters.AddWithValue(@"studentid", returnStudentID());
            SaveStudent.Parameters.AddWithValue(@"start", txt_Startofincident);
            SaveStudent.Parameters.AddWithValue(@"end", txt_endofincident);
            SaveStudent.Parameters.AddWithValue(@"date", DateTime.Now);
            SaveStudent.Parameters.AddWithValue(@"Type", comboBox2);
            SaveStudent.Parameters.AddWithValue(@"intensity", comboBox3);
            if (txt_Other.Visible == true)
            {
                SaveStudent.Parameters.AddWithValue(@"other", txt_Other);
            }
            SaveStudent.ExecuteNonQuery();
        }
        private string returnStudentID()
        {
            int index = comboBox1.SelectedIndex;
            if (index == 1)
            {
                return txt_Student1.Text;
            }
            else if (index == 2)
            {
                return txt_Student2.Text;
            }
            else if (index == 3)
            {
                return txt_Student3.Text;
            }
            else if (index == 4)
            {
                return txt_Student4.Text;
            }
            else if (index == 5)
            {
                return txt_Student5.Text;
            }
            else if (index == 6)
            {
                return txt_Student6.Text;
            }
            else if (index == 7)
            {
                return txt_Student7.Text;
            }
            else if (index == 8)
            {
                return txt_Student8.Text;
            }
            else
            {
                return "no Student";
            }

        }
    }
}
