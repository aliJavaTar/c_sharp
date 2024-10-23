using OOP;


// List<Student> students =
// [
//     new() { Id = 1, Name = "Vinay Tyagi", Gender = "Male", Location = "Chennai" },
//     new() { Id = 2, Name = "Vaishali Tyagi", Gender = "Female", Location = "Chennai" },
//     new() { Id = 3, Name = "Montu Tyagi", Gender = "Male", Location = "Bangalore" },
//     new() { Id = 4, Name = "Akshay Tyagi", Gender = "Male", Location = "Vizag" },
//     new() { Id = 5, Name = "Arpita Rai", Gender = "Male", Location = "Nagpur" }
// ];
//
// var dictionary = students.ToDictionary(student => student.Id, student => student.Gender == "Female" ? "Male" : "Female");
// foreach (var keyValuePair in dictionary)
// {
//     Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
// }

// public class Student
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
//     public string? Gender { get; set; }
//     public string? Location { get; set; }
//
//     public override string ToString()
//     {
//         return
//             $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Gender)}: {Gender}, {nameof(Location)}: {Location}";
//     }
// }

// List<string> productNames = ["Laptop", "Smartphone", "Headphones", "Monitor"];
//
//
// List<decimal> productPrices = [1200.99M, 799.49M, 199.99M, 350.00M];
// var productDict = productNames.ToDictionary<string,int>((index, item)) => new { Key = index, Value = item });
// productNames.ToDictionary<string, int>((item, index) => new { key = index, value = item });

// productNames.Zip(productPrices, (productName, price) => $"name of product : {productName}  price is : {price}").ToList()
//     .ForEach(Console.WriteLine);


// List<string> students = ["ali", "mohamad", "gholam", "majid", "mohsen"];
// List<int> scores = [85, 90,20,23,34,545,656,767,678];
//
//  students.Zip(scores, (student, score) => "name of student is: " + student + "  score: " + score)
//   .ToList().ForEach(Console.WriteLine);
// string[] words = ["apples", "blueberries", "oranges", "bananas", "apricots"];
//
//
// // Create the query.
// var wordGroups1 =
//     from w in words
//     group w by w[0] into fruitGroup
//     where fruitGroup.Count() >= 2
//     select new { FirstLetter = fruitGroup.Key, Words = fruitGroup.Count() };
//
// // Execute the query. Note that we only iterate over the groups,
// // not the items in each group
// foreach (var item in wordGroups1)
// {
//     Console.WriteLine(" {0} has {1} elements.", item.FirstLetter, item.Words);
// }


// List<Student> students = new List<Student>
// {
//     new Student { Id = 1, Name = "Alice" },
//     new Student { Id = 2, Name = "Bob" },
//     new Student { Id = 3, Name = "Charlie" }
// };
//
// List<Course> courses = new List<Course>
// {
//     new Course { Id = 1, Title = "Math", TeacherId = 1 },
//     new Course { Id = 2, Title = "Science", TeacherId = 2 },
//     new Course { Id = 3, Title = "History", TeacherId = 1 }
// };
//
// List<Teacher> teachers = new List<Teacher>
// {
//     new Teacher { Id = 1, Name = "Mr. Smith" },
//     new Teacher { Id = 2, Name = "Ms. Johnson" }
// };
//
// List<Enrollment> enrollments = new List<Enrollment>
// {
//     new Enrollment { StudentId = 1, CourseId = 1 },
//     new Enrollment { StudentId = 2, CourseId = 1 },
//     new Enrollment { StudentId = 1, CourseId = 2 },
//     new Enrollment { StudentId = 3, CourseId = 3 }
// };
//
// var courseReportQuery = from course in courses
//     join teacher in teachers on course.TeacherId equals teacher.Id
//     join enrollment in enrollments on course.Id equals enrollment.CourseId
//     join student in students on enrollment.StudentId equals student.Id
//     group student by new { course.Title, teacher.Name } into courseGroup
//     select new
//     {
//         CourseTitle = courseGroup.Key.Title,
//         TeacherName = courseGroup.Key.Name,
//         StudentCount = courseGroup.Count(),
//         Students = courseGroup.ToList()
//     };
//
// foreach (var course in courseReportQuery)
// {
//     Console.WriteLine($"Course: {course.CourseTitle}, Teacher: {course.TeacherName}, Students Enrolled: {course.StudentCount}");
//     Console.WriteLine("Student Names: " + string.Join(", ", course.Students));
// }
//
//
//
//
// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
// }
//
// public class Course
// {
//     public int Id { get; set; }
//     public string Title { get; set; }
//     public int TeacherId { get; set; }
// }
//
// public class Teacher
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
// }
//
// public class Enrollment
// {
//     public int StudentId { get; set; }
//     public int CourseId { get; set; }
// }

