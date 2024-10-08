using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CalculatorTestApp.ViewModels;

public partial class MyCalculatorViewModel : ObservableObject
{
    private readonly Calculator _calculator = new Calculator();

    [ObservableProperty]
    private double _numericValue1;

    [ObservableProperty]
    private double _numericValue2;

    [ObservableProperty]
    private double _result; // Property to store the result

    public MyCalculatorViewModel(Calculator calculator)
    {
        _calculator = calculator;
        // Set initial values
        NumericValue1 = 0;
        NumericValue2 = 0;
    }

    public MyCalculatorViewModel()
    {
        NumericValue1 = 0;
        NumericValue2 = 0;
    }

    // AddCommand
    [RelayCommand]
    public void Add()
    {
        //Result = NumericValue1 + NumericValue2;
        Result = _calculator.Add(NumericValue1, NumericValue2);
        ResetValues();
    }

    // SubtractCommand
    [RelayCommand]
    public void Subtract()
    {
        //Result = NumericValue1 - NumericValue2;
        Result = _calculator.Subtract(NumericValue1, NumericValue2);
        ResetValues();
    }

    // MultiplyCommand
    [RelayCommand]
    public void Multiply()
    {
        //Result = NumericValue1 * NumericValue2;
        Result = _calculator.Multiply(NumericValue1, NumericValue2);
        ResetValues();
    }

    // DivideCommand
    [RelayCommand]
    public void Divide()
    {
        //if (NumericValue2 != 0)
        //    Result = NumericValue1 / NumericValue2;
        //else
        //    Result = 0; // Prevent division by zero

        Result = _calculator.Divide(NumericValue1, NumericValue2);

        ResetValues();
    }

    private void ResetValues()
    {
        NumericValue1 = 0;
        NumericValue2 = 0;
    }
}



