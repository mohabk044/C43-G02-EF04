using Demo.Data;
using Demo.Data.DataSeeding;
using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo 
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            #region Session04
            #region DataSeeding 
            using CompanyDbContext dbContext = new CompanyDbContext();
            //DbContextSeeding.Seed(dbContext);
            #endregion

            #region Navigitional Properities
            #region Example 01
            //var employee = (from E in dbContext.Employees
            //                where E.Code == 5
            //                select E).FirstOrDefault();
            //Console.WriteLine($"EmpName: {employee?.Name}\t , EmpAge: {employee?.Age}\t , EmpCodeOfDep: {employee?.DepartmentDeptId}");
            #endregion
            #region Example 02
            //var department = (from D in dbContext.Departments
            //                 where D.DeptId==110
            //                 select D).FirstOrDefault();
            //if(department != null )
            //{
            //    Console.WriteLine($"DepartmentName: {department.Name}");
            //    foreach(var E in department.Employees)
            //    {
            //        Console.WriteLine($"EmployeeCode: {E.Code}\t , EmployeeName: {E.Name}");
            //    }
            //}
            #endregion
            #endregion

            #region Loading Data
            #region Explicit Loading
            #region Example 01
            //var employee = (from E in dbContext.Employees
            //                where E.Code == 5
            //                select E).FirstOrDefault();
            //if (employee is not null)
            //{
            //    dbContext.Entry(employee).Reference(nameof(Employee.Department)).Load();
            //    Console.WriteLine($"EmpName: {employee.Name}\t , EmpAge: {employee.Age}\t , EmpCodeOfDep: {employee.DepartmentDeptId}\t , DepName: {employee.Department?.Name}");
            //}
            #endregion
            #region Example 02
            //var department = (from D in dbContext.Departments
            //                  where D.DeptId == 110
            //                  select D).FirstOrDefault();
            //if (department != null)
            //{
            //    Console.WriteLine($"DepartmentName: {department.Name}");
            //    dbContext.Entry(department).Collection(nameof(Department.Employees)).Load();
            //    foreach (var E in department.Employees)
            //    {
            //        Console.WriteLine($"EmployeeCode: {E.Code}\t , EmployeeName: {E.Name}");
            //    }
            //}
            #endregion
            #endregion
            #region Eager Loading
            #region Example 01
            //var employee = (from E in dbContext.Employees.Include(E => E.Department)
            //                where E.Code == 5
            //                select E).FirstOrDefault();
            //if (employee is not null)
            //{
            //    Console.WriteLine($"EmpName: {employee.Name}\t , EmpAge: {employee.Age}\t , EmpCodeOfDep: {employee.DepartmentDeptId}\t , DepName: {employee.Department?.Name}");
            //}
            #endregion
            #region Example 02
            //var department = (from D in dbContext.Departments.Include(D=>D.Employees)
            //                  where D.DeptId == 110
            //                  select D).FirstOrDefault();
            //if (department != null)
            //{
            //    Console.WriteLine($"DepartmentName: {department.Name}");
            //    foreach (var E in department.Employees)
            //    {
            //        Console.WriteLine($"EmployeeCode: {E.Code}\t , EmployeeName: {E.Name}");
            //    }
            //}
            #endregion
            #endregion
            #region Lazy Loading
            #region Example 01
            var employee = (from E in dbContext.Employees
                            where E.Code == 5
                            select E).FirstOrDefault();
            Console.WriteLine($"EmpName: {employee?.Name}\t , EmpAge: {employee?.Age}\t , EmpCodeOfDep: {employee?.DepartmentDeptId}\t , DepName: {employee?.Department?.Name}");
            #endregion
            #region Example 02
            var department = (from D in dbContext.Departments
                              where D.DeptId == 110
                              select D).FirstOrDefault();
            if (department != null)
            {
                Console.WriteLine($"DepartmentName: {department.Name}");
                foreach (var E in department.Employees)
                {
                    Console.WriteLine($"EmployeeCode: {E.Code}\t , EmployeeName: {E.Name}");
                }
            }
            #endregion
            #endregion
            #endregion
            #endregion
        }
    }
}
