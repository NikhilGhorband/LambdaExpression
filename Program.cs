namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            // Add default values to the list
            students.Add(new Student { Id = 1, Name = "Nikhil", PhoneNumber = "789456", Address = "nanded", Age = 25 });
            students.Add(new Student { Id = 2, Name = "Adesh", PhoneNumber = "123654", Address = "hingoli", Age = 23 });
            students.Add(new Student { Id = 3, Name = "Mogu", PhoneNumber = "456789", Address = "kashmir", Age = 14 });
            students.Add(new Student { Id = 4, Name = "Chunchu", PhoneNumber = "789456", Address = "Sambhajinagar", Age = 17 });
            students.Add(new Student { Id = 5, Name = "Nakul", PhoneNumber = "987654", Address = "Latur", Age = 16 });

            // Display all student details
            Console.WriteLine("All Student Details:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }

            //Retrieve all records from the list for age between 12 to 18 using LINQ
            var ageFilteredStudents = students.Where(student => student.Age >= 12 && student.Age <= 18);
            Console.WriteLine("\nStudents between the age of 12 and 18:");
            foreach (var student in ageFilteredStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }
        }
    }


}