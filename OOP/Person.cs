using System.Runtime.Serialization;

namespace OOP;

// 9 : 27

public static class Person
{
    public const int Age = 12;

    public static int Min(int number, int secondNumber)
    {
        return number > secondNumber ? secondNumber : number;
    }
}