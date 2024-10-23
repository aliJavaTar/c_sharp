namespace OOP;

public class Test
{
    private List<Employee> GetEmployees()
    {
        List<Employee> employees =
        [
            new("one", 35, "HR"),
            new("Jane", 35, "Engineering"),
            new("ali", 32, "Engineering"),
            new("ali", 32, "HR"),
            new("ali", 32, "36"),
            new("Ali", 26, "HR"),
        ];
        return employees;
    }


    private class Employee
    {
        public Employee()
        {
        }

        public Employee(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}, {nameof(Department)}: {Department}";
        }
    }

    public void PrintEmployees()
    {

        var employees = GetEmployees().GroupBy(employee => new { employee.Age });
        
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Key.Age  + ", cout:  " + employee.Count());
        }
    }
}