using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImmoRale.NewDB;

namespace ImmoRale.Entites
{
    public class Tester
    {
        private Guid id = Guid.Empty;
        private string somot;
        private string sohai;

        #region proprietes
        public Guid Id
        {
            get { return id; }
        }

        public string Somot
        {
            get { return somot; }
            set { somot = value; }
        }

        public string Sohai
        {
            get { return sohai; }
            set { sohai = value; }
        }
        #endregion

        private static string Table_Name = "HIEU";
        public static string Path = "C:\\Users\\Hieu\\Desktop\\GestionDeProjet\\gestion-bien\\trunk\\ImmoRale\\ImmoRale\\Database\\immoraledatabase.db";
        private static string[] Column = { "ID", "Nom", "Prenom" };

        private static Tester create(Dictionary<string, object> dict)
        {
            Tester oj = new Tester()
            {
                id = Guid.Parse((String)dict["id"]),
                Somot = (String)dict["nom"],
                Sohai = (String)dict["prenom"]

            };
            return oj;
        }

        private String[] getValue()
        {
            return new String[] { "'" + Id.ToString() + "'", "'" + Somot + "'", "'" + Sohai + "'" };
        }

        //public static Tester getFirst(string where)
        //{
        //    Tester res = null;
        //    var tmp = DbManager.getFirst(Path, Table_Name, where);
        //    if (tmp != null)
        //    {
        //        res = create(tmp);
        //    }
        //    return res;
        //}

        public static List<Tester> getList(string where)
        {
            List<Tester> res = null;
            var temp = DbManager.getList(Path, Table_Name, where);
            if (temp != null)
            {
                res = new List<Tester>();

                foreach (Dictionary<string, object> entry in temp)
                {
                    res.Add(create(entry));
                }
            }

            return res;
        }

        public static Boolean save(Tester obj)
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

        private static Boolean insert(Tester obj)
        {
            obj.id = Guid.NewGuid();
            return DbManager.insert(Path, Table_Name, Column, obj.getValue());
        }

        private static Boolean update(Tester obj)
        {
            return DbManager.update(Path, Table_Name, Column, obj.getValue(), Table_Name + ".ID = '" + obj.Id + "'");
        }

    //    public static Boolean delete(Tester obj)
    //    {
    //        return DbManager.delete(Path, Table_Name, Table_Name + ".ID = '" + obj.Id + "'");
    //    }
    }
}
