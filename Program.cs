namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
        {
            new Student { Id = 1, Name = "mogu", PhoneNumber = "7896654123", Address = "Kashmir", Age = 23 },
            new Student { Id = 2, Name = "Adesh", PhoneNumber = "321654987", Address = "Hingoli", Age = 18 },
            new Student { Id = 3, Name = "Nakul", PhoneNumber = "321654789", Address = "kandhar", Age = 14 },
            new Student { Id = 4, Name = "Chunchu", PhoneNumber = "789456123", Address = "Sambhajinagar", Age = 16 }
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