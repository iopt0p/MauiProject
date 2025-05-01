using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Maui.Views;

namespace MauiProject;

public partial class StudentPopup : Popup
{
    public Student Student;

    public StudentPopup(Student student)
    {
        InitializeComponent();

        Student = student;
        SetEntryValues();
    }

    private void SetEntryValues()
    {
        FirstNameEntry.Text = Student.FirstName;
        LastNameEntry.Text = Student.LastName;
        AgeEntry.Text = Student.Age.ToString();
        GroupEntry.Text = Student.Group;
        MajorEntry.Text = Student.Major;
        RatingEntry.Text = Student.Rating.ToString();
        SexEntry.Text = Student.Sex;
    }

    private void NumberEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(e.NewTextValue)) return;

        if (!double.TryParse(e.NewTextValue, out double value))
        {
            ((Entry) sender).Text = e.OldTextValue;
        }
    }

    private void OkButton_OnClicked(object? sender, EventArgs e)
    {
        try
        {
            Student.FirstName = FirstNameEntry.Text;
            Student.LastName = LastNameEntry.Text;
            Student.Age = int.Parse(AgeEntry.Text);
            Student.Group = GroupEntry.Text;
            Student.Major = MajorEntry.Text;
            Student.Rating = double.Parse(RatingEntry.Text);
            Student.Sex = SexEntry.Text;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }

        var cts = new CancellationTokenSource();
        CloseAsync(true, cts.Token);
    }

    private void CancelButton_OnClicked(object? sender, EventArgs e)
    {
        var cts = new CancellationTokenSource();
        CloseAsync(false, cts.Token);
    }
}
