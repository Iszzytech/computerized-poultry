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
    public partial class Vaccination : UserControl
    {
        public Vaccination()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Vaccination_Load(object sender, EventArgs e)
        {
            loadStaff();
            loadVaccine();
            loadUserData();

        }

        private void textbox_phoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadStaff()
        {
            textbox_staff.SelectedItem = "-- Select Staff --";
            //// Load all expense type 
            DataTable ExpenseTypeData = ServerConnection.executeSQL("SELECT fullname FROM staff");

            foreach (DataRow dr in ExpenseTypeData.Rows)
            {
                textbox_staff.Items.Add(dr["fullname"].ToString());
            }
        }

        //--Select Vaccine --

        private void loadVaccine()
        {
            combo_vaccine.SelectedItem = "--Select Vaccine --";
            //// Load all expense type 
            DataTable ExpenseTypeData = ServerConnection.executeSQL("SELECT name FROM vac_medicine");

            foreach (DataRow dr in ExpenseTypeData.Rows)
            {
                combo_vaccine.Items.Add(dr["name"].ToString());
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String vaccine;
            String reaction;
            String dateV;
            String staffN;
            String others;
            String Name;


            vaccine = combo_vaccine.Text;
            reaction = textbox_reaction.Text;
            dateV = vdate.Text;
            staffN = textbox_staff.Text;
            others = textbox_other.Text;
            Name = textbox_name.Text;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;


            if (string.IsNullOrEmpty(vaccine))
            {
                MessageBox.Show("Please select vaccine", "Field Missing", btn, ico);
                combo_vaccine.Select();
                return;

            }
            ////////////////////////////--End of CustomerName Validation
            if (string.IsNullOrEmpty(reaction))
            {
                MessageBox.Show("Please enter animal reaction", "Field Missing", btn, ico);
                textbox_reaction.Select();
                return;

            }
            //////////////////////////////--End of MobileNumber Validation
            if (string.IsNullOrEmpty(staffN))
            {
                MessageBox.Show("Please enter address", "Field Missing", btn, ico);
                textbox_staff.Select();
                return;

            }

         
                ///////////////// INSERT CUSTOMER /////////////////////////
                string mySQL2 = string.Empty;

                mySQL2 += "INSERT INTO vacination_tab (vaccine, name, staff, date, reaction, others) ";
                mySQL2 += "VALUES ('" + vaccine + "','" + Name + "','" + staffN + "','" + dateV + "','" + reaction + "','" + others + "')";
              
                
                Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
                MessageBox.Show("Record saved successfully ", "New Record Added", btn, MessageBoxIcon.Information);
                 
                
                loadUserData();
                ClearControls();
          
      

    }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS Count, vaccine, name, staff, date, reaction, others FROM vacination_tab");
            vacdataGridView.DataSource = UserData;
            vacdataGridView.Columns[0].HeaderText = "S/N";
            vacdataGridView.Columns[1].HeaderText = "Vaccine Name";
            vacdataGridView.Columns[2].HeaderText = "Name";
            vacdataGridView.Columns[3].HeaderText = "Staff";
            vacdataGridView.Columns[4].HeaderText = "Date";
            vacdataGridView.Columns[5].HeaderText = "Reaction";
            vacdataGridView.Columns[6].HeaderText = "Others";
            vacdataGridView.Columns[0].Width = 50;
            vacdataGridView.Columns[1].Width = 100;
            vacdataGridView.Columns[2].Width = 100;
            vacdataGridView.Columns[3].Width = 100;
            vacdataGridView.Columns[4].Width = 100;
            vacdataGridView.Columns[5].Width = 100;


        }

        private void ClearControls()
        {
            textbox_reaction.Text = "";
            textbox_name.Text = "";
            textbox_other.Text = "";
          
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove customer?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM vacination_tab WHERE id = '" + vacdataGridView.CurrentRow.Cells[0].Value + "' ");
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
