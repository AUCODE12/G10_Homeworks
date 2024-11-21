namespace Student_Crud_OOP.Models;

internal class Student
{
    public Guid Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    public int Age { get; set; }

    public string PhoneNumber { get; set; }
}
