using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Behavior
{
    public partial class Teacher : Form
    {
        int i = 0;
        private void HideStuff()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label7.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            radio1_Absent.Visible = false;
            radio1_Fail.Visible = false;
            radio1_Success.Visible = false;
            radio2_Absent.Visible = false;
            radio2_Fail.Visible = false;
            radio2_Success.Visible = false;
            radio3_Absent.Visible = false;
            radio3_Fail.Visible = false;
            radio3_Success.Visible = false;
            radio4_Absent.Visible = false;
            radio4_Fail.Visible = false;
            radio4_Success.Visible = false;
            radio5_Absent.Visible = false;
            radio5_Fail.Visible = false;
            radio5_Success.Visible = false;
            radio6_Absent.Visible = false;
            radio6_Fail.Visible = false;
            radio6_Success.Visible = false;
            radio7_Absent.Visible = false;
            radio7_Fail.Visible = false;
            radio7_Success.Visible = false;
            radio8_Absent.Visible = false;
            radio8_Fail.Visible = false;
            radio8_Success.Visible = false;
        }

        public Teacher()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            HideStuff();
        }

        private void RadioButton()
        {
            if (radio1_Absent.Checked)
            {
                radio1_Fail.Checked = false;
                radio1_Success.Checked = false;
            }
            else if (radio1_Success.Checked)
            {
                radio1_Fail.Checked = false;
                radio1_Absent.Checked = false;
            }
            else if (radio1_Fail.Checked)
            {
                radio1_Success.Checked = false;
                radio1_Absent.Checked = false;
            }
            if (radio2_Absent.Checked)
            {
                radio2_Fail.Checked = false;
                radio2_Success.Checked = false;
            }
            else if (radio2_Success.Checked)
            {
                radio2_Fail.Checked = false;
                radio2_Absent.Checked = false;
            }
            else if (radio2_Fail.Checked)
            {
                radio2_Success.Checked = false;
                radio2_Absent.Checked = false;
            }
            if (radio3_Absent.Checked)
            {
                radio3_Fail.Checked = false;
                radio3_Success.Checked = false;
            }
            else if (radio3_Success.Checked)
            {
                radio3_Fail.Checked = false;
                radio3_Absent.Checked = false;
            }
            else if (radio3_Fail.Checked)
            {
                radio3_Success.Checked = false;
                radio3_Absent.Checked = false;
            }
            if (radio4_Absent.Checked)
            {
                radio4_Fail.Checked = false;
                radio4_Success.Checked = false;
            }
            else if (radio4_Success.Checked)
            {
                radio4_Fail.Checked = false;
                radio4_Absent.Checked = false;
            }
            else if (radio4_Fail.Checked)
            {
                radio4_Success.Checked = false;
                radio4_Absent.Checked = false;
            }
            if (radio5_Absent.Checked)
            {
                radio5_Fail.Checked = false;
                radio5_Success.Checked = false;
            }
            else if (radio5_Success.Checked)
            {
                radio5_Fail.Checked = false;
                radio5_Absent.Checked = false;
            }
            else if (radio5_Fail.Checked)
            {
                radio5_Success.Checked = false;
                radio5_Absent.Checked = false;
            }
            if (radio6_Absent.Checked)
            {
                radio6_Fail.Checked = false;
                radio6_Success.Checked = false;
            }
            else if (radio6_Success.Checked)
            {
                radio6_Fail.Checked = false;
                radio6_Absent.Checked = false;
            }
            else if (radio6_Fail.Checked)
            {
                radio6_Success.Checked = false;
                radio6_Absent.Checked = false;
            }
            if (radio7_Absent.Checked)
            {
                radio7_Fail.Checked = false;
                radio7_Success.Checked = false;
            }
            else if (radio7_Success.Checked)
            {
                radio7_Fail.Checked = false;
                radio7_Absent.Checked = false;
            }
            else if (radio7_Fail.Checked)
            {
                radio7_Success.Checked = false;
                radio7_Absent.Checked = false;
            }
            if (radio8_Absent.Checked)
            {
                radio8_Fail.Checked = false;
                radio8_Success.Checked = false;
            }
            else if (radio8_Success.Checked)
            {
                radio8_Fail.Checked = false;
                radio8_Absent.Checked = false;
            }
            else if (radio8_Fail.Checked)
            {
                radio8_Success.Checked = false;
                radio8_Absent.Checked = false;
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
                
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT first_name,last_name FROM Student WHERE teacher = 'Corey'",cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                while (reader.Read())
                {
                    i++;
                    switch (i)
                    {
                        case 1:
                            {
                                label1.Text = reader["first_name"].ToString() + reader["last_name"].ToString();
                                label1.Visible = true;
                                radio1_Absent.Visible = true;
                                radio1_Fail.Visible = true;
                                radio1_Success.Visible = true;
                            }
                            break;
                        case 2:
                            {
                                label2.Text = reader["first_name"].ToString() + reader["last_name"].ToString();
                                label2.Visible = true;
                                radio2_Absent.Visible = true;
                                radio2_Fail.Visible = true;
                                radio2_Success.Visible = true;
                            }
                            break;
                        case 3:
                            {
                                label3.Text = reader["first_name"].ToString() + reader["last_name"].ToString();
                                label3.Visible = true;
                                radio3_Absent.Visible = true;
                                radio3_Fail.Visible = true;
                                radio3_Success.Visible = true;
                            }
                            break;
                        case 4:
                            {
                                label4.Text = reader["first_name"].ToString() + reader["last_name"].ToString();
                                label4.Visible = true;
                                radio4_Absent.Visible = true;
                                radio4_Fail.Visible = true;
                                radio4_Success.Visible = true;
                            }
                            break;
                        case 5:
                            {
                                label5.Text = reader["first_name"].ToString() + reader["last_name"].ToString();
                                label5.Visible = true;
                                radio5_Absent.Visible = true;
                                radio5_Fail.Visible = true;
                                radio5_Success.Visible = true;
                            }
                            break;
                        case 6:
                            {
                                label6.Text = reader["first_name"].ToString() + reader["last_name"].ToString();
                                label6.Visible = true;
                                radio6_Absent.Visible = true;
                                radio6_Fail.Visible = true;
                                radio6_Success.Visible = true;
                            }
                            break;
                        case 7:
                            {
                                label7.Text = reader["first_name"].ToString() + reader["last_name"].ToString();
                                label7.Visible = true;
                                radio7_Absent.Visible = true;
                                radio7_Fail.Visible = true;
                                radio7_Success.Visible = true;
                            }
                            break;
                        case 8:
                            {
                                label8.Text = reader["first_name"].ToString() + reader["last_name"].ToString();
                                label8.Visible = true;
                                radio8_Absent.Visible = true;
                                radio8_Fail.Visible = true;
                                radio8_Success.Visible = true;
                            }
                            break;
                        default:
                            break;
                    }
                }
                i = 0;
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
    }
}
