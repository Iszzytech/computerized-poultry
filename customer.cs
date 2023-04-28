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
    public partial class customer : UserControl
    {
        public customer()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            String custname;
            String mobile;
            String address;
            String sex;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing
            custname = textbox_fullname.Text;
            mobile = textbox_phoneno.Text;
            address = textbox_address.Text;
            sex = combobox_sex.Text;


            if (string.IsNullOrEmpty(custname))
            {
                MessageBox.Show("Please enter the customer name", "Field Missing", btn, ico);
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

            //----------------------- TO CHECK IF CUSTOMER EXIST --------------------
            string mySQL = "SELECT phone_no FROM customer_tab WHERE phone_no = '" + mobile + "'";
            DataTable checkDuplicates = Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("Mobile Number Already Exist ", "Please try using another number", btn, ico);
                textbox_phoneno.SelectAll();
                return;
            }
            else
            {
                ///////////////// INSERT CUSTOMER /////////////////////////
                string mySQL2 = string.Empty;

                mySQL2 += "INSERT INTO customer_tab (fullname, address, phone_no, sex) ";
                mySQL2 += "VALUES ('" + custname + "','" + address + "','" + mobile + "','" + sex + "')";

               Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
                MessageBox.Show("Customer Saved successfully ", "New Customer Added", btn, MessageBoxIcon.Information);


                loadUserData();
                ClearControls();
            }
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (fullname) AS CustomerName, phone_no, address FROM customer_tab");
            CustdataGridView.DataSource = UserData;
            CustdataGridView.Columns[0].HeaderText = "Customer Name";
            CustdataGridView.Columns[1].HeaderText = "Mobile Number";
            CustdataGridView.Columns[2].HeaderText = "Address";
            CustdataGridView.Columns[0].Width = 220;
            CustdataGridView.Columns[1].Width = 220;
            CustdataGridView.Columns[2].Width = 220;


        }

        private void ClearControls()
        {
            textbox_fullname.Text = "";
            textbox_phoneno.Text = "";
            textbox_address.Text = "";
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove customer?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM customer_tab WHERE phone_no = '" + CustdataGridView.CurrentRow.Cells[1].Value + "' ");
                    loadUserData();
                    MessageBox.Show("Customer Has Been Deleted Successfully", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void customer_Load(object sender, EventArgs e)
        {
            loadUserData();
        }
    }
}
