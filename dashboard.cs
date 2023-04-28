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
using System.Data.SqlClient;

namespace Computerized_Poultry_Farm
{
    public partial class dashboard : Form
    {
        public static string getName;


        static dashboard _obj;

        public static dashboard Instance
        {
            get
            {

                if (_obj == null)
                {
                    _obj = new dashboard();

                }
                return _obj;

            }

        }


        public Guna.UI.WinForms.GunaAdvenceTileButton saleBtn
        {
            get { return sale_btn;  }
            set { sale_btn = value; }
        }



        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();

           

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(header, Color.Black, 30, 10, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(sidebar, Color.Black, 60, 40, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);


            if (Form1.getSession == "A")
            {
                status.Text = "Admin";
                DisableControl();
                DisableBtn();
                dashboard_btn.Checked = true;

            }
            else if (Form1.getSession == "S")
            {
                status.Text = "Staff";
                UserEmail.Text = Form1.getEmail;

                DataTable CustomerData = ServerConnection.executeSQL("SELECT fullname FROM users WHERE email = '" + UserEmail.Text + "'");
                foreach (DataRow dr in CustomerData.Rows)
                {
                    LabelName.Text = (dr["fullname"].ToString());


                }

                getName = LabelName.Text;
                DisableBtn();
                staff_btn.Visible = false;
                dashboard_btn.Checked = true;
                staffDash2.Visible = true;
                staffDash2.BringToFront();
            }

       
        }

        

        private void customer_btn_Click(object sender, EventArgs e)
        {
            DisableBtn();
           
            customer2.Visible = true;
            customer_btn.Checked = true;
            customer2.BringToFront();

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            if (status.Text == "Admin")
            {
                DisableControl();
                DisableBtn();
                dashboard_btn.Checked = true;
            } else if (status.Text == "Staff")
            {
                DisableBtn();
                dashboard_btn.Checked = true;
                staffDash2.Visible = true;
                staffDash2.BringToFront();

            }
          
        }

        private void DisableBtn()
        {
            dashboard_btn.Checked = false;
            sale_btn.Checked = false;
            customer_btn.Checked = false;
            batch_btn.Checked = false;
            egg_btn.Checked = false;
            hatechery_btn.Checked = false;
            vaccine_btn.Checked = false;
            staff_btn.Checked = false;
            expenses_btn.Checked = false;
            income_btn.Checked = false;  

        }

        private void DisableControl()
        {
            customer2.Visible = false;
            staff2.Visible = false;
            sales2.Visible = false;
            batchFlock2.Visible = false;
            eggRecord2.Visible = false;
            hatchery2.Visible = false;
            vaccination2.Visible = false;
            expense_Record2.Visible = false;
            income_Record2.Visible = false;
            staffDash2.Visible = false;

        }

