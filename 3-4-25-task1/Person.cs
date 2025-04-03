namespace ConsoleApp;

internal class Person
{
    #region constructors
    public Person(string? name, string? surname, string? username, string? passsword, DateOnly birthday)
    {
        Name = name;
        Surname = surname;
        Username = username;
        Passsword = passsword;
        Birthday = birthday;
    }
    #endregion

    #region fields
    private string? _name;
    private string? _surname;
    private string? _username;
    private string? _passsword;
    private DateOnly _birthday;
    #endregion

    #region properties
    public string? Name
    {
        get => _name;
        set
        {
            if (value.IsAlpha())
                _name = value.Capitalize();
            throw new Exception();
        }
    }
    public string? Surname
    {
        get => _surname;
        set
        {
            if (value.IsAlpha())
                _surname = value.Capitalize();
            throw new Exception();
        }
    }
    public string? Username
    {
        get => _username;
        set
        {
            if (value.IsValidUsername())
                _username = value.Capitalize();
            throw new Exception();
        }
    }
    public string? Passsword
    {
        get => _passsword;
        set
        {
            if (value.IsValidPassword())
                _passsword = value;
            throw new Exception();
        }
    }
    public DateOnly Birthday
    {
        get => _birthday;
        init
        {
            if (value.IsValidDate())
                _birthday = value;
            throw new Exception();
        }
    }
    public byte Age => (byte)(DateTime.Now.Year - Birthday.Year);

    #endregion

    public override string ToString() => $"Name: {Name}\nSurname: {Surname}\nUsername: {Username}\nAge: {Age}";

}
