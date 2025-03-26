namespace MauiProject;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Task1Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Task1());
    }
}