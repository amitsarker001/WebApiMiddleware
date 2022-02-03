using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMiddleware.Data.Model;
using WebApiMiddleware.Data.ViewModels;

namespace WebApiMiddleware.Data.Services
{
    public class EmployeesService
    {
        private AppDbContext _context;
        public EmployeesService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(EmployeeVM employee)
        {
            var _employee = new Employee()
            {
                Emp_Id = employee.Emp_Id,
                Emp_Code = employee.Emp_Code,
                Emp_Name = employee.Emp_Name,
                Desg_Title = employee.Desg_Title,
                CMP_Branch_Name = employee.CMP_Branch_Name,
                Emp_Type = employee.Emp_Type,
            };
            _context.Employees.Add(_employee);
            _context.SaveChanges();
        }

    }
}
