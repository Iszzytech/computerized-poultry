using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computerized_Poultry_Farm.connection;

namespace Computerized_Poultry_Farm
{
    public partial class staff : UserControl
    {
        public staff()
        {
            InitializeComponent();
        }

        private void staff_Load(object sender, EventArgs e)
        {
       combobox_staff.SelectedItem = "--Select Staff Category --";
            loadUserData();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            String custname;
            String mobile;
            String address;
            String staffCat;
            String salary;
            String email;
            String password;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing
            custname = textbox_fullname.Text;
            mobile = textbox_phoneno.Text;
            address = textbox_address.Text;
            staffCat = combobox_staff.Text;
            salary = textbox_salary.Text;
            email = textbox_email.Text;
            password = textbox_password.Text;
 

            if (string.IsNullOrEmpty(custname))
            {
                MessageBox.Show("Please enter the staff name", "Field Missing", btn, ico);
                textbox_fullname.Select();
                return;

            }
            ////////////////////////////--End of CustomerName Validation
            if (string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Please enter mobile number", "Field Missing", btn, ico);
                textbox_phoneno.Select();
                return;

            }
            //////////////////////////////--End of MobileNumber Validation
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter address", "Field Missing", btn, ico);
                textbox_address.Select();
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
                ///////////////// INSERT CUSTOMER /////////////////////////
                string mySQL2 = string.Empty;

                mySQL2 += "INSERT INTO staff (staffDesignation, fullname, address, phoneno, salary) ";
                mySQL2 += "VALUES ('" + staffCat + "','" + custname + "','" + address + "','" + mobile + "','" + salary + "')";
                mySQL2 += "INSERT INTO users (fullname, password, email)";
                mySQL2 += "VALUES ('" + custname + "','" + password + "','" + email + "')";

                Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
                MessageBox.Show("Staff Saved successfully ", "New Staff Added", btn, MessageBoxIcon.Information);


                loadUserData();
                ClearControls();
            }
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (staffDesignation) AS StaffCat, fullname, address, phoneno, salary FROM staff");
            CustdataGridView.DataSource = UserData;
            CustdataGridView.Columns[0].HeaderText = "Staff Status";
            CustdataGridView.Columns[1].HeaderText = "Name";
            CustdataGridView.Columns[2].HeaderText = "Address";
            CustdataGridView.Columns[3].HeaderText = "Phone No";
            CustdataGridView.Columns[4].HeaderText = "Salary";
            CustdataGridView.Columns[0].Width = 50;
            CustdataGridView.Columns[1].Width = 220;
            CustdataGridView.Columns[2].Width = 220;
            CustdataGridView.Columns[3].Width = 220;
            CustdataGridView.Columns[4].Width = 220;


        }

        private void ClearControls()
        {
            textbox_fullname.Text = "";
            textbox_phoneno.Text = "";
            textbox_address.Text = "";
            textbox_salary.Text = "";
            textbox_password.Text = "";
            textbox_email.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove customer?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM staff WHERE phoneno = '" + CustdataGridView.CurrentRow.Cells[3].Value + "' ");
                    loadUserData();
                    MessageBox.Show("Staff Has Been Deleted Successfully", "Staff Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured Please Restart The Program", "Failed Unexpectedly", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
