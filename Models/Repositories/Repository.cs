using Microsoft.EntityFrameworkCore;
namespace WebRecipe.Models;

public class Repository<T> : IRepository<T> where T : class {

    private DbSet<T> dbset { get; set; }
    protected RecipeContext Context { get; set; }
    public Repository(RecipeContext context) {
        Context = context;
        dbset = Context.Set<T>();
    }
    public virtual void Insert(T entity) => dbset.Add(entity);
    public virtual void Delete(T entity) => dbset.Remove(entity);
    public virtual void Update(T entity) => dbset.Update(entity);
    public virtual T Get(int id) => dbset.Find(id);

    public virtual T Get(QueryOptions<T> options) {
        var query = BuildQuery(options);
        return query.FirstOrDefault();
    }

    public virtual void Save() => Context.SaveChanges();

    public virtual IEnumerable<T> List(QueryOptions<T> options) {
        var query = BuildQuery(options);
        return query.ToList();
    }

    private IQueryable<T> BuildQuery(QueryOptions<T> options) {
        IQueryable<T> query = dbset;

        foreach(string include in options.GetIncludes()) {
            query = query.Include(include);
        }

        if(options.HasWhere) {
            foreach(var clause in options.WhereClauses) {
                query = query.Where(clause);
            }
        }

        if(options.HasOrderBy) {
            if(options.OrderByDirection == "asc") query = query.OrderBy(options.OrderBy);
            else query = query.OrderByDescending(options.OrderBy);
        }

        return query;
    }
} 