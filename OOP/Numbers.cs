namespace OOP;

public class Numbers
{
    private List<int> GetNumbers()
    {
        return [..Enumerable.Range(1, 50)];
    }

    public void PrintNumbers()
    {
        var intsEnumerable = GetNumbers().Chunk(20);
        foreach (var variable in intsEnumerable)
        {
            foreach (var number in variable)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-------------");
        }
    }
}