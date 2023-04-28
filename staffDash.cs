using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computerized_Poultry_Farm
{
    public partial class staffDash : UserControl
    {
        public staffDash()
        {
            InitializeComponent();
        }

        private void staffDash_Load(object sender, EventArgs e)
        {
            labName.Text = dashboard.getName;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            sales salePage = new sales();
            salePage.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(salePage);
            salePage.BringToFront();
           

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            customer cust = new customer();
            cust.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(cust);
            cust.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            PoultryDoc pd = new PoultryDoc();
            pd.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labName_Click(object sender, EventArgs e)
        {

        }
    }
}
