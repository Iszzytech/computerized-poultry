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
    public partial class vac_medication : Form
    {
        public vac_medication()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String nameOfVac;
            String medic;
            String route;
            String dose;
            String age;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;
            // Initializing
            nameOfVac = textbox_vac.Text;
            medic = textbox_medic.Text;
            route = textbox_route.Text;
            dose = textbox_dose.Text;
            age = textbox_age.Text;




            if (string.IsNullOrEmpty(nameOfVac))
            {
                MessageBox.Show("Please enter the breed type", "Field Missing", btn, ico);
                textbox_vac.Select();
                return;

            }


            ///////////////// INSERT CUSTOMER /////////////////////////
            string mySQL2 = string.Empty;

            mySQL2 += "INSERT INTO vac_medicine (name, medic, route, dose, age)";
            mySQL2 += "VALUES ('" + nameOfVac + "','" + medic + "','" + route + "','" + dose + "','" + age + "')";


            Computerized_Poultry_Farm.connection.ServerConnection.executeSQL(mySQL2);
            MessageBox.Show("Record Saved successfully ", "New Record Added", btn, MessageBoxIcon.Information);


            loadUserData();
            ClearControls();
        }

        private void loadUserData()
        {
            // A function to load all data from users table

            DataTable UserData = ServerConnection.executeSQL("SELECT (id) AS count, name, medic, route, dose, age FROM vac_medicine");
            VacdataGridView.DataSource = UserData;
            VacdataGridView.Columns[0].HeaderText = "S/N";
            VacdataGridView.Columns[1].HeaderText = "Vaccine Name";
            VacdataGridView.Columns[2].HeaderText = "Medication";
            VacdataGridView.Columns[3].HeaderText = "Route";
            VacdataGridView.Columns[4].HeaderText = "Dose";
            VacdataGridView.Columns[5].HeaderText = "Age";

            VacdataGridView.Columns[0].Width = 50;
            VacdataGridView.Columns[1].Width = 100;
            VacdataGridView.Columns[2].Width = 100;
            VacdataGridView.Columns[3].Width = 100;
            VacdataGridView.Columns[4].Width = 100;
            VacdataGridView.Columns[5].Width = 100;



        }

        private void ClearControls()
        {
            textbox_vac.Text = "";
            textbox_medic.Text = "";
            textbox_dose.Text = "";
            textbox_route.Text = "";
            textbox_age.Text = "";

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently remove record?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ServerConnection.executeSQL("DELETE FROM vac_medicine WHERE id = '" + VacdataGridView.CurrentRow.Cells[0].Value + "' ");
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

        private void vac_medication_Load(object sender, EventArgs e)
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
