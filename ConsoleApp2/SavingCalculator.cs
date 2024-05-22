using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class SavingCalculator
    {
        private readonly SavingContext _context;

        public SavingCalculator(SavingContext context)
        {
            _context = context;

            foreach (Person person in _context.Person)
            {
                Console.WriteLine(person.Name);
            }

                foreach (SavingAccount savingAccount in _context.SavingAccount) {
                
                
                Console.WriteLine("Depot: "+ savingAccount.Amount + " Euros   ,Rapport: " + savingAccount.Percentage + " %   Soit: "+ savingAccount.Amount * (savingAccount.Percentage / 100) +" Euros");
            }
        }
    }
}


