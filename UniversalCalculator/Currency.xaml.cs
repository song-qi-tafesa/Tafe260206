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
	public sealed partial class Currency : Page
	{
		public Currency()
		{
			this.InitializeComponent();
		}
		//main function for presenting the calculations when button clicked
		private void Calculate_Currency_Button_Click(object sender, RoutedEventArgs e)
		{
			//set up variables
			double amount;
			double result;
			string fromCurrency ="e";
			string toCurrency ="e";
			amount = double.Parse(amountTextBox.Text);

			//grab the tag for each of the combo boxes
			var item1 = fromBox.SelectedItem as ComboBoxItem;
			var item2 = toBox.SelectedItem as ComboBoxItem;

			string fromBoxTag = item1?.Tag?.ToString();
			string toBoxTag = item2?.Tag?.ToString();

			//define the currencies for presenting in text
			if (fromBoxTag == "fromUS")
			{
				fromCurrency = "USD";
			}
			if (fromBoxTag == "fromEuro")
			{
				fromCurrency = "EUR";
			}
			if (fromBoxTag == "fromBritish")
			{
				fromCurrency = "GBP";
			}
			if (fromBoxTag == "fromIndian")
			{
				fromCurrency = "INR";
			}
			if (toBoxTag == "toUS")
			{
				toCurrency = "USD";
			}
			if (toBoxTag == "toEuro")
			{
				toCurrency = "EUR";
			}
			if (toBoxTag == "toBritish")
			{
				toCurrency = "GBP";
			}
			if (toBoxTag == "toIndian")
			{
				toCurrency = "INR";
			}

			//calculate conversion rate
			result = ConversionFunction(amount, fromBoxTag, toBoxTag);

			//present the conversion 
			initialRequestText.Text = Math.Round(amount, 2).ToString() + " " + fromCurrency + " =";
			calculationText.Text = Math.Round(result, 2).ToString() + " " + toCurrency;

			//give example of base conversion rate
			amount = 1;
			baseConversionOneText.Text = "1 " + fromCurrency + " = " + ConversionFunction(amount, fromBoxTag, toBoxTag) + " " + toCurrency;
			baseConversionTwoText.Text = "1 " + toCurrency + " = " + ConversionFunction(amount, toBoxTag, fromBoxTag) + " " + fromCurrency;
		}
		//function for conversion rate
		private double ConversionFunction(double amount, string selection1, string selection2)
		{
			//set variables
			double conversionRate;
			double result;

			//decide which conversion rate needs to be used, and calculate the result
			if (selection1 == "fromUS" || selection1 == "toUS")
			{
				if (selection2 == "toEuro" || selection2 == "fromEuro")
				{
					conversionRate = 0.85189982;
					result = amount * conversionRate;
					return result;
				}
				if (selection2 == "toBritish" || selection2 == "fromBritish")
				{
					conversionRate = 0.72872436;
					result = amount * conversionRate;
					return result;
				}
				if (selection2 == "toIndian" || selection2 == "fromIndian")
				{
					conversionRate = 74.257327;
					result = amount * conversionRate;
					return result;
				}
			}
			if (selection1 == "fromEuro" || selection1 == "toEuro")
			{
				if (selection2 == "toUS" || selection2 == "fromUS")
				{
					conversionRate = 1.1739732;
					result = amount * conversionRate;
					return result;
				}
				if (selection2 == "toBritish" || selection2 == "fromBritish")
				{
					conversionRate = 0.8556672;
					result = amount * conversionRate;
					return result;
				}
				if (selection2 == "toIndian" || selection2 == "fromIndian")
				{
					conversionRate = 87.00755;
					result = amount * conversionRate;
					return result;
				}
			}
			if (selection1 == "fromBritish" || selection1 == "toBritish")
			{
				if (selection2 == "toEuro" || selection2 == "fromEuro")
				{
					conversionRate = 1.1686692;
					result = amount * conversionRate;
					return result;
				}
				if (selection2 == "toUS" || selection2 == "fromUS")
				{
					conversionRate = 1.371907;
					result = amount * conversionRate;
					return result;
				}
				if (selection2 == "toIndian" || selection2 == "fromIndian")
				{
					conversionRate = 101.68635;
					result = amount * conversionRate;
					return result;
				}
			}
			if (selection1 == "fromIndian" || selection1 == "toIndian")
			{
				if (selection2 == "toEuro" || selection2 == "fromEuro")
				{
					conversionRate = 0.013492774;
					result = amount * conversionRate;
					return result;
				}
				if (selection2 == "toBritish" || selection2 == "fromBritish")
				{
					conversionRate = 0.0098339397;
					result = amount * conversionRate;
					return result;
				}
				if (selection2 == "toUS" || selection2 == "fromUS")
				{
					conversionRate = 0.011492628;
					result = amount * conversionRate;
					return result;
				}
			}

			//should only return 3.6 if there is an error finding the conversion rate
			return 3.6;
		
		}
		//quit the program
		private void Exit_Button_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Exit();
		}

	}
}
