using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company GetCompany(int companyId, bool trackChanges);

        void CreateCompany(Company company);

        public IEnumerable<Company> GetByIds(IEnumerable<int> ids, bool trackChanges);

        void DeleteCompany(Company company);
    }
}
