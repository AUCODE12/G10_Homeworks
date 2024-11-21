using Student_Crud_OOP.Models;

namespace Student_Crud_OOP.Services;

internal class StudentServices
{
    private List<Student> students;

    public StudentServices()
    {
        students = new List<Student>();
        DataSeed();
    }

    public Student AddStudent(Student student)
    {
        student.Id = Guid.NewGuid();
        students.Add(student);

        return student;
    }

    public bool DeleteStudent(Guid studentId)
    {
        var exists = false;
        foreach (var student in students)
        {
            if (student.Id == studentId)
            {
                exists = true;
                break;
            }
        }

        return exists;
    }

    public bool UpdateStudent(Student updateStudent)
    {
        for (var i = 0; i < students.Count; i++)
        {
            if (students[i].Id == updateStudent.Id)
            {
                students[i] = updateStudent;
                return true;
            }
        }

        return false;
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }

    public Student GetById(Guid studentId)
    {
        foreach (var student in students)
        {
            if (student.Id == studentId)
            {
                return student;
            }
        }

        return null;
    }

    private void DataSeed()
    {
        var firstStudent = new Student()
        {
            Id = Guid.NewGuid(),
            FirstName = "Ahmadjon",
            LastName = "Qudratov",
            Age = 17,
            PhoneNumber = "+998907390610",
        };
        var secondStudent = new Student()
        {
            Id = Guid.NewGuid(),
            FirstName = "Tohir",
            LastName = "Rustamov",
            Age = 24,
            PhoneNumber = "+998914343487",
        };
        var thirdStudent = new Student()
        {
            Id = Guid.NewGuid(),
            FirstName = "Akobir",
            LastName = "Abdubakirov",
            Age = 32,
            PhoneNumber = "+998885842719",
        };
        
        students.Add(firstStudent);
        students.Add(secondStudent);
        students.Add(thirdStudent);
    }
}
