using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
            (
                new Employee
                {
                    Id = 1,
                    Name = "Sam Raiden",
                    Age = 26,
                    Position = "Software developer",
                    CompanyID = 1
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jana McLeaf",
                    Age = 30,
                    Position = "Software developer",
                    CompanyID = 2
                },
                new Employee
                {
                    Id = 3,
                    Name = "Kane Miller",
                    Age = 35,
                    Position = "Administrator",
                    CompanyID = 2
                }
            );
        }
    }
}
