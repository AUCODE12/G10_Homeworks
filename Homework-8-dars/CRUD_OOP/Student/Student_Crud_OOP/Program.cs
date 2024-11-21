using Student_Crud_OOP.Services;
using Student_Crud_OOP.Models;

namespace Student_Crud_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static void RunApp()
        {
            var studentServices = new StudentServices();
        
            while (true)
            {
                Console.Write("1. Add student");
                Console.Write("2. Update student");
                Console.Write("3. Delete student");
                Console.Write("4. Get student");
                Console.Write("5. GetByID student");

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

                }
                else if (option == 3)
                {

                }
                else if (option == 4)
                {

                }
                else if (option == 5)
                {

                }
            }
        }
    }
}
