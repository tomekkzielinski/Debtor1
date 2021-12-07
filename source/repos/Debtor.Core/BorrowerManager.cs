namespace Debtor.Core
{
    public class BorrowerManager
    {
        private List<Borrower> Borrowers { get; set; }
        
        public void AddBorrower(string name,decimal amount)
        {
            var borrower = new Borrower
            {
                Name = name,
                Amout = amount,
            };
            Borrowers.Add(borrower);
        }
        public void DeleteBorrower(string name)
        {
           foreach (var borrower in Borrowers)
            {
                if (borrower.Name == name)
                {
                    Borrowers.Remove(borrower);
                    return;
                }
            }  
        }

        public List<string> ListBorrowers()
        {
            
            var borrowersStrings = new List<string>();
            var indexer = 1;

            foreach (var borrower in Borrowers)
            {
                var borrowerString = indexer + ". " + borrower.Name + " - " + borrower.Amout + " zł";
                indexer++;

                borrowersStrings.Add(borrowerString);
               
            }

            Console.WriteLine(borrowersStrings);

                return borrowersStrings;
        }
    }
}
