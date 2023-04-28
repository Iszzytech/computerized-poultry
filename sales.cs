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
    public partial class sales : UserControl
    {
        public sales()
        {
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            loadUserData();
            loadCustomer();
            loadStaff();
        }

        private void loadCustomer()
        {
            combobox_cust.SelectedItem = "-- Select Customer --";
            //// Load all expense type 
            DataTable ExpenseTypeData = ServerConnection.executeSQL("SELECT fullname FROM customer_tab");

            foreach (DataRow dr in ExpenseTypeData.Rows)
            {
                combobox_cust.Items.Add(dr["fullname"].ToString());
            }
        }

        private void loadStaff()
        {
            combobox_staff.SelectedItem = "-- Select Staff --";
            //// Load all expense type 
            DataTable ExpenseTypeData = ServerConnection.executeSQL("SELECT fullname FROM staff");

            foreach (DataRow dr in ExpenseTypeData.Rows)
            {
                combobox_staff.Items.Add(dr["fullname"].ToString());
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            String custname;
            String desc;
            String Sdates;
            String staffReceive;
            String amount;
            String paid;
            String balance;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing
            custname = combobox_cust.Text;
            desc = textbox_desc.Text;
            Sdates = Sdate.Text;
            staffReceive = combobox_staff.Text;
            amount = textbox_amount.Text;
            paid = textbox_paid.Text;
            balance = textbox_balance.Text;


            if (string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Please enter description", "Field Missing", btn, ico);
                textbox_desc.Select();
                return;

            }
            ////////////////////////////--End of CustomerName Validation
            if (string.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Please enter amount", "Field Missing", btn, ico);
                textbox_amount.Select();
                return;

            }
            //////////////////////////////--End of MobileNumber Validation
            if (string.IsNullOrEmpty(paid))
            {
                MessageBox.Show("Please enter paid fee", "Field Missing", btn, ico);
                textbox_paid.Select();
                return;

            }

                ///////////////// INSERT CUSTOMER /////////////////////////
                string mySQL2 = string.Empty;

                mySQL2 += "INSERT INTO sales (customer, description, date_received, received_by, amount, paid, balance) ";
                mySQL2 += "VALUES ('" + custname + "','" + desc + "','" + Sdates + "','" + staffReceive+ "','" + amount + "','" + paid + "','" + balance + "')";

                Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
                MessageBox.Show("Sales Saved successfully ", "New Sale Record Added", btn, MessageBoxIcon.Information);


                loadUserData();
                ClearControls();
           
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (order_no) AS count, customer, description, date_received, received_by, amount, paid, balance FROM sales");
            Sdatagridview.DataSource = UserData;
            Sdatagridview.Columns[0].HeaderText = "Order No";
            Sdatagridview.Columns[1].HeaderText = "Customer";
            Sdatagridview.Columns[2].HeaderText = "Description";
            Sdatagridview.Columns[3].HeaderText = "Date";
            Sdatagridview.Columns[4].HeaderText = "Received By Staff ";
            Sdatagridview.Columns[5].HeaderText = "Amount ";
            Sdatagridview.Columns[6].HeaderText = "Paid ";
            Sdatagridview.Columns[7].HeaderText = "Balance";
            Sdatagridview.Columns[0].Width = 50;
            Sdatagridview.Columns[1].Width = 100;
            Sdatagridview.Columns[2].Width = 100;
            Sdatagridview.Columns[3].Width = 100;
            Sdatagridview.Columns[4].Width = 100;
            Sdatagridview.Columns[5].Width = 100;
            Sdatagridview.Columns[6].Width = 100;
            Sdatagridview.Columns[7].Width = 100;


        }

        private void ClearControls()
        {
            textbox_desc.Text = "";
            textbox_amount.Text = "";
            textbox_paid.Text = "";
            textbox_balance.Text = "";
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove sales record?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM sales WHERE order_no = '" + Sdatagridview.CurrentRow.Cells[0].Value + "' ");
                    loadUserData();
                    MessageBox.Show("Sales record Has Been Deleted Successfully", "Sales Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textbox_paid_Leave(object sender, EventArgs e)
        {
            int amount;
            int paid;
            int balance;

            try
            {
                amount = Convert.ToInt32(textbox_amount.Text);
                paid = Convert.ToInt32(textbox_paid.Text);
                balance = amount - paid;
                textbox_balance.Text = balance.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Only Integer is allowed in this field");
            }
        }

        private void textbox_paid_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
