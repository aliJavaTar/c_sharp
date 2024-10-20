namespace OOP;

public struct Employ
{
    private uint _age;
    private string _name;

    public void SetAge(uint age)
    {
        if (age < 18) _age = age;
    }

    public void SetName(string name)
    {
        if (name.Length == 0)
        {
            throw new ArgumentException("Name cannot be empty");
        }

        _name = name;
    }

    public string GetName() => _name;
}