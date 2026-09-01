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
		//function for presenting information
		// private void conversionButton_Click(object sender, RoutedEventArgs e):

		// decimal amount
		// decimal result
		// amount = amountInput
		// result = conversionFunction(amount, selection1, selection2)

		// initialRequestText = amount + selection1 =
		// calculationText = result + selection2
		// amount = 1
		// baseConversionOneText = (1 selection1) = conversionFunction(amount, selection1, selection2) selection2
		// baseConversionTwoText = (1 selection2) = conversionFunction(amount, selection2, selection1) selection1

		//function for conversion
		// private conversionFunction(amount)

		// decimal conversionRate(amount, selection1, selection2)

		// if selection1 = US
		//		if selection2 = Euro:
		//			conversionRate = 0.85189982
		//			result = amount x conversionRate
		//		if selection2 = British Pound:
		//			conversionRate = 0.72872436
		//			result = amount x conversionRate
		//		if selection2 = Indian Rupee:
		//			conversionRate = 74.257327
		//			result = amount x conversionRate

		// if selection1 = Euro
		//		if selection2 = US:
		//			conversionRate = 1.1739732
		//			result = amount x conversionRate
		//		if selection2 = British Pound:
		//			conversionRate = 0.8556672
		//			result = amount x conversionRate
		//		if selection2 = Indian Rupee:
		//			conversionRate = 87.00755
		//			result = amount x conversionRate

		// if selection1 = British Pound
		//		if selection2 = Euro:
		//			conversionRate = 1.1686692
		//			result = amount x conversionRate
		//		if selection2 = US:
		//			conversionRate = 1.371907
		//			result = amount x conversionRate
		//		if selection2 = Indian Rupee:
		//			conversionRate = 101.68635
		//			result = amount x conversionRate

		// if selection1 = Indian Rupee
		//		if selection2 = Euro:
		//			conversionRate = 0.013492774
		//			result = amount x conversionRate
		//		if selection2 = British Pound:
		//			conversionRate = 0.0098339397
		//			result = amount x conversionRate
		//		if selection2 = US:
		//			conversionRate = 0.011492628
		//			result = amount x conversionRate

		// private void Exit_Button_Click(object sender, RoutedEventArgs e)
		//{
			//CoreApplication.Exit();
		//}

}
}
