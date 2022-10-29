namespace WebRecipe.Models;

public interface IRepository<T> where T : class {

    IEnumerable<T> List(QueryOptions<T> options);
    T Get(int id);
    void Update(T entity);
    void Insert(T entity);

    void Delete(T entity);

    void Save();
}