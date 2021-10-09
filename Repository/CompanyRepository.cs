﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.Name).ToList();

        public Company GetCompany(int companyId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(companyId), trackChanges).SingleOrDefault();

        public void CreateCompany(Company company) => Create(company);

        public IEnumerable<Company> GetByIds(IEnumerable<int> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();

        public void DeleteCompany(Company company)
        {
            Delete(company);
        }
    }
}
