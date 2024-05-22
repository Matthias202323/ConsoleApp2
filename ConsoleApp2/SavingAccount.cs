using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SavingAccount
    {
        [Key]
        public Guid AccountId { get; set; }
        public int Amount { get; set; }
        public double Percentage { get; set; }
    }
}
