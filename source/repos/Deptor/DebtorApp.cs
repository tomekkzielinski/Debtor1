using Debtor.Core;

namespace Debtor
{
    public class DebtorApp
    {
         BorrowerManager BorrowerManager { get; set; }    = new BorrowerManager();
        public void IntroduceDebtorApp()
        {

        }
        public void AddBorrower()
        {
            Console.WriteLine("Podaj nazwę dłużnika, którego chcesz dodać do listy");

            var userName = Console.ReadLine();

            Console.WriteLine("Podaj kwotę długu");

          var userAmount = Console.ReadLine();  

            var amountInDecimal = default(decimal);

            while (!decimal.TryParse(userAmount, out amountInDecimal))
            {
                Console.WriteLine("podano niepoprawną kwotę");

                Console.WriteLine("Podaj kwotę długu");

                 userAmount = Console.ReadLine();

            }

            BorrowerManager.AddBorrower(userName, amountInDecimal);


        }

        public void DeleteBorrower()
        {
            Console.WriteLine("Podaj nazwę dłużnika, którego chcesz usunąć");

            var userName = Console.ReadLine();

            BorrowerManager.DeleteBorrower(userName);

            Console.WriteLine("udało się usunać dłużnika");
       
        }

        public void ListAllBorrowers()
        {
            Console.WriteLine("Oto lista Twoich dłużników:");


            foreach (var borrower in Manager.ListBorrowers())
            {
               
                Console.WriteLine(borrower); 
            }

          
        }

        public void AskForAction()
        {

        }
    }
}
