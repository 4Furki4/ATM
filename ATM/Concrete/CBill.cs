using ATM.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Concrete
{
    public class CBill : IBill
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public decimal BillAmount { get; set; }
    }
}
