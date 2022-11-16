using ATM.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Concrete
{
    public class CUser : IUser
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public string Password { get; set; } = string.Empty;
        public List<ILog> Records { get; set; } = new List<ILog>();
    }
}
