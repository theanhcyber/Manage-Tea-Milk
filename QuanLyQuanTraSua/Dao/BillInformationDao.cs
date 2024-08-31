using Microsoft.EntityFrameworkCore;
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Dao
{
    public class BillInformationDao
    {
        private static BillInformationDao instance;
        private QuanLyQuanTraSuaContext con = new QuanLyQuanTraSuaContext();
        public BillInformationDao() { }

        public static BillInformationDao Instance { 
            get
            {
                if(instance == null)
                {
                    instance = new BillInformationDao();

                }
                return instance;
            }
            set => instance = value; 
        }
        public List<BillInformation> getBillInformationTable(int idBill)
        {
            List<BillInformation> list = null;
            try 
            { 
                list = con.BillInformations.Where(b => b.IdBill == idBill).ToList();
            }catch (Exception ex) {
                list = null;
            }
            
            return list;
        }
        public void insertBillInfor(BillInformation billInformation)
        {
            con.BillInformations.Add(billInformation);
            con.SaveChanges();
        }
        public void removeBillInforById(BillInformation b)
        {
            con.BillInformations.Remove(b);
            con.SaveChanges();
        }
        public void removeBillInforArrage(List<BillInformation> list)
        {
            con.BillInformations.RemoveRange(list);
            con.SaveChanges();
        }
        public void updateBillInfor(BillInformation billInformation)
        {
            con.BillInformations.Update(billInformation);
            con.SaveChanges(); 
        }
        public List<BillInformation> getAllBillInforByIdBill(int idBil)
        {
            List<BillInformation> list = null;
            try
            {
                list = con.BillInformations.Include(b => b.IdFoodNavigation).Where(x => x.IdBill == idBil).ToList();
            }catch (Exception ex) { list = null; }
            return list;
        }
    }
}
