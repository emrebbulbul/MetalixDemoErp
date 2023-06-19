using MetalixDemoErp.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Common
{
    public class BaseRepository<TSource> : IBaseRepository<TSource> where TSource : class
    {
        public void Delete(TSource t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public TSource GetById(int id)
        {
            using var c = new Context();
            return c.Set<TSource>().Find(id);
        }

        public List<TSource> GetListAll()
        {
            using var c = new Context();
            return c.Set<TSource>().ToList();
        }

        public List<TSource> GetListAll(Expression<Func<TSource, bool>> filter)
        {
            using var c = new Context();
            return c.Set<TSource>().Where(filter).ToList();
        }

        public void Insert(TSource t)
        {
           using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(TSource t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();    
        }
    }
}
