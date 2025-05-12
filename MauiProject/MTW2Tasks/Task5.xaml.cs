using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject.MTW2Tasks;

public partial class Task5 : ContentPage
{
    public Task5()
    {
        InitializeComponent();
        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            return true;
        });
    }
}