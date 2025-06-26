using DapperSolution.Models;
using DapperSolution.Repository;

class Program
{
    public static void Main(string[] args)
    {
        StudentRepository repository = new StudentRepository();
        
        // repository.AddStudent(new Student(){Name = "Luka"});
        // repository.AddStudent(new Student(){Name = "Max"});
        // repository.AddStudent(new Student(){Name = "Bob"});
        // repository.AddStudent(new Student(){Name = "Zak"});
        
        
        repository.UpdateStudent(new Student(){Id = 5,  Name = "Kevin"});
    }
}