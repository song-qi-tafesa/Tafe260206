using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Mortgage : Page
	{
		public Mortgage()
		{
			this.InitializeComponent();
		}

		private void Calculate_Button_Click(object sender, RoutedEventArgs e)
		{
			double annualInterestRate = double.Parse(annualInterestRateTextBox.Text);
			double principal = double.Parse(principalTextBox.Text);
			int years = int.Parse(yearsTextBox.Text);
			int months = int.Parse(monthsTextBox.Text);

			double monthlyInterestRate = CalculateMonthlyInterestRate(annualInterestRate);
			double repayment = CalculateRepayment(annualInterestRate, principal, years, months);

			monthlyInterestRateTextBox.Text = monthlyInterestRate.ToString("N4");
			monthlyRepaymentTextBox.Text = repayment.ToString("N2");
		}

		private double CalculateMonthlyInterestRate(double annualInterestRate)
		{
			return (annualInterestRate / 12.0) * 0.01;
		}



		private double CalculateRepayment(double annualInterestRate, double principal, int years, int months)
		{
			double monthlyInterestRate = CalculateMonthlyInterestRate(annualInterestRate);
			int numberOfPayments = (years * 12) + months;

			double numerator = principal * Math.Pow(1 + monthlyInterestRate, numberOfPayments) * monthlyInterestRate;
			double denominator = Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1;

			return numerator / denominator;
		}


		private void Exit_Button_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Exit();
		}
	}
}
