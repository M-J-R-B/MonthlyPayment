using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthlyPayment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            for (int i = 2; i <= 10; i++)
            {
                numberOfYearsComboBox.Items.Add(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                firstInterestRateComboBox.Items.Add(i);
            }

            for (int i = 2; i <= 12; i++)
            {
                lastInterestRateComboBox.Items.Add(i);
            }

            interestRateStepSizeComboBox.Items.AddRange(new object[] { 0.11m, 0.5m, 1.0m, 2.0m });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthlyPaymentListBox.Items.Clear();


            

            if (string.IsNullOrWhiteSpace(loanAmountTextBox.Text))
            {
                MessageBox.Show("Please provide a valid loan amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal loanAmount = Convert.ToDecimal(loanAmountTextBox.Text);
            int numberOfYears = Convert.ToInt32(numberOfYearsComboBox.SelectedItem);
            decimal firstInterestRate = Convert.ToDecimal(firstInterestRateComboBox.SelectedItem) / 100;
            decimal lastInterestRate = Convert.ToDecimal(lastInterestRateComboBox.SelectedItem) / 100;
            decimal interestRateStepSize = Convert.ToDecimal(interestRateStepSizeComboBox.SelectedItem) / 100;

            if (firstInterestRate > lastInterestRate)
            {
                MessageBox.Show("First interest rate cannot be greater than last interest rate.");
                return;
            }

            

            for (decimal interestRate = firstInterestRate; interestRate <= lastInterestRate; interestRate += interestRateStepSize)
            {
                decimal monthlyPayment = CalculateMonthlyPayment(loanAmount, interestRate, numberOfYears);
                monthlyPaymentListBox.Items.Add($"{interestRate:P} \t \t \t \t \t{monthlyPayment:F2}");
                
            }

        }

        private decimal CalculateMonthlyPayment(decimal loanAmount, decimal interestRate, int numberOfYears )
        {
            
            int numberOfPayments = numberOfYears * 12;
            decimal monthlyInterestRate = interestRate / 12;
            decimal compoundFactor = (decimal)Math.Pow((double)(1 + monthlyInterestRate), numberOfPayments);
            return loanAmount * (monthlyInterestRate * compoundFactor) / (compoundFactor - 1);
        }
    }
}
