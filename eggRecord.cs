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
    public partial class eggRecord : UserControl
    {
        public eggRecord()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String totalEggProduced;
            String crackedEgg;
            String staffCharge;
            String doubleYolk;
            String dirty;
            String others;
            String egg_date;


            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing

             totalEggProduced = textbox_total.Text;
             crackedEgg = textbox_cracked.Text;
             staffCharge = combo_staff.Text;
             doubleYolk = textbox_doubleYolk.Text;
             dirty = textbox_dirtyeggs.Text;
             others = textbox_others.Text;
             egg_date = Edate.Text;
           


            if (string.IsNullOrEmpty(totalEggProduced))
            {
                MessageBox.Show("Please fill up this field", "Field Missing", btn, ico);
                textbox_total.Select();
                return;

            }
            ////////////////////////////--End of CustomerName Validation
            if (string.IsNullOrEmpty(crackedEgg))
            {
                MessageBox.Show("Please fill up this field", "Field Missing", btn, ico);
                textbox_cracked.Select();
                return;

            }
            //////////////////////////////--End of MobileNumber Validation
            if (string.IsNullOrEmpty(staffCharge))
            {
                MessageBox.Show("Please batch number", "Field Missing", btn, ico);
                combo_staff.Select();
                return;

            }



            ///////////////// INSERT CUSTOMER /////////////////////////
            string mySQL2 = string.Empty;

            mySQL2 += "INSERT INTO egg_tab (total_egg_produced, cracked_eggs, staff_in_charge, double_yolk, dirty, others, egg_date ) ";
            mySQL2 += "VALUES ('" + totalEggProduced + "','" + crackedEgg + "','" + staffCharge + "','" + doubleYolk + "','" + dirty + "','" + others + "','" + egg_date + "')";


            Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
            MessageBox.Show("Batch flock record saved successfully ", "New Staff Added", btn, MessageBoxIcon.Information);


            loadUserData();
            ClearControls();
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS recordID,total_egg_produced, cracked_eggs, staff_in_charge, double_yolk, dirty, others, egg_date FROM egg_tab");
            EdataGridView.DataSource = UserData;
            EdataGridView.Columns[0].HeaderText = "S/N";
            EdataGridView.Columns[1].HeaderText = "Total Egg Produced";
            EdataGridView.Columns[2].HeaderText = "Cracked Eggs";
            EdataGridView.Columns[3].HeaderText = "Staff in Charge";
            EdataGridView.Columns[4].HeaderText = "Double York";
            EdataGridView.Columns[5].HeaderText = "Dirty";
            EdataGridView.Columns[6].HeaderText = "Others";
            EdataGridView.Columns[7].HeaderText = "Date";
            EdataGridView.Columns[0].Width = 50;
            EdataGridView.Columns[1].Width = 100;
            EdataGridView.Columns[2].Width = 100;
            EdataGridView.Columns[3].Width = 100;
            EdataGridView.Columns[4].Width = 100;
            EdataGridView.Columns[5].Width = 100;
            EdataGridView.Columns[6].Width = 100;
            EdataGridView.Columns[7].Width = 100;

        }

        private void ClearControls()
        {
            textbox_total.Text = "";
           textbox_cracked.Text = "";
           textbox_doubleYolk.Text = "";
           textbox_dirtyeggs.Text = "";
           textbox_others.Text = "";
       

        }

        private void loadStaff()
        {
            combo_staff.SelectedItem = "-- Select Staff --";
            //// Load all expense type 
            DataTable ExpenseTypeData = ServerConnection.executeSQL("SELECT fullname FROM staff");

            foreach (DataRow dr in ExpenseTypeData.Rows)
            {
                combo_staff.Items.Add(dr["fullname"].ToString());
            }
        }

        private void eggRecord_Load(object sender, EventArgs e)
        {
            loadStaff();
            loadUserData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove record?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM egg_tab WHERE id = '" + EdataGridView.CurrentRow.Cells[0].Value + "' ");
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
