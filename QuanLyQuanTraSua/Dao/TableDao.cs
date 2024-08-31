
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Dao
{
    public class TableDao
    {
        public static int Width = 90;
        public static int Height = 90;
        private QuanLyQuanTraSuaContext con = new QuanLyQuanTraSuaContext();
        private static TableDao instance;

        

        public static TableDao Instance {
            get
            {
                if(instance == null)
                {
                    instance = new TableDao();
                }
                return TableDao.instance;
            } 
            private set => TableDao.instance = value; 
        }
        private TableDao() { }
        public List<TableFood> getAllTable()
        {
            List<TableFood> list1 = con.TableFoods.ToList<TableFood>();
            return list1;
        }
        public List<TableFood> getAllTableEmpty()
        {
            List<TableFood> list1 = null;
            try
            {
                list1 = con.TableFoods.Where(x => x.Status == false).ToList<TableFood>();
            }
            catch (Exception e)
            {
                list1 = null;
            }

            return list1;
        }
        public List<TableFood> getAllTableOrdered()
        {
            List<TableFood> list1 = null;
            try
            {
                list1 = con.TableFoods.Where(x => x.Status == true).ToList<TableFood>();
            }
            catch (Exception e)
            {
                list1 = null;
            }
             
            return list1;
        }
        public List<TableFood> getAllTableByName( string name)
        {
            List<TableFood> list1 = null;
            try
            {
                list1 = con.TableFoods.Where(x => x.NameTable.Contains(name)).ToList<TableFood>();
            }
            catch (Exception e)
            {
                list1 = null;
            }

            return list1;
        }
        public TableFood gettableById(int id)
        {
            return con.TableFoods.FirstOrDefault(x => x.IdTable == id);
        }
        public void updateStatusTable(TableFood tableFood)
        {
            con.TableFoods.Update(tableFood);
            con.SaveChanges();
        }
        public void addtable(TableFood tableFood)
        {
            con.TableFoods.Add(tableFood);
            con.SaveChanges();
        }
        public void removetable(TableFood tableFood)
        {
            con.TableFoods.Remove(tableFood);
            con.SaveChanges();
        }
        public List<RoleAccount> getAllRole()
        {
            List<RoleAccount> list = con.RoleAccounts.ToList();
            return list;
        }
        public TableFood getTableByName(string tableName)
        {
            TableFood table = new TableFood();
            try
            {
                table = con.TableFoods.First(x => x.NameTable.Equals(tableName));
            }catch (Exception e)
            {
                table = null;

            }
            return table;
        }


    }
}
