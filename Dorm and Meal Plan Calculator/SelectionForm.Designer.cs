
namespace Dorm_and_Meal_Plan_Calculator
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dormSelection = new System.Windows.Forms.ComboBox();
            this.dormLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mealLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dormSelection
            // 
            this.dormSelection.FormattingEnabled = true;
            this.dormSelection.Items.AddRange(new object[] {
            "Allen Hall - $1,500/semester",
            "Pike Hall - $1,600/semester",
            "Farthing Hall - $1,800/semester",
            "University Suites - $2,500/semester"});
            this.dormSelection.Location = new System.Drawing.Point(296, 143);
            this.dormSelection.Name = "dormSelection";
            this.dormSelection.Size = new System.Drawing.Size(220, 21);
            this.dormSelection.TabIndex = 0;
            // 
            // dormLabel
            // 
            this.dormLabel.AutoSize = true;
            this.dormLabel.Location = new System.Drawing.Point(293, 127);
            this.dormLabel.Name = "dormLabel";
            this.dormLabel.Size = new System.Drawing.Size(75, 13);
            this.dormLabel.TabIndex = 1;
            this.dormLabel.Text = "Select a dorm:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "7 meals per week - $600/semester",
            "14 meals per week - $1,200/semester",
            "Unlimited meals - $1,700/semester"});
            this.comboBox1.Location = new System.Drawing.Point(296, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(293, 255);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(97, 13);
            this.mealLabel.TabIndex = 3;
            this.mealLabel.Text = "Select a meal plan:";
            // 
            // SelectionForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dormLabel);
            this.Controls.Add(this.dormSelection);
            this.Name = "SelectionForm";
            this.Text = "Dorm and Meal Plan Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectDorm;
        private System.Windows.Forms.ComboBox dormSelection;
        private System.Windows.Forms.Label dormLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label mealLabel;
    }
}

