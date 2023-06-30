namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student { Id = 1, Name = "Nikhil", PhoneNumber = "9767158167", Address = "Nanded", Age = 25 });
            students.Add(new Student { Id = 2, Name = "mogu", PhoneNumber = "7896654123", Address = "Kashmir", Age = 23 });
            students.Add(new Student { Id = 3, Name = "Adesh", PhoneNumber = "321654987", Address = "Hingoli", Age = 18 });
            students.Add(new Student { Id = 4, Name = "Nakul", PhoneNumber = "321654789", Address = "kandhar", Age = 14 });
            students.Add(new Student { Id = 5, Name = "Chunchu", PhoneNumber = "789456123", Address = "Sambhajinagar", Age = 16 });

            
            
            // Search for a particular student based on name using lambda expression

            var searchName = "Nikhil" + "";
            var searchedStudent = students.FirstOrDefault(student => student.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (searchedStudent != null)
            {
                Console.WriteLine($"\nStudent found - Id: {searchedStudent.Id}, Name: {searchedStudent.Name}, Phone Number: {searchedStudent.PhoneNumber}, Address: {searchedStudent.Address}, Age: {searchedStudent.Age}");
            }
            else
            {
                Console.WriteLine($"\nStudent with name '{searchName}' not found.");
            }
        }
    }

}