using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", CourseId = 101 },
            new Student { Id = 2, Name = "Bob", CourseId = 102 },
            new Student { Id = 3, Name = "Charlie", CourseId = 101 },
            new Student { Id = 4, Name = "David", CourseId = 103 }
        };

        List<Student> students1 = new List<Student>
        {
            new Student { Id = 5, Name = "Emma", CourseId = 101 },
            new Student { Id = 6, Name = "Tanmay", CourseId = 102 },
            new Student { Id = 7, Name = "Ionel", CourseId = 101 },
            new Student { Id = 4, Name = "David", CourseId = 103 }
        };

        List<Course> courses = new List<Course>
        {
            new Course { Id = 101, Name = "Math" },
            new Course { Id = 102, Name = "Science" },
            new Course { Id = 103, Name = "History" }
        };


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
}

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
}
