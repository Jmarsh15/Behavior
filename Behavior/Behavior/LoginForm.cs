using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavior
{
    public partial class LoginForm : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=behaviordatabase.cfzuumxbilpn.us-east-2.rds.amazonaws.com," + "1433;Initial Catalog=Login;User ID=BehaviorTest;Password=jL55hrHErQMD");
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string access = "";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT access FROM Login WHERE Username=@uname and Password=@pass", cnn);
            cmd.Parameters.AddWithValue("@uname", txt_username.Text);
            cmd.Parameters.AddWithValue("@pass", txt_password.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                access = reader["access"].ToString();
            }
            if (access == "1")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();

            }
            else
            {
                Teacher te = new Teacher();
                te.Show();
                this.Hide();
            }
            cnn.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //enter your code for forget password case 
            MessageBox.Show("Under development");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Enter your code for registration form of your choice 
            MessageBox.Show("Under development");
        }
        class Login
        {
            //decalre properties 
            public string Username { get; set; }
            public string Userpassword { get; set; }

            //intialise  
            public Login(string user, string pass)
            {
                this.Username = user;
                this.Userpassword = pass;
            }
            //validate string 
            private bool StringValidator(string input)
            {
                string pattern = "[^a-zA-Z]";
                if (Regex.IsMatch(input, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //validate integer 
            private bool IntegerValidator(string input)
            {
                string pattern = "[^0-9]";
                if (Regex.IsMatch(input, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //clear user inputs 
            private void ClearTexts(string user, string pass)
            {
                user = String.Empty;
                pass = String.Empty;
            }
            //method to check if eligible to be logged in 
            internal bool IsLoggedIn(string user, string pass)
            {
                //check user name empty 
                if (string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Enter the user name!");
                    return false;

                }
                //check user name is valid type 
                else if (StringValidator(user) == true)
                {
                    MessageBox.Show("Enter only text here");
                    ClearTexts(user, pass);
                    return false;
                }
                //check user name is correct 
                else
                {
                    if (Username != user)
                    {
                        MessageBox.Show("User name is incorrect!");
                        ClearTexts(user, pass);
                        return false;
                    }
                    //check password is empty 
                    else
                    {
                        if (string.IsNullOrEmpty(pass))
                        {
                            MessageBox.Show("Enter the passowrd!");
                            return false;
                        }
                        //check password is valid 
                        else if (IntegerValidator(pass) == true)
                        {
                            MessageBox.Show("Enter only integer here");
                            return false;
                        }
                        //check password is correct 
                        else if (Userpassword != pass)
                        {
                            MessageBox.Show("Password is incorrect");
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
