namespace ConsoleApp2
{
    static class Program
        {
            static void Main()
            {
            using (var context = new SavingContext())
                {
                    // I wipe out my database at each execution
                    context.Database.EnsureDeleted();
                    // Then I recreate it
                    context.Database.EnsureCreated();

                    var person = new Person
                    {
                        Name = "Mr.Richard"
                    };

                    person.SavingAccounts = new List<SavingAccount>
            {
                new SavingAccount { Amount = 2000000, Percentage = 5.00 },
                new SavingAccount { Amount = 250000, Percentage = 15.00 },
                new SavingAccount { Amount = 10000000, Percentage = 2.00 },
            };

                    context.Add(person);
                    // After the shop is added, his relatonships will too
                    // if they are defined          
                    context.SaveChanges();
                // Once changes are added, they must be saved to the database
                // unless you will have an unexisting one        

                new SavingCalculator(context);
                    }
            
                    
                }
        }
}
