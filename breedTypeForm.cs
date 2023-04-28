using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computerized_Poultry_Farm
{
    public partial class breedTypeForm : Form
    {
        public breedTypeForm()
        {
            InitializeComponent();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void breedTypeForm_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void breedType1_Load(object sender, EventArgs e)
        {

        }
    }
}
