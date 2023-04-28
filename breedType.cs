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
    public partial class breedType : UserControl
    {
        public breedType()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String breedType;
           
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing
            breedType = textbox_breedtype.Text;
           

            if (string.IsNullOrEmpty(breedType))
            {
                MessageBox.Show("Please enter the breed type", "Field Missing", btn, ico);
                textbox_breedtype.Select();
                return;

            }
           
           
                ///////////////// INSERT CUSTOMER /////////////////////////
                string mySQL2 = string.Empty;

                mySQL2 += "INSERT INTO breed_tab (breed_type) ";
                mySQL2 += "VALUES ('" + breedType + "')";
              

                Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
                MessageBox.Show("Breed type Saved successfully ", "New Record Added", btn, MessageBoxIcon.Information);


                loadUserData();
                ClearControls();
           
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS count, breed_type FROM breed_tab");
            CustdataGridView.DataSource = UserData;
            CustdataGridView.Columns[0].HeaderText = "S/N";
            CustdataGridView.Columns[1].HeaderText = "Breed Type";
           
            CustdataGridView.Columns[0].Width = 50;
            CustdataGridView.Columns[1].Width = 220;
         


        }

        private void ClearControls()
        {
            textbox_breedtype.Text = "";
                    
        }

        private void breedType_Load(object sender, EventArgs e)
        {
            loadUserData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Do you want to permanently remove file?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM breed_type WHERE id = '" + CustdataGridView.CurrentRow.Cells[0].Value + "' ");
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
    }
}
