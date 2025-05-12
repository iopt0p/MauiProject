using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject.MTW2Tasks;

public partial class Task1 : ContentPage
{
    public Task1()
    {
        InitializeComponent();
    }

    private void NumberEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(e.NewTextValue)) return;

        if (!int.TryParse(e.NewTextValue, out int value))
            ((Entry) sender).Text = e.OldTextValue;
    }

    private void GenerateButton_OnClicked(object? sender, EventArgs e)
    {
        int minValue = int.Parse(MinimumValueEntry.Text);
        int maxValue = int.Parse(MaximumValueEntry.Text);
        if (minValue < maxValue)
        {
            Random rnd = new Random();
            ResultLabel.Text = rnd.Next(minValue, maxValue).ToString();
        }
        else
        {
            ResultLabel.Text = "Max value must be greater than Min value";
        }
    }
}