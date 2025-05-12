using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject.MTW2Tasks;

public partial class Task4 : ContentPage
{
    public Task4()
    {
        InitializeComponent();
    }

    private void TextEditor_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (TextEditor.Text.Length == 1)
            ResultLabel.Text = "There is 1 character";
        else
            ResultLabel.Text = "There are " + TextEditor.Text.Length + " characters";
    }
}