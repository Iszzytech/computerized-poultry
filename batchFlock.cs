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
    public partial class batchFlock : UserControl
    {
        public batchFlock()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String breedType;
            String total;
            String batchNo;
            String expired;
            String laying;
            String fileDate;
            

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing
            breedType = combobox_breedType.Text;
            total = textbox_total.Text;
            batchNo = textbox_batchNo.Text;
            expired = combo_expired.Text;
            laying = combo_laying.Text;
            fileDate = Bdate.Text;
           


            if (string.IsNullOrEmpty(breedType))
            {
                MessageBox.Show("Please select breed type", "Field Missing", btn, ico);
               combobox_breedType.Select();
                return;

            }
            ////////////////////////////--End of CustomerName Validation
            if (string.IsNullOrEmpty(total))
            {
                MessageBox.Show("Please enter total breed", "Field Missing", btn, ico);
                textbox_total.Select();
                return;

            }
            //////////////////////////////--End of MobileNumber Validation
            if (string.IsNullOrEmpty(batchNo))
            {
                MessageBox.Show("Please batch number", "Field Missing", btn, ico);
                textbox_batchNo.Select();
                return;

            }


           
                ///////////////// INSERT CUSTOMER /////////////////////////
                string mySQL2 = string.Empty;

                mySQL2 += "INSERT INTO batch_flock (breed_type, total, batch_no, expired, laying, batch_date ) ";
                mySQL2 += "VALUES ('" + breedType + "','" + total + "','" + batchNo + "','" + expired + "','" + laying + "','" + fileDate + "')";
              

                Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
                MessageBox.Show("Batch flock record saved successfully ", "New Staff Added", btn, MessageBoxIcon.Information);


                 loadUserData();
                 ClearControls();
            
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS recordID, breed_type, total, batch_no, expired, laying, batch_date FROM batch_flock");
            BdataGridView.DataSource = UserData;
            BdataGridView.Columns[0].HeaderText = "S/N";
            BdataGridView.Columns[1].HeaderText = "Breed Type";
            BdataGridView.Columns[2].HeaderText = "Total";
            BdataGridView.Columns[3].HeaderText = "Batch No";
            BdataGridView.Columns[4].HeaderText = "Expired";
            BdataGridView.Columns[5].HeaderText = "Laying";
            BdataGridView.Columns[6].HeaderText = "Date";
            BdataGridView.Columns[0].Width = 50;
            BdataGridView.Columns[1].Width = 100;
            BdataGridView.Columns[2].Width = 100;
            BdataGridView.Columns[3].Width = 100;
            BdataGridView.Columns[4].Width = 100;
            BdataGridView.Columns[5].Width = 100;
            BdataGridView.Columns[6].Width = 100;

        }

        private void batchFlock_Load(object sender, EventArgs e)
        {
            combo_expired.SelectedItem = "No";
            combo_laying.SelectedItem = "No";
            loadUserData();
            loadBreed();
        }

        private void loadBreed()
        {
            combobox_breedType.SelectedItem = "-- Select Breed Type --";
            //// Load all expense type 
            DataTable ExpenseTypeData = ServerConnection.executeSQL("SELECT breed_type FROM breed_tab");

            foreach (DataRow dr in ExpenseTypeData.Rows)
            {
                combobox_breedType.Items.Add(dr["breed_type"].ToString());
            }
        }


        private void ClearControls()
        {
             
             textbox_total.Text = "";
            textbox_batchNo.Text = "";
           
                  }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove record?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM batch_flock WHERE id = '" + BdataGridView.CurrentRow.Cells[0].Value + "' ");
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
