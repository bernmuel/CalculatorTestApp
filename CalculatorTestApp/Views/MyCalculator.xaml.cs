using CalculatorTestApp.ViewModels;

namespace CalculatorTestApp.Views;

public partial class MyCalculator : ContentPage
{
	public MyCalculator()
	{
		InitializeComponent();

        BindingContext = new MyCalculatorViewModel();
    }
}