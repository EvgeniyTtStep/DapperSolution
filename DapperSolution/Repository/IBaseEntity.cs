namespace DapperSolution.Repository;

public interface IBaseEntity<T, ID>
{
    public void Add(T t);
    public void Update(T t);
    public void Delete(T t);
    public Task<T?> GetByIdAsync(ID? id);
    public T GetById(int id);
    public List<T> GetAll();
    
}