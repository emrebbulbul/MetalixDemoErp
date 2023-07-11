using DataAccessLayer.Repositories.Common;
using DataAccessLayer.Repositories.Interfaces;
using MetalixDemoErp.DataAccessLayer;
using MetalixDemoErp.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementations
{
    public class DangilNoRepository : BaseRepository<DangilNo>, IDangilNoRepository
    {
        public List<DangilNo> GetListWithDangil()
        {
            using (var c = new Context())
            {
                return c.DangilNoes.Include(b => b.Company).ToList();
            }
        }
    }
}
