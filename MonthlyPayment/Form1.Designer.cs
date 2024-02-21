namespace MonthlyPayment
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
            this.monthlyPaymentListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.numberOfYearsComboBox = new System.Windows.Forms.ComboBox();
            this.firstInterestRateComboBox = new System.Windows.Forms.ComboBox();
            this.lastInterestRateComboBox = new System.Windows.Forms.ComboBox();
            this.interestRateStepSizeComboBox = new System.Windows.Forms.ComboBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthlyPaymentListBox
            // 
            this.monthlyPaymentListBox.FormattingEnabled = true;
            this.monthlyPaymentListBox.Location = new System.Drawing.Point(73, 145);
            this.monthlyPaymentListBox.MultiColumn = true;
            this.monthlyPaymentListBox.Name = "monthlyPaymentListBox";
            this.monthlyPaymentListBox.Size = new System.Drawing.Size(282, 147);
            this.monthlyPaymentListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interest Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loan Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Years";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Interest Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last Interest Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Interest Rate Step Size";
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(552, 141);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(121, 20);
            this.loanAmountTextBox.TabIndex = 8;
            // 
            // numberOfYearsComboBox
            // 
            this.numberOfYearsComboBox.FormattingEnabled = true;
            this.numberOfYearsComboBox.Location = new System.Drawing.Point(552, 175);
            this.numberOfYearsComboBox.Name = "numberOfYearsComboBox";
            this.numberOfYearsComboBox.Size = new System.Drawing.Size(121, 21);
            this.numberOfYearsComboBox.TabIndex = 9;
            // 
            // firstInterestRateComboBox
            // 
            this.firstInterestRateComboBox.FormattingEnabled = true;
            this.firstInterestRateComboBox.Location = new System.Drawing.Point(552, 210);
            this.firstInterestRateComboBox.Name = "firstInterestRateComboBox";
            this.firstInterestRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.firstInterestRateComboBox.TabIndex = 10;
            // 
            // lastInterestRateComboBox
            // 
            this.lastInterestRateComboBox.FormattingEnabled = true;
            this.lastInterestRateComboBox.Location = new System.Drawing.Point(552, 240);
            this.lastInterestRateComboBox.Name = "lastInterestRateComboBox";
            this.lastInterestRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.lastInterestRateComboBox.TabIndex = 10;
            // 
            // interestRateStepSizeComboBox
            // 
            this.interestRateStepSizeComboBox.FormattingEnabled = true;
            this.interestRateStepSizeComboBox.Location = new System.Drawing.Point(552, 275);
            this.interestRateStepSizeComboBox.Name = "interestRateStepSizeComboBox";
            this.interestRateStepSizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.interestRateStepSizeComboBox.TabIndex = 10;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(309, 340);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(178, 57);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 643);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.interestRateStepSizeComboBox);
            this.Controls.Add(this.lastInterestRateComboBox);
            this.Controls.Add(this.firstInterestRateComboBox);
            this.Controls.Add(this.numberOfYearsComboBox);
            this.Controls.Add(this.loanAmountTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthlyPaymentListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox monthlyPaymentListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.ComboBox numberOfYearsComboBox;
        private System.Windows.Forms.ComboBox firstInterestRateComboBox;
        private System.Windows.Forms.ComboBox lastInterestRateComboBox;
        private System.Windows.Forms.ComboBox interestRateStepSizeComboBox;
        private System.Windows.Forms.Button CalculateButton;
    }
}

