using ATM.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Concrete
{
    class ATM : IATM
    {
        public List<ILog> Logs { get; set;} = new List<ILog>();
        public decimal Balance { get; set; }
        public List<IUser> Users { get; set; } = new List<IUser>();

        public void Authorize()
        {
            
        }

        public void Deposit(decimal amount)
        {
            
        }

        public void LogOut()
        {
            
        }

        public void Pay_Bill(IBill bill, decimal amount)
        {
            
        }

        public void Register()
        {
            
        }

        public void Transfer(string IBAN, decimal amount)
        {
            
        }

        public void Withdraw(decimal amount)
        {
            
        }
    }
}
