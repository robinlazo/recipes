using System.Linq.Expressions;

namespace WebRecipe.Models;

public class QueryOptions<T>
{
    public string OrderByDirection { get; set; } = "asc";
    public Expression<Func<T, Object>> OrderBy { get; set; }

    private string[] includes { get; set; }

    public string Includes {
        set {
            includes = value.Replace(" ", "").Split(",");
        }
    }

    public string[] GetIncludes() => includes ?? new string[0];
    public WhereList<T> WhereClauses { get; set; }

    public Expression<Func<T, bool>> Where {
        set {
            if(WhereClauses == null) WhereClauses = new WhereList<T>();

            WhereClauses.Add(value);
        } 
    }

    public bool HasWhere => WhereClauses != null;
    public bool HasOrderBy => OrderBy != null;
}


public class WhereList<T> : List<Expression<Func<T, bool>>>{}