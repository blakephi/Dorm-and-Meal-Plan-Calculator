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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }


        int[] dormCosts = { 1500, 1600, 1800, 2500 };
        int[] mealCosts = { 600, 1200, 1700 };

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            dormSelection.SelectedIndex = 0;
            mealSelection.SelectedIndex = 0;
        }

        private void calculateTotal_Click(object sender, EventArgs e)
        {
            int totalCosts = dormCosts[dormSelection.SelectedIndex] + mealCosts[mealSelection.SelectedIndex];
            TotalsForm totalsForm = new TotalsForm(totalCosts);
            totalsForm.Show();
        }
    }
}
