using BusinessLayer.Operations.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using MetalixDemoErp.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Operations.Implementations
{
    public class DangilNoOperations : IDangilNoOperations
    {
        private readonly IDangilNoRepository _dangilNoRepository;

        public DangilNoOperations(IDangilNoRepository dangilNoRepository)
        {
            _dangilNoRepository = dangilNoRepository;
        }

        public List<DangilNo> GetList()
        {
            return _dangilNoRepository.GetListAll();
        }

        public void TAdd(DangilNo t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(DangilNo t)
        {
            throw new NotImplementedException();
        }

        public DangilNo TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(DangilNo t)
        {
            throw new NotImplementedException();
        }
    }
}
