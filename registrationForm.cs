using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computerized_Poultry_Farm
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void removeBG(PictureBox pb, PictureBox pb2)
        {

            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;


        }

        

        private void registrationForm_Load(object sender, EventArgs e)
        {
            removeBG(txtIcon, icon);
            removeBG(txtIcon2, icon2);
            removeBG(txtIcon3, icon3);
            removeBG(txtIcon4, icon4);

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            registrationForm regForm = new registrationForm();
            this.Hide();
            loginForm.ShowDialog();
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            String fullname;
            String email;
            String password;
            String cpassword;
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;

            // Initializing
            
            fullname = textbox_fullname.Text;
            email = textbox_email.Text;
            password = textbox_password.Text;
            cpassword = textbox_cpassword.Text;

            if (string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Please enter your full name", "Field Missing", btn, ico);
                textbox_fullname.Select();
                return;

            }
            ////////////////////////////--End of FirstName Validation
           
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email", "Field Missing", btn, ico);
                textbox_email.Select();
                return;

            }
            //////////////////////////--End of Email Validation
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password", "Field Missing", btn, ico);
                textbox_password.Select();
                return;

            }
            ///////////////////////--End of Password Validation
            if (string.IsNullOrEmpty(cpassword))
            {
                MessageBox.Show("Please enter your computer password", "Field Missing", btn, ico);
                textbox_cpassword.Select();
                return;

            }

            if (cpassword != password)
            {
                MessageBox.Show("Password and Confirm password not correct", "Incorrect Input", btn, ico);
                textbox_cpassword.Select();
                return;
            }


            //----------------------- TO CHECK IF USER EXIST --------------------
            string mySQL = "SELECT email FROM users WHERE email = '" + email + "'";
            DataTable checkDuplicates = Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("Email Already Exist ", "Please try using another email", btn, ico);
                textbox_email.SelectAll();
                return;
            }
            else
            {
                string mySQL2 = string.Empty;

                mySQL2 += "INSERT INTO users (fullname, email, password) ";
                mySQL2 += "VALUES ('" + fullname + "','" + email + "','" + password + "')";

               Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
                MessageBox.Show("User registered successfully ", "Go to login page", btn, MessageBoxIcon.Information);
            }
        }

        private void textbox_fullname_Enter(object sender, EventArgs e)
        {
            if (textbox_fullname.Text == "Fullname")
            {
                textbox_fullname.Text = "";
                textbox_fullname.ForeColor = System.Drawing.ColorTranslator.FromHtml("#13141F");
            }
        }

        private void textbox_fullname_Leave(object sender, EventArgs e)
        {
            if (textbox_fullname.Text == "")
            {
                textbox_fullname.Text = "Fullname";
                textbox_fullname.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A9A9A9");
            }
        }

        private void textbox_password_Enter(object sender, EventArgs e)
        {
            if (textbox_password.Text == "Password")
            {
                textbox_password.Text = "";
                textbox_password.ForeColor = System.Drawing.ColorTranslator.FromHtml("#13141F");

            }
        }

        private void textbox_password_Leave(object sender, EventArgs e)
        {
            if (textbox_password.Text == "")
            {
                textbox_password.Text = "Password";
                textbox_password.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A9A9A9");
            }
        }

        private void showPass_OnChange(object sender, EventArgs e)
        {
            if (showPass.Checked == false)

            {
                textbox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textbox_password.UseSystemPasswordChar = true;
            }
        }

        private void textbox_cpassword_Enter(object sender, EventArgs e)
        {
            if (textbox_cpassword.Text == "Confirm Password")
            {
                textbox_cpassword.Text = "";
                textbox_cpassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#13141F");

            }
        }

        private void textbox_cpassword_Leave(object sender, EventArgs e)
        {
            if (textbox_password.Text == "")
            {
                textbox_password.Text = "Confirm Password";
                textbox_password.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A9A9A9");
            }
        }

        private void textbox_email_Enter(object sender, EventArgs e)
        {
            if (textbox_email.Text == "Email")
            {
                textbox_email.Text = "";
                textbox_email.ForeColor = System.Drawing.ColorTranslator.FromHtml("#13141F");
            }

        }

        private void textbox_email_Leave(object sender, EventArgs e)
        {
            if (textbox_email.Text == "")
            {
                textbox_email.Text = "Email";

                textbox_email.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A9A9A9");
            }

            //////////////////////////////////////--EMAIL VALIDATION
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_email.Text, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
            {
                errorProvider1.Clear();
                pictureBox5.Enabled = true;


            }
            else
            {

                errorProvider1.SetError(this.textbox_email, "Please provide a valid email!");
                pictureBox5.Enabled = false;
            }
        }
    }
}
