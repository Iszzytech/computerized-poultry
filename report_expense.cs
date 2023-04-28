using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using Computerized_Poultry_Farm.connection;

namespace Computerized_Poultry_Farm
{
    public partial class report_expense : Form
    {
        public report_expense()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD9VL65;Initial Catalog=pms;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM expenseRecord WHERE date >= '" + BPFromdate.Text + "' AND date <= '" + BPTodate.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                    new Microsoft.Reporting.WinForms.ReportParameter("fromDate",BPFromdate.Value.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("toDate",BPTodate.Value.Date.ToShortDateString())
            };
            //

            reportViewer1.LocalReport.ReportPath = @"C:\Users\Dell\Documents\Visual Studio 2015\Projects\Computerized Poultry Farm\Computerized Poultry Farm\Report_Expense.rdlc";
            reportViewer1.LocalReport.SetParameters(rParams);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();

            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void loadExpenseCat()
        {
            Etype.SelectedItem = "--Select Category--";
            //// Load all expense type 
            DataTable ExpenseTypeData = ServerConnection.executeSQL("SELECT expense_cat FROM expenseCat_tab");

            foreach (DataRow dr in ExpenseTypeData.Rows)
            {
                Etype.Items.Add(dr["expense_cat"].ToString());
            }
        }

        private void report_expense_Load(object sender, EventArgs e)
        {
            loadExpenseCat();
            try
            {
                System.Drawing.Printing.PageSettings pg = new PageSettings();
                pg.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
                pg.PaperSize = new PaperSize("A4", 827, 1169);
                pg.PaperSize.RawKind = (int)PaperKind.A4;
                //Refreshing Report
                this.reportViewer1.SetPageSettings(pg);

                this.reportViewer1.RefreshReport();

                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            }
            catch (Exception)
            {
                MessageBox.Show("Something is wrong");

            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD9VL65;Initial Catalog=pms;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM expenseCat_tab WHERE expense_cat = '" + Etype.SelectedItem.ToString() + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                    new Microsoft.Reporting.WinForms.ReportParameter("fromDate",BPFromdate.Value.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("toDate",BPTodate.Value.Date.ToShortDateString())
            };
            //

            reportViewer1.LocalReport.ReportPath = @"C:\Users\Dell\Documents\Visual Studio 2015\Projects\Computerized Poultry Farm\Computerized Poultry Farm\Report_Expense.rdlc";
            reportViewer1.LocalReport.SetParameters(rParams);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();

            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }
    }
}
