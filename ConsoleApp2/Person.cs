using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public ICollection<SavingAccount> SavingAccounts { get; set; }
    }
}
