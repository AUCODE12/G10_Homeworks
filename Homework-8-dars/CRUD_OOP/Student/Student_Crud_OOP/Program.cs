using Student_Crud_OOP.Models;
using Student_Crud_OOP.Services;

namespace Student_Crud_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        {
            var studentServices = new StudentServices();

            while (true)
            {
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Update student");
                Console.WriteLine("3. Delete student");
                Console.WriteLine("4. Get student");
                Console.WriteLine("5. GetByID student");

                Console.Write("Enter choose: ");
                var option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    var student = new Student();
                    Console.Write("First Name: ");
                    student.FirstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    student.LastName = Console.ReadLine();
                    Console.Write("Age: ");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.Write("Phone Number: ");
                    student.PhoneNumber = Console.ReadLine();

                    studentServices.AddStudent(student);
                }
                else if (option == 2)
                {
                    var student = new Student();
                    Console.Write("Enter id to update: ");
                    student.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("First Name: ");
                    student.FirstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    student.LastName = Console.ReadLine();
                    Console.Write("Age: ");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.Write("Phone Number: ");
                    student.PhoneNumber = Console.ReadLine();

                    var result = studentServices.UpdateStudent(student);

                    if (result is true)
                    {
                        Console.WriteLine("Updated");
                    }
                    else
                    {
                        Console.WriteLine("Not updated");
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Enter Id to delete: ");
                    var id = Guid.Parse(Console.ReadLine());
                    var requestDelete = studentServices.DeleteStudent(id);
                    if (requestDelete is true)
                    {
                        Console.WriteLine("Deleted");
                    }
                    else
                    {
                        Console.WriteLine("Not deleted");
                    }
                }
                else if (option == 4)
                {
                    var students = studentServices.GetAllStudents();
                    foreach (var student in students)
                    {
                        var info = $"Id: {student.Id}, First Name: {student.FirstName}, Last Name: {student.LastName}, Age: {student.Age}, Phone Number: {student.PhoneNumber}";
                        Console.WriteLine($"{info}");
                    }
                }
                else if (option == 5)
                {
                    Console.Write("Enter id to getId: ");
                    var id = Guid.Parse(Console.ReadLine());
                    var student = studentServices.GetById(id);
                    var info = $"Id: {student.Id}, First Name: {student.FirstName}, Last Name: {student.LastName}, Age: {student.Age}, Phone Number: {student.PhoneNumber}";
                    Console.WriteLine($"{info}");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
