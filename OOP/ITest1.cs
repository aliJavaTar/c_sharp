namespace OOP;

public interface ITest1
{
    void F1();


    void F2()
    {
        Console.WriteLine("F2");
    }
}

public class Test1 : ITest1
{
    public void F1()
    {
        Console.WriteLine("test 1");
    }

    public void F2()
    {
        Console.WriteLine("test 1 in F 2");
    }
}

public class Test2 : ITest1
{
    public void F1()
    {
        Console.WriteLine("test 2");
    }
}