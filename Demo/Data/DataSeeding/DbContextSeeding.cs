using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Demo.Data.Models;

namespace Demo.Data.DataSeeding
{
    internal class DbContextSeeding
    {
        public static void Seed(CompanyDbContext dbContext)
        {
            #region Departments
            if (!dbContext.Departments.Any())
            {
                var DepartmentsData = File.ReadAllText("D:\\.Net track\\Mariam shindey.net\\C#\\Demo&assignments\\Day04 - EFC\\Demo\\Data\\DataSeeding\\departments.json");
                var Departments = JsonSerializer.Deserialize<List<Department>>(DepartmentsData);
                if (Departments?.Count() > 0)
                {
                    foreach (var D in Departments)
                    {
                        dbContext.Departments.Add(D); // Add Localy
                    }
                    dbContext.SaveChanges();
                }
            }
            #endregion

            #region Employees
            if(!dbContext.Employees.Any())
            {
                var EmployeesData = File.ReadAllText("D:\\.Net track\\Mariam shindey.net\\C#\\Demo&assignments\\Day04 - EFC\\Demo\\Data\\DataSeeding\\employees.json");
                var employees = JsonSerializer.Deserialize<List<Employee>>(EmployeesData);
                if (employees?.Count() > 0)
                {
                    foreach (var E in employees)
                    {
                        dbContext.Employees.Add(E);
                    }
                    dbContext.SaveChanges();
                }
            }
            #endregion
        }
    }
}
