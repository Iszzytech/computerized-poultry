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
    public partial class hatchery : UserControl
    {
        public hatchery()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String Name;
            String hatchDate;
            String staffReceived;
            String total;
            String hatchEgg;
            String survive;


            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing
            Name = textbox_name.Text;
            hatchDate = Hdate.Text;
            staffReceived = combo_staff.Text;
            total = textbox_total.Text;
            hatchEgg = textbox_hatched.Text;
            survive =textbox_survive.Text;



            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Please fill up this field", "Field Missing", btn, ico);
                textbox_name.Select();
                return;

            }
            ////////////////////////////--End of CustomerName Validation
            if (string.IsNullOrEmpty(total))
            {
                MessageBox.Show("Please fill up this field", "Field Missing", btn, ico);
                textbox_total.Select();
                return;

            }
            //////////////////////////////--End of MobileNumber Validation
            if (string.IsNullOrEmpty(hatchEgg))
            {
                MessageBox.Show("Please fill up this field", "Field Missing", btn, ico);
                textbox_hatched.Select();
                return;

            }



            ///////////////// INSERT CUSTOMER /////////////////////////
            string mySQL2 = string.Empty;

            mySQL2 += "INSERT INTO hatchery_tab (name, hatching_date, received_by, total, hatched, survived) ";
            mySQL2 += "VALUES ('" + Name + "','" + hatchDate + "','" + staffReceived + "','" + total + "','" + hatchEgg + "','" + survive + "')";


            Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
            MessageBox.Show("Hatchery record saved successfully ", "New Record Added", btn, MessageBoxIcon.Information);


            loadUserData();
            ClearControls();
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS recordID, name, hatching_date, received_by, total, hatched, survived FROM hatchery_tab");
            HdataGridView.DataSource = UserData;
            HdataGridView.Columns[0].HeaderText = "S/N";
            HdataGridView.Columns[1].HeaderText = "Name";
            HdataGridView.Columns[2].HeaderText = "Date";
            HdataGridView.Columns[3].HeaderText = "Staff";
            HdataGridView.Columns[4].HeaderText = "Total Hatched";
            HdataGridView.Columns[5].HeaderText = "Survivors";
            HdataGridView.Columns[0].Width = 50;
            HdataGridView.Columns[1].Width = 100;
            HdataGridView.Columns[2].Width = 100;
            HdataGridView.Columns[3].Width = 100;
            HdataGridView.Columns[4].Width = 100;
            HdataGridView.Columns[5].Width = 100;
           

        }

        private void ClearControls()
        {
            
            textbox_name.Text = "";
            textbox_total.Text = "";
            textbox_hatched.Text = "";
            textbox_survive.Text = "";

        }

        // -- Select Staff --

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

        private void hatchery_Load(object sender, EventArgs e)
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
                    ServerConnection.executeSQL("DELETE FROM hatchery_tab WHERE id = '" + HdataGridView.CurrentRow.Cells[0].Value + "' ");
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
