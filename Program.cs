namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            // Add default values to the list
            students.Add(new Student { Id = 1, Name = "Nikhil", PhoneNumber = "9767158167", Address = "Nanded", Age = 23 });
            students.Add(new Student { Id = 2, Name = "mogu", PhoneNumber = "7896654123", Address = "Kashmir", Age = 17 });
            students.Add(new Student { Id = 3, Name = "Adesh", PhoneNumber = "321654987", Address = "Hingoli", Age = 18 });
            students.Add(new Student { Id = 4, Name = "Nakul", PhoneNumber = "321654789", Address = "kandhar", Age = 14 });
            students.Add(new Student { Id = 5, Name = "Chunchu", PhoneNumber = "789456123", Address = "Sambhajinagar", Age = 20 });

            // Display all student details
            Console.WriteLine("All Student Details:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }

            //Retrieve all records from the list for age between 12 to 18 
            var ageFilteredStudents = students.Where(student => student.Age >= 12 && student.Age <= 18);
            Console.WriteLine("\nStudents between the age of 12 and 18:");
            foreach (var student in ageFilteredStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }


            // Sort students data in descending order based on TotalMarks (not mentioned in the Student class)
            var sortedStudents = students.OrderByDescending(student => student.Age);
            Console.WriteLine("\nStudents sorted by age in descending order:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }
        }
    }
}