        private void sale_btn_Click(object sender, EventArgs e)
        {
            DisableBtn();
            sale_btn.Checked = true;
            sales2.Visible = true;
            sales2.BringToFront();
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            DisableBtn();
            staff_btn.Checked = true;
            staff2.Visible = true;
            staff2.BringToFront();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(extra, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(extra, Color.Black, 20, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
            extra.Visible = true;
            extra.BringToFront();
        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
           
            extra.Visible = false;
            extra.SendToBack();
        }

        private void breedType_btn_Click(object sender, EventArgs e)
        {
            breedTypeForm bd = new breedTypeForm();
            bd.ShowDialog();

        }

        private void batch_btn_Click(object sender, EventArgs e)
        {
            DisableBtn();
            batch_btn.Checked = true;
            batchFlock2.Visible = true;
            batchFlock2.BringToFront();
        }

        private void egg_btn_Click(object sender, EventArgs e)
        {
            DisableBtn();
            egg_btn.Checked = true;
            eggRecord2.Visible = true;
           eggRecord2.BringToFront();
        }

        private void hatechery_btn_Click(object sender, EventArgs e)
        {
            DisableBtn();
            hatechery_btn.Checked = true;
            hatchery2.Visible = true;
            hatchery2.BringToFront();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            vac_medication vacMed = new vac_medication();
            vacMed.ShowDialog();
        }

        private void vaccine_btn_Click(object sender, EventArgs e)
        {
            DisableBtn();
           vaccine_btn.Checked = true;
           vaccination2.Visible = true;
           vaccination2.BringToFront();
        }

        private void expenses_btn_Click(object sender, EventArgs e)
        {
            DisableBtn();
            expenses_btn.Checked = true;
            bunifuTransition1.ShowSync(expensePanel, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(expensePanel, Color.Black, 20, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
            expensePanel.Visible = true;
            expensePanel.BringToFront();
        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            DisableBtn();
           income_btn.Checked = true;
            bunifuTransition1.ShowSync(IncomePanel, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(IncomePanel, Color.Black, 20, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
            IncomePanel.Visible = true;
            IncomePanel.BringToFront();

        }

        private void gunaImageButton6_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(IncomePanel, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
            IncomePanel.Visible = false;
           IncomePanel.SendToBack();
        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(expensePanel, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
            expensePanel.Visible = false;
            expensePanel.SendToBack();
        }

        private void ExpenseCat_Click(object sender, EventArgs e)
        {
            expense_cat exCat = new expense_cat();
            exCat.ShowDialog();
        }

        private void incomeCat_Click(object sender, EventArgs e)
        {
            incomeCat inCat = new incomeCat();
            inCat.ShowDialog();
        }

        private void ExpenseRecord_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(expensePanel, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
            expensePanel.Visible = false;
            expensePanel.SendToBack();

            DisableBtn();
            ExpenseRecord.Checked = true;
            expense_Record2.Visible = true;
            expense_Record2.BringToFront();
        }

        private void IncomeRecord_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(IncomePanel, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
            IncomePanel.Visible = false;
            IncomePanel.SendToBack();

            DisableBtn();        
            IncomeRecord.Checked = true;
            income_Record2.Visible = true;
            income_Record2.BringToFront();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            if (status.Text == "Admin")
            {
                bunifuTransition1.ShowSync(panelGreet, false, BunifuAnimatorNS.Animation.Scale);
                panelGreet.Visible = true;
                MessageRead.BringToFront();
            }
            else if(status.Text == "Staff")
            {
                DataTable CustomerData = ServerConnection.executeSQL("SELECT fullname FROM users WHERE email = '" + UserEmail.Text + "'");
                foreach (DataRow dr in CustomerData.Rows)
                {
                    LabelName.Text = (dr["fullname"].ToString());
                    getName = LabelName.Text;
                }

                bunifuTransition1.ShowSync(panelGreet, false, BunifuAnimatorNS.Animation.Scale);
                panelGreet.Visible = true;
                MessageRead.BringToFront();
            }
        }

       

        // Set up dashboard count
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int count6 = 0;
        int count7 = 0;
        int count8 = 0;
        int count9 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD9VL65;Initial Catalog=pms;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM customer_tab ", con);
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM sales ", con);
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM incomeRecord ", con);
            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM expenseRecord ", con);
            SqlCommand cmd5 = new SqlCommand("SELECT COUNT(*) FROM batch_flock ", con);
            SqlCommand cmd6 = new SqlCommand("SELECT COUNT(*) FROM egg_tab ", con);
            SqlCommand cmd7 = new SqlCommand("SELECT COUNT(*) FROM hatchery_tab ", con);
            SqlCommand cmd8 = new SqlCommand("SELECT COUNT(*) FROM vacination_tab ", con);
            SqlCommand cmd9 = new SqlCommand("SELECT COUNT(*) FROM staff ", con);
            count1 = Convert.ToInt32(cmd.ExecuteScalar());
            count2 = Convert.ToInt32(cmd2.ExecuteScalar());
            count3 = Convert.ToInt32(cmd3.ExecuteScalar());
            count4 = Convert.ToInt32(cmd4.ExecuteScalar());
            count5 = Convert.ToInt32(cmd5.ExecuteScalar());
            count6 = Convert.ToInt32(cmd6.ExecuteScalar());
            count7 = Convert.ToInt32(cmd7.ExecuteScalar());
            count8 = Convert.ToInt32(cmd8.ExecuteScalar());
            count9 = Convert.ToInt32(cmd9.ExecuteScalar());
            labelcustStatus.Text = count1.ToString();
            labelSales.Text = count2.ToString();
            labelIncome.Text = count3.ToString();
            labelExpense.Text = count4.ToString();
            labelBatch.Text = count5.ToString();
            labelEgg.Text = count6.ToString();
            labelHatchery.Text = count7.ToString();
            labelVaccine.Text = count8.ToString();
            labelStaff.Text = count9.ToString();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelCustomer_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panelSale_Click(object sender, EventArgs e)
        {
            DisableBtn();
            sale_btn.Checked = true;
            sales2.Visible = true;
            sales2.BringToFront();
        }

        private void panelCustomer_Click(object sender, EventArgs e)
        {

            DisableBtn();
            customer2.Visible = true;
            customer_btn.Checked = true;
            customer2.BringToFront();
        }

        private void panelIncome_Click(object sender, EventArgs e)
        {
            DisableBtn();
            IncomeRecord.Checked = true;
            income_Record2.Visible = true;
            income_Record2.BringToFront();
        }

        private void panelExpense_Click(object sender, EventArgs e)
        {
            DisableBtn();
            ExpenseRecord.Checked = true;
            expense_Record2.Visible = true;
            expense_Record2.BringToFront();
        }

        private void panelBatch_Click(object sender, EventArgs e)
        {
            DisableBtn();
            batch_btn.Checked = true;
            batchFlock2.Visible = true;
            batchFlock2.BringToFront();
        }

        private void panelEgg_Click(object sender, EventArgs e)
        {
            DisableBtn();
            egg_btn.Checked = true;
            eggRecord2.Visible = true;
            eggRecord2.BringToFront();
        }

        private void panelHatchery_Click(object sender, EventArgs e)
        {
            DisableBtn();
            hatechery_btn.Checked = true;
            hatchery2.Visible = true;
            hatchery2.BringToFront();
        }

        private void panelVaccine_Click(object sender, EventArgs e)
        {
            DisableBtn();
            vaccine_btn.Checked = true;
            vaccination2.Visible = true;
            vaccination2.BringToFront();
        }

        private void panelStaff_Click(object sender, EventArgs e)
        {
            DisableBtn();
            staff_btn.Checked = true;
            staff2.Visible = true;
            staff2.BringToFront();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            PoultryDoc pd = new PoultryDoc();
            pd.ShowDialog();

        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            report_sales rp = new report_sales();
            rp.ShowDialog();
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            report_income ri = new report_income();
            ri.ShowDialog();
        }

        private void gunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            report_expense re = new report_expense();
            re.ShowDialog();
        }
    }
}
