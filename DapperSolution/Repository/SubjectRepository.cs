using DapperSolution.Models;

namespace DapperSolution.Repository;

public class SubjectRepository : IBaseEntity<Subject, int>
{
    public void Add(Subject subject)
    {
        throw new NotImplementedException();
    }

    public void Update(Subject t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Subject t)
    {
        throw new NotImplementedException();
    }

    public Task<Subject?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Subject GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Subject> GetAll()
    {
        throw new NotImplementedException();
    }
}