using Microsoft.EntityFrameworkCore;
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Dao
{
    public class AccountDao
    {
        private static AccountDao instance;
        private QuanLyQuanTraSuaContext con = new QuanLyQuanTraSuaContext();
        internal static AccountDao Instance 
        {   get 
            {
                if (instance == null)
                {
                    instance = new AccountDao();    
                }
                return AccountDao.instance;
            } 
            private set => AccountDao.instance = value; 
        }
        public AccountDao() { }
        
        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = con.Accounts.Include(x => x.IdRoleNavigation).ToList();
            return accounts;

        }
        public Account GetAccountByuserName(string username) 
        {
            Account account = con.Accounts.FirstOrDefault(x => x.UserName.Equals(username));
            return account;
        }
        public List<RoleAccount> GetAllRoleAccounts()
        {
            List<RoleAccount> role = con.RoleAccounts.ToList();
            return role;

        }
        public RoleAccount GetRoleAccountById(int id)
        {
           RoleAccount role = con.RoleAccounts.First(x => x.IdRole== id);
           return role;

        }
        public void ResetPassword(Account ac)
        {

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(ac.Password);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashPass = "";
            foreach (byte b in hash)
            {
                hashPass += b;
            }
            ac.Password = hashPass;
            con.Accounts.Update(ac);
            con.SaveChanges();
        }
        public Account loginAccount(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[]hash = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashPass = "";
            foreach(byte b in hash)
            {
                hashPass += b;
            }
           
            Account ac = new Account();

            try
            {
                ac = con.Accounts.First(x=> x.UserName.Equals(username) && x.Password.Equals(hashPass));
            }catch (Exception ex)
            {
                ac = null;
            }
            return ac;
        }
        public void updateAccount(Account account)
        {

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(account.Password);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashPass = "";
            foreach (byte b in hash)
            {
                hashPass += b;
            }
            account.Password = hashPass;
            con.Accounts.Update(account);
            con.SaveChanges();
        }
        public int  deleteAccount(Account account)
        {
            int count = 0;
            con.Accounts.Remove(account);
            count = con.SaveChanges();
            return count;
        }
        public int insertAccount(Account account)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(account.Password);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashPass = "";
            foreach (byte b in hash)
            {
                hashPass += b;
            }
            account.Password = hashPass;
            int count = 0;
            con.Accounts.Add(account);
            count = con.SaveChanges();  
            return count;
        }
        public Account getAccount(string  email) 
        {
            Account ac = new Account();
            try
            {
                ac = con.Accounts.First(x => x.UserName.Equals(email));
            }catch(Exception ex)
            {
                ac = null;
            }
             
            return ac;
        }

    }
}
