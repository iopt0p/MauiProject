namespace MauiProject;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Lb6Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new LB6());
    }

    private void Lb7Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new LB7());
    }

    private void Mtw2Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new MTW2());
    }
}