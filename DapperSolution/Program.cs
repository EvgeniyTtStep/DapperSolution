using DapperSolution.Models;
using DapperSolution.Repository;

class Program
{
    public static void Main(string[] args)
    {
        StudentRepository studentRepository = new StudentRepository();

        // repository.AddStudent(new Student(){Name = "Luka"});
        // repository.AddStudent(new Student(){Name = "Max"});
        // repository.AddStudent(new Student(){Name = "Bob"});
        // repository.AddStudent(new Student(){Name = "Zak"});


        //studentRepository.Update(new Student() { Id = 3, Name = "KevinBrandNew" });

        //List<Student> students = studentRepository.GetAll();

        //foreach (var student in students)
        //{
        //     Console.WriteLine("Student: " + student.Name);
        // }

        // Student studentKevin = studentRepository.GetByIdAsync(4).Result;

        // studentRepository.Delete(new Student() { Id = studentKevin.Id, Name = studentKevin.Name });

        Console.WriteLine("=======================================");

        List<Student> students1 = studentRepository.GetAll();

        foreach (var student in students1)
        {
            Console.WriteLine("Student: " + student.Name);
        }

        Console.WriteLine("=======================================");

        Student studentById = studentRepository.GetById(3);

        Console.WriteLine("Student: \n" + " Id: " + studentById.Id + ", Name: " + studentById.Name);

        Console.WriteLine("=======================================");

        List<Student> students = studentRepository.GetStudentsByTeacherId(1);

        foreach (var student in students)
        {
            Console.WriteLine("Student by teacher: " + student.Id + " " + student.Name);
        }
    }
}