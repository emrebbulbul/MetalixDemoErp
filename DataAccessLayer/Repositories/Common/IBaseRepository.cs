using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Common
{
    public interface IBaseRepository<TSource> where TSource : class
    {
        void Insert(TSource t);
        void Update(TSource t);
        void Delete(TSource t);
        List<TSource> GetListAll();

        TSource GetById(int id);

        List<TSource> GetListAll(Expression<Func<TSource, bool>> filter);
    }
}
