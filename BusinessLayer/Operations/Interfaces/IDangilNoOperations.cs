using MetalixDemoErp.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Operations.Interfaces
{
    public interface IDangilNoOperations : IBaseOperations<DangilNo>
    {
        List<DangilNo> GetCompanyListWithDangil();
    }
}
