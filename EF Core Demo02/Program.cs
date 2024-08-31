using EF_Core_Demo02.Context;
using EF_Core_Demo02.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // using CompanyDBContext context = new CompanyDBContext();

            #region CRUD Operations
            #region Create-Insert
            //Employee employee = new Employee()
            //{
            //    Name = "Manar Ali",
            //    Salary = 12000,
            //    Address = "Mansoura",
            //    Age = 23,
            //    Email="manar@gmail.com",
            //    Phone="010100010"
            //};
            //Console.WriteLine(context.Entry(employee).State);
            //context.Employees.Add(employee);

            //Console.WriteLine(context.Entry(employee).State);
            //var result = context.SaveChanges();
            //Console.WriteLine(result);
            //Console.WriteLine(context.Entry(employee).State);
            //Console.WriteLine(context.Entry(employee).State);
            //context.Entry(employee).State = EntityState.Added;
            //Console.WriteLine(context.Entry(employee).State); 
            #endregion
            #region Read-Select
            //var Result = context.Employees.Where(E => E.EmpId == 3).FirstOrDefault();
            //Console.WriteLine(Result.Name);
            //Console.WriteLine( context.Entry(Result).State);
            //Result.Name = "Rana";
            //Console.WriteLine(context.Entry(Result).State);
            //Console.WriteLine(Result?.Name);

            //var Result = context.Employees.Select(E => E.Name);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Update
            //var Result = context.Employees.FirstOrDefault(E=>E.EmpId==4);
            //Console.WriteLine(context.Entry(Result).State);
            //Result.Name = "Nelly Mohamed";
            //Console.WriteLine(context.Entry(Result).State);
            //Result.Name = "Naya Mohamed";
            //context.Update(Result);
            //Console.WriteLine(context.Entry(Result).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State); 
            #endregion
            #region Remove
            //var Result = context.Employees.FirstOrDefault(E => E.EmpId == 4);
            //Console.WriteLine(context.Entry(Result).State);
            //context.Employees.Remove(Result);
            //Console.WriteLine(context.Entry(Result).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State);

            #endregion 
            #endregion

        }
    }
}