// List<Student> students =
// [
//     new() { Id = 1, Name = "Alice" },
//     new() { Id = 2, Name = "Bob" },
//     new() { Id = 3, Name = "Charlie" }
// ];
//
// List<Course> courses =
// [
//     new() { Id = 1, Title = "Mathematics", InstructorId = 1 },
//     new() { Id = 2, Title = "Physics", InstructorId = 2 },
//     new() { Id = 3, Title = "Chemistry", InstructorId = 1 }
// ];
//
// List<Instructor> instructors =
// [
//     new() { Id = 1, Name = "Dr. Smith" },
//     new() { Id = 2, Name = "Dr. Johnson" }
// ];
//
// List<Enrollment> enrollments =
// [
//     new() { Id = 1, StudentId = 1, CourseId = 1 },
//     new() { Id = 2, StudentId = 1, CourseId = 3 },
//     new() { Id = 3, StudentId = 2, CourseId = 2 },
//     new() { Id = 4, StudentId = 3, CourseId = 1 }
// ];
//
//
// var query = from enrollment in enrollments
//     join student in students on enrollment.StudentId equals student.Id
//     join course in courses on enrollment.CourseId equals course.Id
//     join instructor in instructors on course.InstructorId equals instructor.Id
//     select new
//     {
//         StudentName = student.Name,
//         CourseTitle = course.Title,
//         InstructorName = instructor.Name
//     };
//
// foreach (var variable in query)
// {
//     Console.WriteLine(variable.StudentName + ", " + variable.CourseTitle + ", " + variable.InstructorName);
// }
//
// public class Student
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
// }
//
// public class Course
// {
//     public int Id { get; set; }
//     public string? Title { get; set; }
//     public int InstructorId { get; set; } // Foreign key to Instructor
// }
//
// public class Instructor
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
// }
//
// public class Enrollment
// {
//     public int Id { get; set; }
//     public int StudentId { get; set; }
//     public int CourseId { get; set; }
// }


// List<Employee> employees = new List<Employee>
// {
//     new Employee { Id = 1, Name = "John", DepartmentId = 1 },
//     new Employee { Id = 2, Name = "Sarah", DepartmentId = 2 },
//     new Employee { Id = 3, Name = "Bob", DepartmentId = 1 }
// };
//
// List<Department> departments = new List<Department>
// {
//     new Department { Id = 1, DepartmentName = "HR" },
//     new Department { Id = 2, DepartmentName = "IT" }
// };
//
// var query = from employee in employees
//     join department in departments on employee.DepartmentId equals department.Id
//     select new
//     {
//         departmentName = department.DepartmentName,
//         employeeName = employee.Name
//     };
// foreach (var item in query)
// {
//     Console.WriteLine($"{item.employeeName} works in {item.departmentName}");
// }
//
// Console.WriteLine("--------------");
//
// var result = departments.Join(employees,
//     employee => employee.Id,
//     department => department.Id,
//     (department, employee) => new
//     {
//         departmentName = department.DepartmentName,
//         employeeName = employee.Name
//     });
//
// foreach (var item in result)
// {
//     Console.WriteLine($"{item.employeeName} works in {item.departmentName}");
// }
//
//
// public class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int DepartmentId { get; set; }
// }
//
// public class Department
// {
//     public int Id { get; set; }
//     public string DepartmentName { get; set; }
// }
//

//
// List<Order> orders = new List<Order>
// {
//     new Order { Id = 1, CustomerId = 1, Product = "Laptop", OrderDate = DateTime.Now.AddDays(-2) },
//     new Order { Id = 2, CustomerId = 2, Product = "Smartphone", OrderDate = DateTime.Now.AddDays(-1) },
//     new Order { Id = 3, CustomerId = 1, Product = "Tablet", OrderDate = DateTime.Now }
// };
//
// List<Customer> customers = new List<Customer>
// {
//     new Customer { Id = 1, Name = "Alice" },
//     new Customer { Id = 2, Name = "Bob" },
//     new Customer { Id = 3, Name = "Charlie" }
// };
//
// var query = from customer in customers
//     join o in orders on customer.Id equals o.CustomerId
//     where o.OrderDate == DateTime.Now
//     select new
//     {
//         name = customer.Name,
//     };
//
// public class Order
// {
//     public int Id { get; set; }
//     public int CustomerId { get; set; }
//     public string Product { get; set; }
//     public DateTime OrderDate { get; set; }
// }
//
//
// public class Customer
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
// }


