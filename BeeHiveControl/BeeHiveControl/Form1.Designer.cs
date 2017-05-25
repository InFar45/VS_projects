namespace BeeHiveControl
{
    partial class Form1
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
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.report = new System.Windows.Forms.TextBox();
            this.assignJob = new System.Windows.Forms.Button();
            this.work_bee_label = new System.Windows.Forms.Label();
            this.shifts_label = new System.Windows.Forms.Label();
            this.nextShift = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Egg care",
            "Hive maintenance",
            "Baby bee tuturing",
            "Honey manufacturing",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(27, 70);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(169, 21);
            this.workerBeeJob.TabIndex = 0;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 164);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(397, 215);
            this.report.TabIndex = 1;
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(27, 111);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(169, 23);
            this.assignJob.TabIndex = 2;
            this.assignJob.Text = "Assign this job to a bee";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // work_bee_label
            // 
            this.work_bee_label.AutoSize = true;
            this.work_bee_label.Location = new System.Drawing.Point(27, 51);
            this.work_bee_label.Name = "work_bee_label";
            this.work_bee_label.Size = new System.Drawing.Size(71, 13);
            this.work_bee_label.TabIndex = 3;
            this.work_bee_label.Text = "Work bee job";
            // 
            // shifts_label
            // 
            this.shifts_label.AutoSize = true;
            this.shifts_label.Location = new System.Drawing.Point(219, 50);
            this.shifts_label.Name = "shifts_label";
            this.shifts_label.Size = new System.Drawing.Size(33, 13);
            this.shifts_label.TabIndex = 5;
            this.shifts_label.Text = "Shifts";
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(311, 67);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(75, 67);
            this.nextShift.TabIndex = 6;
            this.nextShift.Text = "Work the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(222, 70);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(54, 20);
            this.shifts.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 391);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.shifts_label);
            this.Controls.Add(this.work_bee_label);
            this.Controls.Add(this.assignJob);
            this.Controls.Add(this.report);
            this.Controls.Add(this.workerBeeJob);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.Label work_bee_label;
        private System.Windows.Forms.Label shifts_label;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.NumericUpDown shifts;
    }
}

