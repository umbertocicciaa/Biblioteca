namespace Biblioteca.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        T Add(T entity);
        T Update(T entity);
        bool Delete(object id);
    }
}
