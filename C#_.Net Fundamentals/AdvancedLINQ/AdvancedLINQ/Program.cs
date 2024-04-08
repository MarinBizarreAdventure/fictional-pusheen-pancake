using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        string[] colors = { "green", "brown", "blue", "red" };
        Console.WriteLine(colors.Where(c => c.Length >4).OrderBy;


        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", CourseId = 101, Grade= 9 },
            new Student { Id = 2, Name = "Bob", CourseId = 102, Grade= 8 },
            new Student { Id = 3, Name = "Charlie", CourseId = 101, Grade= 2 },
            new Student { Id = 4, Name = "David", CourseId = 103, Grade= 4 }
        };

        List<Student> students1 = new List<Student>
        {
            new Student { Id = 5, Name = "Emma", CourseId = 101, Grade= 9 },
            new Student { Id = 6, Name = "Tanmay", CourseId = 102, Grade= 7 },
            new Student { Id = 7, Name = "Ionel", CourseId = 101, Grade= 10 },
            new Student { Id = 4, Name = "David", CourseId = 103, Grade= 7 }
        };

        List<Course> courses = new List<Course>
        {
            new Course { Id = 101, Name = "Math" },
            new Course { Id = 102, Name = "Science" },
            new Course { Id = 103, Name = "History" }
        };

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(n => n%2 == 0) // Returns { 2, 4, 6, 8, 10 }


        var squaredNumbers = numbers.Select(n => n * n);
        var orderedNumbers = numbers.OrderBy(n => n);
        var 

        var aggregate = students.Aggregate(new List<Student>(), (accumulator, currentStudent) =>
        {
            if(currentStudent.Grade >= 7)
            {
                accumulator.Add(currentStudent);
            }
            return accumulator;
        });

        foreach (var item in aggregate)
        {
            Console.WriteLine($"Student: {item.Name}, Course: {item.Grade}");
        }
        // Join 
        var join = students.Join(
            courses,
            student => student.CourseId,
            course => course.Id,
            (student, course) => new
            {
                StudentName = student.Name,
                CourseName = course.Name,
            }
            );

        foreach (var item in join)
        {
            Console.WriteLine($"Student: {item.StudentName}, Course: {item.CourseName}");
        }


        //Linq Set
        Console.WriteLine("All Students:");
        var union = students.Union(students1).ToList();
        foreach (var item in union)
        {
            Console.WriteLine($"Student: {item.Name}");
        }

        //Linq conversion
        var unionArray = union.ToArray();
        Console.WriteLine($"Is array :{unionArray.GetType().IsArray}");

        //Linq Aggregation
        var count = students.Union(students1).Count();
        Console.WriteLine($"number of students :{count}");

        //Linq quantifiers
        var any = students.Union(students1).Any(student => student.Name == "Ionel");
        Console.WriteLine($"is there student ionel :{any}");

        //Linq Element enumerators
        var firstOrDefault = students.Union(students1).FirstOrDefault(student => student.Name == "Ionel");
        Console.WriteLine($"is there student ionel :{firstOrDefault.Name}");


        //Linq generation
        var range = Enumerable.Range(1,10);
        Console.Write($"Range: ");
        range.ToList().ForEach(num => Console.Write($"{num}, "));
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CourseId { get; set; }
    public int Grade { get; set; }
}

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
}
