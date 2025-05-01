using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Views;

namespace MauiProject;

public partial class LB7 : ContentPage
{
    public Student Student;

    public LB7()
    {
        InitializeComponent();
        Student = new Student();
    }

    private async void AddStudent(object? sender, EventArgs e)
    {
        var popup = new StudentPopup(Student);
        var result = await this.ShowPopupAsync(popup, CancellationToken.None);

        if (result is bool boolResult)
        {
            if (boolResult)
            {
                SetStudentInfo();
            }
        }
    }

    private void SetStudentInfo()
    {
        StudentInfoLabel.Text = "";
        StudentInfoLabel.Text += Student.FirstName + " " + Student.LastName + System.Environment.NewLine;
        StudentInfoLabel.Text += Student.Age + System.Environment.NewLine;
        StudentInfoLabel.Text += Student.Group + System.Environment.NewLine;
        StudentInfoLabel.Text += Student.Major + System.Environment.NewLine;
        StudentInfoLabel.Text += Student.Rating + System.Environment.NewLine;
        StudentInfoLabel.Text += Student.Sex.ToString() + System.Environment.NewLine;
    }

    private void QuitApp(object? sender, EventArgs e)
    {
        Application.Current?.Quit();
    }
}