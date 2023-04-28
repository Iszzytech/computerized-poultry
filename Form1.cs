using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computerized_Poultry_Farm.connection;

namespace Computerized_Poultry_Farm
{
    public partial class Form1 : Form
    {
        public static string getEmail;
        public static string getSession;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            removeBG(txtIcon, icon);
            removeBG(txtIcon2, icon2);
            
            
           

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

        }

        void removeBG(PictureBox pb, PictureBox pb2) {

            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;


        }

        private void label4_Click(object sender, EventArgs e)
        {
            registrationForm regForm = new registrationForm();
            this.Hide();
            regForm.ShowDialog();
            


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textbox_email.Text == "Email Address")
            {
                textbox_email.Text = "";
                textbox_email.ForeColor = System.Drawing.ColorTranslator.FromHtml("#13141F");
            }
        }

        private void textbox_email_Leave(object sender, EventArgs e)
        {
            if (textbox_email.Text == "")
            {
                textbox_email.Text = "Email Address";
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            String email = textbox_email.Text;
            String passW = textbox_password.Text;




            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(passW))
            {
                string mySQL = string.Empty;

                mySQL += "SELECT * FROM users ";
                mySQL += "WHERE email = '" + email + "'";
                mySQL += "AND password = '" + passW + "'";

                DataTable userData = ServerConnection.executeSQL(mySQL);

                if (userData.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful", "Redirecting to Dashboard");
                    getEmail = textbox_email.Text;
                    indicator.Text = "S";
                    getSession = indicator.Text;

                    this.Hide();
                    dashboard dash = new dashboard();
                    dash.Show();
                }
                else if (email == "admin@admin.com")
                {

                    if (passW == "admin123")
                    {
                        MessageBox.Show("Login successful", "Redirecting to Dashboard");
                        indicator.Text = "A";
                        getSession = indicator.Text;
                        this.Hide();
                        dashboard dash = new dashboard();
                        dash.Show();

                    }

                }
            
            else
            {
                MessageBox.Show("Email or Password is incorrect", "Try again!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox_password.Focus();
                textbox_password.SelectAll();

            }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(picBox, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
        }

        private void icon_Click(object sender, EventArgs e)
        {

        }
    }
}
