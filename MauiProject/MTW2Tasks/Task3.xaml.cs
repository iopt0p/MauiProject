using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject.MTW2Tasks;

public partial class Task3 : ContentPage
{
    public Task3()
    {
        InitializeComponent();

        var colorList = new List<string>();
        colorList.Add("red");
        colorList.Add("green");
        colorList.Add("blue");

        BackgroundPicker.ItemsSource = colorList;
    }

    private void BackgroundPicker_OnSelectedIndexChanged(object? sender, EventArgs e)
    {
        BackgroundColor = BackgroundPicker.SelectedItem switch
        {
            "red" => Color.FromRgb(255, 0, 0),
            "green" => Color.FromRgb(0, 255, 0),
            "blue" => Color.FromRgb(0, 0, 255),
            _ => BackgroundColor
        };
    }
}