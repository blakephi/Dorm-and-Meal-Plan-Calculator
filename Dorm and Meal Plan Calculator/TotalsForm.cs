using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class TotalsForm : Form
    {
        int total;
        public TotalsForm(int total)
        {
            this.total = total;
            InitializeComponent();
            displayTotal.Text = displayTotal.Text + total.ToString("C");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
