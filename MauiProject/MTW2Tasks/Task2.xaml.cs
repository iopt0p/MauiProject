using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject.MTW2Tasks;

public partial class Task2 : ContentPage
{
    private int _count = 0;

    public Task2()
    {
        InitializeComponent();
    }

    private void UpdateResultLabel()
    {
        ResultLabel.Text = "You clicked " + _count + (_count == 1 ? "time" : " times");
    }

    private void CountButton_OnClicked(object? sender, EventArgs e)
    {
        _count++;
        UpdateResultLabel();
    }

    private void ClearButton_OnClicked(object? sender, EventArgs e)
    {
        _count = 0;
        UpdateResultLabel();
    }
}