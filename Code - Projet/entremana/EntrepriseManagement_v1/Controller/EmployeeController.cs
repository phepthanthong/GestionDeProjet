using EntrepriseManagement_v1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrepriseManagement_v1.Controller
{
    public class EmployeeController
    {
        public Boolean saveEmployee(string fname, string lname, string address, string mobile, int wage, string cmnd, string mst, string role)
        {
            Employee obj = new Employee()
            {
                FirstName = fname,
                LastName = lname,
                Address = address,
                Mobile = mobile,
                Wage = wage,
                CMND = cmnd,
                MST = mst,
                Role = role
            };

            return Employee.save(obj);
        }

        public Boolean updateEmployee(Employee obj)
        {
            return Employee.save(obj);
        }
    }
}
