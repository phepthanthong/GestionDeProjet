using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteHandler;
using EntrepriseManagement_v1.Tools;

namespace EntrepriseManagement_v1.Entity
{
    public class Employee : IEntity
    {        
        #region Attributs

        private Guid id = Guid.Empty;
        private string firstName;
        private string lastName;
        private string address;
        private string mobile;
        private int wage;
        private string cmnd;
        private string mst;
        private string role;

        #endregion

        #region Properties

        public Guid Id
        {
            get { return id; }
        }

        public string FullName
        {
            get { return lastName + " " + firstName; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        public int Wage
        {
            get { return wage; }
            set { wage = value; }
        }

        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public string MST
        {
            get { return mst; }
            set { mst = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        #endregion

        #region Data functions

        private static string TABLE_NAME = "Employee";
        private static string[] COLUMNS = { "Id", "FirstName", "LastName", "Address", "Mobile", "Wage", "CMND", "MST", "Role" };

        private static Employee createEntityFrom(Dictionary<string, object> dict)
        {
            Employee ob = new Employee()
            {
                id = Guid.Parse((String)dict["id"]),
                FirstName = (String)dict["firstname"],
                LastName = (String)dict["lastname"],
                Address = (String)dict["address"],
                Mobile = (String)dict["mobile"],
                Wage = Helper.parseInt(dict["wage"].ToString()),
                CMND = (String)dict["cmnd"],
                MST = (String)dict["mst"],
                Role = (String)dict["role"]
            };

            return ob;
        }

        private String[] getValues()
        {
            return new String[] { "'" + Id.ToString() + "'", "'" + FirstName + "'", "'" + LastName + "'", "'" + Address + "'"
                , "'" + Mobile + "'", Wage.ToString(), "'" + CMND + "'", "'" + MST + "'", "'" + Role + "'" };
        }

        public static Employee getFirst(string where)
        {
            Employee res = null;
            
            var temp = DbManager.getFirst(Configuration.Config.DB_PATH, TABLE_NAME, where);
            if (temp != null)
            {
                res = createEntityFrom(temp);
            }

            return res;
        }

        public static List<Employee> getList(string where)
        {
            List<Employee> res = null;

            var temp = DbManager.getList(Configuration.Config.DB_PATH, TABLE_NAME, where);
            if (temp != null)
            {
                res = new List<Employee>();

                foreach (Dictionary<string, object> entry in temp)
                {
                    res.Add(createEntityFrom(entry));
                }
            }

            return res;
        }

        public static Boolean save(Employee obj)
        {
            if (obj.Id == Guid.Empty)
            {
                return insert(obj);
            }
            else
            {
                return update(obj);
            }
        }

        private static Boolean insert(Employee obj)
        {
            obj.id = Guid.NewGuid();
            return DbManager.insert(Configuration.Config.DB_PATH, TABLE_NAME, COLUMNS, obj.getValues());
        }

        private static Boolean update(Employee obj)
        {
            return DbManager.update(Configuration.Config.DB_PATH, TABLE_NAME, COLUMNS, obj.getValues(), TABLE_NAME + ".ID = '" + obj.Id + "'");
        }

        public static Boolean delete(Employee obj)
        {
            return DbManager.delete(Configuration.Config.DB_PATH, TABLE_NAME, TABLE_NAME + ".ID = '" + obj.Id + "'");
        }

        #endregion
    }
}
