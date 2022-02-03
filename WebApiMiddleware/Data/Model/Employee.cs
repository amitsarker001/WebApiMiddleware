using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMiddleware.Data.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string Emp_Name { get; set; }
        public string Desg_Title { get; set; }
        public string CMP_Branch_Name { get; set; }
        public string Emp_Type { get; set; }
    }
}
