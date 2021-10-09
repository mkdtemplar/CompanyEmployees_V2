using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Employee> GetEmployees(int companyId, bool trackChanges) =>
            FindByCondition(e => e.CompanyID.Equals(companyId), trackChanges).OrderBy(e => e.Name);

        public Employee GetEmployee(int companyId, int id, bool trackChanges) =>
            FindByCondition(e => e.CompanyID.Equals(companyId) && e.Id.Equals(id), trackChanges).SingleOrDefault();

        public void CreateEmployeeForCompany(int companyId, Employee employee)
        {
            employee.CompanyID = companyId;
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }
    }
}
