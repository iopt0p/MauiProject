namespace MauiProject;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Lb6Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Task1());
        Navigation.PushAsync(new LB6());
    }
}