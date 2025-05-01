namespace MauiProject;
public class Student
{
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (value.Length < 4)
                throw new ArgumentException("First name must be at least 4 characters long");

            _firstName = value;
        }
    }

    private string _lastName;
    public string LastName
    {
        get { return _lastName; }
        set
        {
            if(value.Length < 4)
                throw new ArgumentException("Last name must be at least 4 characters long");

            _lastName = value;
        }
    }

    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Invalid age");

            _age = value;
        }
    }

    private string _group;
    public string Group
    {
        get { return _group; }
        set
        {
            if (value.Length < 4)
                throw new ArgumentException("Group must be at least 4 characters long");

            _group = value;
        }
    }

    private string _major;
    public string Major
    {
        get { return _major; }
        set { _major = value; }
    }

    private double _rating;
    public double Rating
    {
        get { return _rating; }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Rating must be between 0 and 100");

            _rating = value;
        }
    }

    private String _sex;
    public String Sex
    {
        get { return _sex; }
        set { _sex = value; }
    }

    public void GetInfo()
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Info about object: ");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("First name: {0}", FirstName);
        Console.WriteLine("Last name: {0}", LastName);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Group: {0}", Group);
        Console.WriteLine("Major: {0}", Major);
        Console.WriteLine("Rating: {0}", Rating);
        Console.WriteLine("Sex: {0}", Sex);
    }
}
