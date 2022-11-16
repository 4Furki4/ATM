using ATM.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Concrete
{
    public class CLog : ILog
    {
        public Guid Id { get; set; }
        public List<IUser> Users { get; set; } = new List<IUser>();
        public string TransectionType { get; set; } = string.Empty;
        public decimal TransectionAmount { get; set; }
        public decimal LastBalance { get; set; }

        public void Log(string message)
        {
            throw new NotImplementedException();
        }

        public string ReadLog()
        {
            throw new NotImplementedException();
        }
    }
}
