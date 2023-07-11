using MetalixDemoErp.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Operations.Interfaces
{
    public interface IBaseOperations<TSource>
    {
        void TAdd(TSource t);
        void TDelete(TSource t);
        void TUpdate(TSource t);
        List<TSource> GetList();
        TSource TGetById(int id);

       
    }
}
