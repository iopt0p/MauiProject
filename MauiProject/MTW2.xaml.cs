using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiProject.MTW2Tasks;

namespace MauiProject;

public partial class MTW2 : ContentPage
{
    public MTW2()
    {
        InitializeComponent();
    }

    private void Task1_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Task1());
    }

    private void Task2_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Task2());
    }

    private void Task3_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Task3());
    }

    private void Task4_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Task4());
    }

    private void Task5_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Task5());
    }
}