// List<Customer> customers = new List<Customer>
// {
//     new Customer { Id = 1, Name = "Alice" },
//     new Customer { Id = 2, Name = "Bob" },
//     new Customer { Id = 3, Name = "Charlie" }
// };
//
// List<Order> orders = new List<Order>
// {
//     new Order { Id = 1, CustomerId = 1, Product = "Laptop" },
//     new Order { Id = 2, CustomerId = 2, Product = "Smartphone" },
//     new Order { Id = 3, CustomerId = 1, Product = "Tablet" }
// };
//
//
// var queryJoinResult = from customer in customers
//     join order in orders on customer.Id equals order.CustomerId
//     select new
//     {
//         Name = customer.Name,
//         product = order.Product
//     };
//
// var result = customers.Join(
//     orders,
//     customer => customer.Id,
//     order => order.CustomerId,
//     (customer, order) => new
//     {
//         name = customer.Name,
//         product = order.Product
//     }
// );
//
// foreach (var variable in result)
// {
//     Console.WriteLine(variable.name);
// }
//
// public class Customer
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
// }
//
//
// public class Order
// {
//     public int Id { get; set; }
//     public int CustomerId { get; set; }
//     public string? Product { get; set; }
// }


// List<Employee> employees =
// [
//     new() { Id = 1, Name = "John", DepartmentId = 1 },
//     new() { Id = 2, Name = "Sarah", DepartmentId = 2 },
//     new() { Id = 3, Name = "Bob", DepartmentId = 1 }
// ];
//
// List<Department> departments =
// [
//     new() { Id = 1, DepartmentName = "HR" },
//     new() { Id = 2, DepartmentName = "IT" }
// ];
//
//
// var query = from employee in employees
//     join department in departments on employee.DepartmentId equals department.Id
//     select new
//     {
//         name = employee.Name,
//         departmentName = department.DepartmentName
//     };
//
//
//
// foreach (var variable in query)
// {
//     Console.WriteLine(variable.name);
// }
//
// public class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int DepartmentId { get; set; }
// }
//
//
// public class Department
// {
//     public int Id { get; set; }
//     public string DepartmentName { get; set; }
// }
//

// List<Customer> customers =
// [
//     new() { Id = 1, Name = "Alice" },
//     new() { Id = 2, Name = "Bob" },
//     new() { Id = 3, Name = "Charlie" }
// ];
//
//
// List<Order> orders =
// [
//     new(1, 1, "Laptop", DateTime.Now.AddDays(-2)),
//     new(2, 2, "Smartphone", DateTime.Now.AddDays(-1)),
//     new(3, 1, "Tablet", DateTime.Now)
// ];
//
//
// var query = from customer in customers
//     join order in orders on customer.Id equals order.CustomerId
//     where order.OrderDate >= DateTime.Now.AddDays(-1)
//     select new
//     {
//         name = customer.Name,
//         product = order.Product,
//         orderDate = order.OrderDate
//     };
//
//
// foreach (var variable in query)
// {
//     Console.WriteLine(variable);
// }
// // var query = from customer in customers
// //     join order in orders on customer.Id equals order.CustomerId
// //     select new
// //     {
// //         Name = customer.Name,
// //         product = order.Product,
// //     };
// // foreach (var customer in query)
// // {
// //     Console.WriteLine(customer.Name);
// // }
//
// // var enumerable = customers.Join(
// //     orders,
// //     customer => customer.Id,
// //     order => order.Id,
// //     (customer, order) => new
// //     {
// //         name = customer.Name,
// //         product = order.Product
// //     }
// // );
//
//
// public class Customer
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
// }
//
// public class Order(
//     int id,
//     int customerId,
//     string product,
//     DateTime orderDate)
// {
//     public int Id { get; set; } = id;
//     public int CustomerId { get; set; } = customerId;
//     public string Product { get; set; } = product;
//     public DateTime OrderDate { get; set; } = orderDate;
// }

// public class Order
// {
//     public int Id { get; set; }
//     public int CustomerId { get; set; }
//     public string? Product { get; set; }
// }

