namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
        {
            new Student { Id = 1, Name = "Nikhil", PhoneNumber = "", Address = "Nanded", Age = 23 },
            new Student { Id = 2, Name = "Balu", PhoneNumber = "9110543024", Address = "Hyderabad", Age = 24 },
            new Student { Id = 3, Name = "Adesh", PhoneNumber = "9535195902", Address = "Hingoli", Age = 25 }
        };

            Console.WriteLine("Student Details:");
            studentList.ForEach(student =>
            {
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Phone Number: {student.PhoneNumber}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine();
            });
        }
    }

}