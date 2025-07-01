using System.Data;
using Dapper;
using DapperSolution.Models;
using DapperSolution.Util;

namespace DapperSolution.Repository;

public class StudentRepository
{
    private static IDbConnection OpenConnection()
    {
        IDbConnection? connection = null;
        try
        {
            connection = DatabaseConnection.GetConnection();
            connection.Open();
            return connection;
        }
        catch
        {
            connection?.Dispose();
            throw;
        }
    }
    
    
    public void Add(Student student)
    {
        OpenConnection().Execute("INSERT INTO Students(Name) VALUES (@Name)", student);
        OpenConnection().Close();
    }
    
    public void Update(Student student)
    {
        using IDbConnection connection = DatabaseConnection.GetConnection();
        connection.Open();
        connection.Execute("UPDATE Students SET Name = @Name WHERE Id = @Id", student);
    }

    public void Delete(Student student)
    {
        var connection = DatabaseConnection.GetConnection();
        connection.Open();
        connection.Execute("DELETE FROM Students WHERE Id = @Id", student);
    }

    public Task<Student?> GetByIdAsync(int id)
    {
        var connection = DatabaseConnection.GetConnection();
        connection.Open();
        return connection.QuerySingleOrDefaultAsync<Student>($"SELECT * FROM Students WHERE Id = {id}", id);
    }

    public Student? GetById(int id)
    {
       return OpenConnection().QuerySingleOrDefault<Student>($"SELECT * FROM Students WHERE Id = {id}", id);
    }

    public List<Student> GetAll()
    {
        using var connection = DatabaseConnection.GetConnection();
        connection.Open();
        return connection.Query<Student>("SELECT * FROM Students").ToList();
    }

    public List<Student> GetStudentsByTeacherId(int teacherId)
    {
        using var connection = DatabaseConnection.GetConnection();
        connection.Open();
        return connection
            .Query<Student>(
                "SELECT S.Id, S.Name FROM Students S " +
                     "INNER JOIN StudentTeacher ST on ST.StudentsId = S.Id " + 
                    $"INNER JOIN dbo.Teachers T on St.TeachersId = T.Id WHERE T.Id = {teacherId}").ToList();
    }
}