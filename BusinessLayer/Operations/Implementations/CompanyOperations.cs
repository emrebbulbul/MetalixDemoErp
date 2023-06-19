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
    public class CompanyOperations : ICompanyOperations
    {
      private readonly  ICompanyRepository _companyRepository;

        public CompanyOperations(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public List<Company> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Company t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Company t)
        {
            throw new NotImplementedException();
        }

        public Company TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Company t)
        {
            throw new NotImplementedException();
        }
    }
}
