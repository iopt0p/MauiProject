using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject;

public partial class LB6 : ContentPage
{
    public LB6()
    {
        InitializeComponent();
    }

    private void Variable_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(e.NewTextValue)) return;

        if (!double.TryParse(e.NewTextValue, out double value))
        {
            ((Entry) sender).Text = e.OldTextValue;
        }
    }

    private void CalculateButton_OnClicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Variable1.Text) || string.IsNullOrEmpty(Variable2.Text))
        {
            Result.Text = "Please enter a value";
            return;
        }

        double variable1 = double.Parse(Variable1.Text);
        double variable2 = double.Parse(Variable2.Text);

        Result.Text = Convert.ToDecimal((6 - Math.Cos(3 + variable1))
                                        / (34 - 9 * Math.Pow(variable2, 3) + variable2)).ToString();

        Average.Text = ((variable1 + variable2) / 2).ToString();
    }

    private void ResetButton_OnClicked(object? sender, EventArgs e)
    {
        Variable1.Text = string.Empty;
        Variable2.Text = string.Empty;
        Result.Text = string.Empty;
        Average.Text = string.Empty;
    }

    private void ExitButton_OnClicked(object? sender, EventArgs e)
    {
        App.Current.Quit();
    }
}
