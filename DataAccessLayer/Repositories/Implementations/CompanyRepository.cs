using DataAccessLayer.Repositories.Common;
using DataAccessLayer.Repositories.Interfaces;
using MetalixDemoErp.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementations
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
    }
}
