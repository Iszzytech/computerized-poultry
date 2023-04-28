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
    public partial class Expense_Record : UserControl
    {
        public Expense_Record()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            String expCat;
            String Amount;
            String Desc;
            String Exdate;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;

            // initializing variables declared
            expCat = combobox_exp.Text;
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

            if(string.IsNullOrEmpty(expCat))
            {
                MessageBox.Show("Please select expense category", "Field Missing", btn, ico);
                combobox_exp.Select();
                return;
            }


            ///////////////// INSERT CUSTOMER /////////////////////////
            string mySQL2 = string.Empty;

            mySQL2 += "INSERT INTO expenseRecord (exp_cat, description, date, amount) ";
            mySQL2 += "VALUES ('" + expCat + "','" + Desc + "','" + Exdate + "','" + Amount + "')";

            Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
            MessageBox.Show("Record Saved successfully ", "New Expense Record Added", btn, MessageBoxIcon.Information);


            loadUserData();
            ClearControls();

        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS count, exp_cat, description, date, amount FROM expenseRecord");
            Edatagridview.DataSource = UserData;
            Edatagridview.Columns[0].HeaderText = "S/N";
            Edatagridview.Columns[1].HeaderText = "Expense Category";
            Edatagridview.Columns[2].HeaderText = "Description";
            Edatagridview.Columns[3].HeaderText = "Date";
            Edatagridview.Columns[4].HeaderText = "Amount";
           
            Edatagridview.Columns[0].Width = 50;
            Edatagridview.Columns[1].Width = 100;
            Edatagridview.Columns[2].Width = 100;
            Edatagridview.Columns[3].Width = 100;
            Edatagridview.Columns[4].Width = 100;
          


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
                if (MessageBox.Show("Do you want to permanently remove expense record?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM expenseRecord WHERE id = '" + Edatagridview.CurrentRow.Cells[0].Value + "' ");
                    loadUserData();
                    MessageBox.Show("Expense record Has Been Deleted Successfully", "Expense Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Expense_Record_Load(object sender, EventArgs e)
        {
            loadUserData();
            expCategory();
        }

        //-- Select Expense Category --
        private void expCategory()
        {
            combobox_exp.SelectedItem = "-- Select Expense Category --";
            //// Load all expense type 
            DataTable ExpenseTypeData = ServerConnection.executeSQL("SELECT expense_cat FROM expenseCat_tab");

            foreach (DataRow dr in ExpenseTypeData.Rows)
            {
                combobox_exp.Items.Add(dr["expense_cat"].ToString());
            }
        }
    }
}
