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
    public partial class incomeCat : Form
    {
        public incomeCat()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String incomeType;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing
            incomeType = textbox_incomeType.Text;


            if (string.IsNullOrEmpty(incomeType))
            {
                MessageBox.Show("Please enter the income category", "Field Missing", btn, ico);
                textbox_incomeType.Select();
                return;

            }


            ///////////////// INSERT CUSTOMER /////////////////////////
            string mySQL2 = string.Empty;

            mySQL2 += "INSERT INTO incomeCat_tab (income_cat) ";
            mySQL2 += "VALUES ('" + incomeType + "')";


            Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
            MessageBox.Show("Income Category Saved Successfully ", "New Record Added", btn, MessageBoxIcon.Information);


            loadUserData();
            ClearControls();
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS count, income_cat FROM incomeCat_tab");
            IdataGridView.DataSource = UserData;
            IdataGridView.Columns[0].HeaderText = "S/N";
            IdataGridView.Columns[1].HeaderText = "Income Category";

            IdataGridView.Columns[0].Width = 50;
            IdataGridView.Columns[1].Width = 220;


        }

        private void ClearControls()
        {
            textbox_incomeType.Text = "";

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove data?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM incomeCat_tab WHERE id = '" + IdataGridView.CurrentRow.Cells[0].Value + "' ");
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

        private void incomeCat_Load(object sender, EventArgs e)
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
