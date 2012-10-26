namespace BodyMedia.WinFormsDemo
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
            this.AuthenticateButton = new System.Windows.Forms.Button();
            this.SleepButton = new System.Windows.Forms.Button();
            this.BurnButton = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.bodyMediaAuthControl1 = new BodyMedia.WinFormsControls.BodyMediaAuthControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OutputFolderTextBox = new System.Windows.Forms.TextBox();
            this.StepButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthenticateButton
            // 
            this.AuthenticateButton.Location = new System.Drawing.Point(40, 15);
            this.AuthenticateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuthenticateButton.Name = "AuthenticateButton";
            this.AuthenticateButton.Size = new System.Drawing.Size(115, 28);
            this.AuthenticateButton.TabIndex = 0;
            this.AuthenticateButton.Text = "Authenticate";
            this.AuthenticateButton.UseVisualStyleBackColor = true;
            this.AuthenticateButton.Click += new System.EventHandler(this.AuthenticateButton_Click);
            // 
            // SleepButton
            // 
            this.SleepButton.Enabled = false;
            this.SleepButton.Location = new System.Drawing.Point(40, 167);
            this.SleepButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SleepButton.Name = "SleepButton";
            this.SleepButton.Size = new System.Drawing.Size(115, 28);
            this.SleepButton.TabIndex = 1;
            this.SleepButton.Text = "Sleep Data";
            this.SleepButton.UseVisualStyleBackColor = true;
            this.SleepButton.Click += new System.EventHandler(this.SleepButton_Click);
            // 
            // BurnButton
            // 
            this.BurnButton.Enabled = false;
            this.BurnButton.Location = new System.Drawing.Point(40, 203);
            this.BurnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BurnButton.Name = "BurnButton";
            this.BurnButton.Size = new System.Drawing.Size(115, 28);
            this.BurnButton.TabIndex = 2;
            this.BurnButton.Text = "Burn Data";
            this.BurnButton.UseVisualStyleBackColor = true;
            this.BurnButton.Click += new System.EventHandler(this.BurnButton_Click);
            // 
            // StartDate
            // 
            this.StartDate.Enabled = false;
            this.StartDate.Location = new System.Drawing.Point(124, 71);
            this.StartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(265, 22);
            this.StartDate.TabIndex = 3;
            // 
            // EndDate
            // 
            this.EndDate.Enabled = false;
            this.EndDate.Location = new System.Drawing.Point(124, 104);
            this.EndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(265, 22);
            this.EndDate.TabIndex = 4;
            // 
            // bodyMediaAuthControl1
            // 
            this.bodyMediaAuthControl1.Location = new System.Drawing.Point(406, 15);
            this.bodyMediaAuthControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bodyMediaAuthControl1.Name = "bodyMediaAuthControl1";
            this.bodyMediaAuthControl1.Size = new System.Drawing.Size(779, 518);
            this.bodyMediaAuthControl1.TabIndex = 5;
            this.bodyMediaAuthControl1.Visible = false;
            // 
            // OutputFolderTextBox
            // 
            this.OutputFolderTextBox.Location = new System.Drawing.Point(40, 135);
            this.OutputFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputFolderTextBox.Name = "OutputFolderTextBox";
            this.OutputFolderTextBox.Size = new System.Drawing.Size(349, 22);
            this.OutputFolderTextBox.TabIndex = 6;
            // 
            // StepButton
            // 
            this.StepButton.Enabled = false;
            this.StepButton.Location = new System.Drawing.Point(40, 239);
            this.StepButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(115, 28);
            this.StepButton.TabIndex = 7;
            this.StepButton.Text = "Step Data";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "End Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StepButton);
            this.Controls.Add(this.OutputFolderTextBox);
            this.Controls.Add(this.bodyMediaAuthControl1);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.BurnButton);
            this.Controls.Add(this.SleepButton);
            this.Controls.Add(this.AuthenticateButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthenticateButton;
        private System.Windows.Forms.Button SleepButton;
        private System.Windows.Forms.Button BurnButton;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private BodyMedia.WinFormsControls.BodyMediaAuthControl bodyMediaAuthControl1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox OutputFolderTextBox;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

