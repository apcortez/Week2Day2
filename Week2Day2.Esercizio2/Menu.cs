using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2.Esercizio2
{
    class Menu
    {
        internal static void Start()
        {
            int scelta;
            
            do
            {
                Console.WriteLine("Benvenuto! Scegli l'operazione da fare:");
                Console.WriteLine("1 - Crea un conto");
                Console.WriteLine("2 - Prelevare sul conto");
                Console.WriteLine("3 - Versare sul conto");
                Console.WriteLine("4 - Visualizza saldo del conto");
                Console.WriteLine("5 - Elimina conto");
                Console.WriteLine("6 - Visualizza tutti i conti (ADMIN)");
                Console.WriteLine("0 - Per uscire");
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 6)
                {
                    Console.WriteLine("Inserisci un'operazone valida. Riprova: ");
                }
                switch (scelta)
                {
                    case 1:
                        CreateAccount();
                        break;
                    case 2:
                        WithdrawFromAccount();
                        break;
                    case 3:
                        DepositToAccount();
                        break;
                    case 4:
                        ViewBalance();
                        break;
                    case 5:
                        DeleteAccount();
                        break;
                    case 6:
                        AccountManager.ViewAllAccounts();
                        break;
                    case 0:
                        break;
                }
                Console.WriteLine("\n");
            } while (scelta != 0);
        }

        private static void DeleteAccount()
        {
            int idAccount;
            bool exist = SearchAccount(out idAccount);
            if (exist)
            {
                AccountManager.RemoveAccount(idAccount);
            }

            }

        private static void ViewBalance()
        {
            int idAccount;
          
            bool exist = SearchAccount(out idAccount);
            if (exist)
            {
                Account accountToView = AccountManager.GetByid(idAccount);
                Console.WriteLine($"Il saldo del tuo conto {accountToView.IdAccount} è di {accountToView.Balance}Euro.");
            }
        }

        private static void DepositToAccount()
        {
            int idAccount;
            decimal deposit;
            bool exist = SearchAccount(out idAccount);
            if (exist)
            {
                Console.WriteLine("Inserisci l'importo da depositare dal conto: ");
                while (!decimal.TryParse(Console.ReadLine(), out deposit) || deposit < 0)
                {
                    Console.WriteLine("Errore. Inserisci un importo valido. Riprova: ");
                }

                AccountManager.Deposit(idAccount, deposit);

            }
            else
            {
                Console.WriteLine("Errore! Conto non trovato.");
            }
        }

        private static void WithdrawFromAccount()
        {
            int idAccount;
            decimal withdrawal;
            bool exist = SearchAccount(out idAccount);
            if (exist)
            {
                Console.WriteLine("Inserisci l'importo da prelevare dal conto: ");
                while (!decimal.TryParse(Console.ReadLine(), out withdrawal) || withdrawal < 0)
                {
                    Console.WriteLine("Errore. Inserisci un importo valido. Riprova: ");
                }

                    AccountManager.Withdraw(idAccount, withdrawal);

            }
            else
            {
                Console.WriteLine("Errore! Conto non trovato.");
            }
        }

        private static bool SearchAccount(out int idAccount)
        {
            idAccount = 0;
            Console.WriteLine("Inserisci il numero di conto: ");
            while (!int.TryParse(Console.ReadLine(), out idAccount)|| idAccount<0)
            {
                Console.WriteLine("Errore. Inserisci un numero di conto valido. Riprova: ");
            }

            Account accountToFind = AccountManager.GetByid(idAccount);
            if (accountToFind == null)
            {
             return false;
            }
            return true;
        }

        private static void CreateAccount()
        {

            string accountHolder;
            decimal balance;


                //inserire intestatario conto 
                do
                {
                    Console.WriteLine("Inserisci l'intestatario del conto: ");
                    accountHolder = Console.ReadLine();

                } while (accountHolder.Length == 0);

                //inserire saldo conto
                Console.WriteLine("Inserire il saldo del conto");
                while (!decimal.TryParse(Console.ReadLine(), out balance) || balance < 0)
                {
                    Console.WriteLine("Devi inserire un saldo valido. Riprova: ");
                }

                AccountManager.addAccount(accountHolder, balance);
            
        }
    }
}
