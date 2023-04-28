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
    public partial class expense_cat : Form
    {
        public expense_cat()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String expenseType;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing
            expenseType = textbox_expenseType.Text;


            if (string.IsNullOrEmpty(expenseType))
            {
                MessageBox.Show("Please enter the expense category", "Field Missing", btn, ico);
                textbox_expenseType.Select();
                return;

            }


            ///////////////// INSERT CUSTOMER /////////////////////////
            string mySQL2 = string.Empty;

            mySQL2 += "INSERT INTO expenseCat_tab (expense_cat) ";
            mySQL2 += "VALUES ('" + expenseType + "')";


            Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
            MessageBox.Show("Expense Category Saved Successfully ", "New Record Added", btn, MessageBoxIcon.Information);


            loadUserData();
            ClearControls();
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS count, expense_cat FROM expenseCat_tab");
            EdataGridView.DataSource = UserData;
            EdataGridView.Columns[0].HeaderText = "S/N";
            EdataGridView.Columns[1].HeaderText = "Expense Category";

            EdataGridView.Columns[0].Width = 50;
            EdataGridView.Columns[1].Width = 220;


        }

        private void ClearControls()
        {
            textbox_expenseType.Text = "";

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove data?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM expenseCat_tab WHERE id = '" + EdataGridView.CurrentRow.Cells[0].Value + "' ");
                    loadUserData();
                    MessageBox.Show("Record Has Been Deleted Successfully", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void expense_cat_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            loadUserData();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
