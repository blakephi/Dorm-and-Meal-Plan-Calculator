
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
            this.mealSelection = new System.Windows.Forms.ComboBox();
            this.mealLabel = new System.Windows.Forms.Label();
            this.calculateTotal = new System.Windows.Forms.Button();
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
            this.dormSelection.Location = new System.Drawing.Point(290, 143);
            this.dormSelection.Name = "dormSelection";
            this.dormSelection.Size = new System.Drawing.Size(220, 21);
            this.dormSelection.TabIndex = 0;
            // 
            // dormLabel
            // 
            this.dormLabel.AutoSize = true;
            this.dormLabel.Location = new System.Drawing.Point(287, 127);
            this.dormLabel.Name = "dormLabel";
            this.dormLabel.Size = new System.Drawing.Size(75, 13);
            this.dormLabel.TabIndex = 1;
            this.dormLabel.Text = "Select a dorm:";
            // 
            // mealSelection
            // 
            this.mealSelection.FormattingEnabled = true;
            this.mealSelection.Items.AddRange(new object[] {
            "7 meals per week - $600/semester",
            "14 meals per week - $1,200/semester",
            "Unlimited meals - $1,700/semester"});
            this.mealSelection.Location = new System.Drawing.Point(290, 271);
            this.mealSelection.Name = "mealSelection";
            this.mealSelection.Size = new System.Drawing.Size(220, 21);
            this.mealSelection.TabIndex = 2;
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(287, 255);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(97, 13);
            this.mealLabel.TabIndex = 3;
            this.mealLabel.Text = "Select a meal plan:";
            // 
            // calculateTotal
            // 
            this.calculateTotal.Location = new System.Drawing.Point(363, 415);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(75, 23);
            this.calculateTotal.TabIndex = 4;
            this.calculateTotal.Text = "Calculate";
            this.calculateTotal.UseVisualStyleBackColor = true;
            // 
            // SelectionForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.mealSelection);
            this.Controls.Add(this.dormLabel);
            this.Controls.Add(this.dormSelection);
            this.Name = "SelectionForm";
            this.Text = "Dorm and Meal Plan Selection";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectDorm;
        private System.Windows.Forms.ComboBox dormSelection;
        private System.Windows.Forms.Label dormLabel;
        private System.Windows.Forms.ComboBox mealSelection;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.Button calculateTotal;
    }
}

