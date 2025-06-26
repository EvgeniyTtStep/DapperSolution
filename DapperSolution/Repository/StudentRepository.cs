using System.Data;
using Dapper;
using DapperSolution.Models;
using DapperSolution.Util;

namespace DapperSolution.Repository;

public class StudentRepository
{
    public void AddStudent(Student student)
    {
        using IDbConnection connection = DatabaseConnection.GetConnection();
        connection.Open();
        connection.Execute("INSERT INTO Students(Name) VALUES (@Name)", student);
    }
    
    public void UpdateStudent(Student student)
    {
        using IDbConnection connection = DatabaseConnection.GetConnection();
        connection.Open();
        connection.Execute("UPDATE Students SET Name = @Name WHERE Id = @Id", student);
    }
}