using DapperSolution.Models;

namespace DapperSolution.Repository;

public class TeacherRepository : IBaseEntity<Teacher, int>
{
    public void Add(Teacher teacher)
    {
        throw new NotImplementedException();
    }

    public void Update(Teacher t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Teacher t)
    {
        throw new NotImplementedException();
    }

    public Task<Teacher?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Teacher GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Teacher> GetAll()
    {
        throw new NotImplementedException();
    }
}