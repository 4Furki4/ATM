using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Abstracts
{
    public interface IATM
    {
        public decimal Balance { get; set; }

        public List<ILog> Logs { get; set; }

        public List<IUser> Users { get; set; }

        public void Deposit(decimal amount);

        public void Withdraw(decimal amount);

        public void Transfer(string IBAN, decimal amount);

        public void Pay_Bill(IBill bill, decimal amount);

        public void Authorize();

        public void Register();

        public void LogOut();
    }
}