// List<User> users =
// [
//     new(1, Gender.Male, "ALI", 98),
//     new(2, Gender.Male, "ali", 25),
//     new(3, Gender.Female, "zahra", 35),
//     new(4, Gender.Male, "nima", 21),
//     new(5, Gender.Male, "gholam", 60),
//     new(6, Gender.Male, "mostafa", 25),
//     new(7, Gender.Female, "maedeh", 35),
//     new(8, Gender.Male, "milad", 14),
//     new(9, Gender.Male, "masoud", 50),
//     new(10, Gender.Female, "fatemeh", 27),
//     new(11, Gender.Female, "maryam", 40),
//     new(12, Gender.Female, "mohadese", 31)
// ];

// var query = users.GroupBy(user => user.Gender)
//     .Select(grouping => new { Gender = grouping.Key, Count = grouping.Count() });

// var any = Student.GetStudents().Select(student => student.Marks).Count(mark => mark > 7);
// Console.WriteLine(any);

// public class Student
//
// {
//     public Student()
//     {
//     }
//
//     private Student(int marks, string name)
//     {
//         Marks = marks;
//         Name = name;
//     }
//
//     public int Marks { get; set; }
//
//     public string Name { get; set; }
//
//     public static List<Student> GetStudents()
//
//     {
//         List<Student> students =
//         [
//             new(0, "Vaibhav"),
//             new(67, "Akash"),
//             new(78, "Anjali"),
//             new(89, "Rithik"),
//             new(98, "Harsh"),
//             new(89, "Anjali"),
//             new(90, "Akash"),
//             new(7, "Sameera"),
//             new(78, "Priya"),
//             new(82, "Harsh"),
//             new(0, "Vaibhav"),
//             new(78, "Anjali")
//         ];
//
//         return students;
//     }
// }

// internal class User
// {
//     public int Id { get; init; }
//     public string? Name { get; init; }
//     public int Age { get; init; }
//     public Gender Gender { get; init; }
//
//     public User()
//     {
//     }
//
//     public User(int id, Gender gender, string name, int age)
//     {
//         Id = id;
//         Name = name;
//         Age = age;
//         Gender = gender;
//     }
//
//
//     public override string ToString()
//     {
//         return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age} , {nameof(Gender)}: {Gender}";
//     }
// }

// public enum Gender
// {
//     Male,
//     Female
// }
// List<User> users =
// [
//     new(1, Gender.Male, "ALI", 98),
//     new(2, Gender.Male, "ali", 25),
//     new(3, Gender.Female, "zahra", 35),
//     new(4, Gender.Male, "nima", 21),
//     new(5, Gender.Male, "gholam", 60),
//     new(6, Gender.Male, "mostafa", 25),
//     new(7, Gender.Female, "maedeh", 35),
//     new(8, Gender.Male, "milad", 14),
//     new(9, Gender.Male, "masoud", 50),
//     new(10, Gender.Female, "fatemeh", 27),
//     new(11, Gender.Female, "maryam", 40),
//     new(12, Gender.Female, "mohadese", 31)
// ];

// var query = users.GroupBy(user => user.Gender)
//     .Select(grouping => new { Gender = grouping.Key, Count = grouping.Count() });

// var any = Student.GetStudents().Select(student => student.Marks).Count(mark => mark > 7);
// Console.WriteLine(any);

// public class Student
//
// {
//     public Student()
//     {
//     }
//
//     private Student(int marks, string name)
//     {
//         Marks = marks;
//         Name = name;
//     }
//
//     public int Marks { get; set; }
//
//     public string Name { get; set; }
//
//     public static List<Student> GetStudents()
//
//     {
//         List<Student> students =
//         [
//             new(0, "Vaibhav"),
//             new(67, "Akash"),
//             new(78, "Anjali"),
//             new(89, "Rithik"),
//             new(98, "Harsh"),
//             new(89, "Anjali"),
//             new(90, "Akash"),
//             new(7, "Sameera"),
//             new(78, "Priya"),
//             new(82, "Harsh"),
//             new(0, "Vaibhav"),
//             new(78, "Anjali")
//         ];
//
//         return students;
//     }
// }

// internal class User
// {
//     public int Id { get; init; }
//     public string? Name { get; init; }
//     public int Age { get; init; }
//     public Gender Gender { get; init; }
//
//     public User()
//     {
//     }
//
//     public User(int id, Gender gender, string name, int age)
//     {
//         Id = id;
//         Name = name;
//         Age = age;
//         Gender = gender;
//     }
//
//
//     public override string ToString()
//     {
//         return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age} , {nameof(Gender)}: {Gender}";
//     }
// }

// public enum Gender
// {
//     Male,
//     Female
// }
// foreach (var items in enumerable)
// {
//     Console.WriteLine(items.name + " - " + items.product);
// }