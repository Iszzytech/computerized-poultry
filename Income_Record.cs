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
    public partial class Income_Record : UserControl
    {
        public Income_Record()
        {
            InitializeComponent();
        }

        private void Income_Record_Load(object sender, EventArgs e)
        {
            //--Select Income Category --
            loadUserData();
            incCategory();

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            String incCat;
            String Amount;
            String Desc;
            String Exdate;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;

            // initializing variables declared
            incCat = combobox_inc.Text;
            Amount = textbox_amount.Text;
            Desc = textbox_desc.Text;
            Exdate = Edate.Text;

            if (string.IsNullOrEmpty(Desc))
            {
                MessageBox.Show("Please enter description", "Field Missing", btn, ico);
                textbox_desc.Select();
                return;

            }
            ////////////////////////////--End of CustomerName Validation
            if (string.IsNullOrEmpty(Amount))
            {
                MessageBox.Show("Please enter amount", "Field Missing", btn, ico);
                textbox_amount.Select();
                return;

            }

            if (string.IsNullOrEmpty(incCat))
            {
                MessageBox.Show("Please select income category", "Field Missing", btn, ico);
                combobox_inc.Select();
                return;
            }


            ///////////////// INSERT CUSTOMER /////////////////////////
            string mySQL2 = string.Empty;

            mySQL2 += "INSERT INTO incomeRecord (inc_cat, description, date, amount) ";
            mySQL2 += "VALUES ('" + incCat + "','" + Desc + "','" + Exdate + "','" + Amount + "')";

            Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
            MessageBox.Show("Record Saved successfully ", "New Income Record Added", btn, MessageBoxIcon.Information);


            loadUserData();
            ClearControls();
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS count, inc_cat, description, date, amount FROM incomeRecord");
            Idatagridview.DataSource = UserData;
            Idatagridview.Columns[0].HeaderText = "S/N";
            Idatagridview.Columns[1].HeaderText = "Income Category";
            Idatagridview.Columns[2].HeaderText = "Description";
            Idatagridview.Columns[3].HeaderText = "Date";
            Idatagridview.Columns[4].HeaderText = "Amount";

            Idatagridview.Columns[0].Width = 50;
            Idatagridview.Columns[1].Width = 100;
            Idatagridview.Columns[2].Width = 100;
            Idatagridview.Columns[3].Width = 100;
            Idatagridview.Columns[4].Width = 100;

        }

        private void ClearControls()
        {
            textbox_desc.Text = "";
            textbox_amount.Text = "";

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove income record?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM incomeRecord WHERE id = '" + Idatagridview.CurrentRow.Cells[0].Value + "' ");
                    loadUserData();
                    MessageBox.Show("Income record Has Been Deleted Successfully", "Income Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void incCategory()
        {
            combobox_inc.SelectedItem = "-- Select Income Category --";
            //// Load all expense type 
            DataTable ExpenseTypeData = ServerConnection.executeSQL("SELECT income_cat FROM incomeCat_tab");

            foreach (DataRow dr in ExpenseTypeData.Rows)
            {
                combobox_inc.Items.Add(dr["income_cat"].ToString());
            }
        }
    }
}
