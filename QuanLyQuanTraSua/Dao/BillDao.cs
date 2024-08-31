using Microsoft.EntityFrameworkCore;
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Dao
{
    public class BillDao
    {
        private QuanLyQuanTraSuaContext context = new QuanLyQuanTraSuaContext();
        private static BillDao instance;

        public static BillDao Instance {
            get
            {
                if (instance == null)
                {
                    instance = new BillDao();
                }
                return instance;
            } 
            set => instance = value; }
        private BillDao() { }
        public Bill getBillTableUncheck(int idTable)
        {
            Bill btable = new Bill();
            try
            {
                btable = context.Bills.First(b => b.IdTable == idTable && b.Status == false);
            }
            catch(Exception e) {
                btable = null;
            }
            
            return btable;
        }
        public List<Bill> getBillTable(int idTable)
        {
            List<Bill> btable = new List<Bill>();
            try
            {
                btable = context.Bills.Where(x => x.IdTable == idTable).ToList();
            }
            catch (Exception e)
            {
                btable = null;
            }

            return btable;
        }
        public void InsertBillForTable(Bill bill)
        {
            context.Bills.Add(bill);
            context.SaveChanges();
        }
        public int getMaxIdBill()
        {
            List<Bill> listbill = context.Bills.OrderBy(x => (-1)*x.IdBill).ToList();
            return listbill[0].IdBill;
        }
        public void updateStatusBill(Bill bill)
        {
            context.Bills.Update(bill);
            context.SaveChanges();
        }
        public void deleteBill(Bill Bill) 
        {
            context.Bills.Remove(Bill);
            context.SaveChanges();
        }
        public void deleteListBill(List<Bill> listbill)
        {
            context.Bills.RemoveRange(listbill);
            context.SaveChanges();
        }
        public List<Bill> getAllBill()
        {
            List<Bill> bills = null;
            try
            {
                 bills = context.Bills.Include(x => x.IdTableNavigation).ToList();
            }
            catch(Exception e) 
            {
                bills = null;
            }
            return bills;
        }
        public List<Bill> getAllBillPaid()
        {
            List<Bill> bills = null;
            try
            {
                bills = context.Bills.Include(x => x.IdTableNavigation).Where(p => p.Status == true).ToList();
            }
            catch (Exception e)
            {
                bills = null;
            }
            return bills;
        }
        public List<Bill> getAllBillUnpaid()
        {
            List<Bill> bills = null;
            try
            {
                bills = context.Bills.Include(x => x.IdTableNavigation).Where(p => p.Status == false).ToList();
            }
            catch (Exception e)
            {
                bills = null;
            }
            return bills;
        }
        public List<Bill> getAllBillInDay()
        {
            List<Bill> bills = null;
            try
            {
                bills = context.Bills.Include(x => x.IdTableNavigation).Where(p => p.DateCheckIn == DateTime.Now).ToList();
            }
            catch (Exception e)
            {
                bills = null;
            }
            return bills;
        }
        public List<Bill> getBillsByDay(DateTime f, DateTime t)
        {
            List<Bill> bills = null;
            try
            {
                bills = context.Bills.Where(x => x.DateCheckIn > f &&  x.DateCheckIn < t).ToList();    
            }catch(Exception e)
            {
                bills = null;
            }
            
            return bills;
        }
    }
}
