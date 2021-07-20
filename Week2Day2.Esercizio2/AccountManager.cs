using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2.Esercizio2
{
    class AccountManager
    {
        static List<Account> accounts = new List<Account>()
        {
            new Account(1, "Pippo", 1000m),
            new Account(2, "Pluto", 350.50m),
            new Account(3, "Paperino", 10.50m)
        };
        internal static Account GetByid(int idAccount)
        {
           foreach(Account account in accounts)
            {
                if(account.IdAccount == idAccount)
                {
                    return account;
                }
            }
            return null;
        }

        internal static void addAccount(string accountHolder, decimal balance)
        {
            Random random = new Random();
            int idAccount = 0;
            do
            {
                idAccount = random.Next(100, 100000);
            } while (GetByid(idAccount) != null);

            Account account = new Account(idAccount, accountHolder, balance);
            accounts.Add(account);
            Console.WriteLine($"Account con ID = '{idAccount}', INTESTATARIO = '{accountHolder}', SALDO = '{balance}' aggiunto con successo!\n");
        }

        internal static void Withdraw(int idAccount, decimal withdrawal)
        {
            foreach(Account account in accounts)
            {
                if(account.IdAccount == idAccount )
                {
                    if (account.Balance >= withdrawal)
                    {
                        account.Balance = account.Balance - withdrawal;
                        Console.WriteLine($"Importo di {withdrawal}Euro prelevato con successo!Il tuo saldo ora è di {account.Balance}Euro\n");
                    }
                    else
                    {
                        Console.WriteLine("Spiacente! Non hai abbastanza fondi per prelevare l'intero importo.");
                    }
                }
               
        }

        }

        internal static void RemoveAccount(int idAccount)
        {
            accounts.Remove(GetByid(idAccount));
            Console.WriteLine($"Account '{idAccount}' rimosso con successo!");
        }

        internal static void ViewAllAccounts()
        {
            Console.WriteLine("CONTO \t\t INTESTATARIO \t\t SALDO ");
            foreach(Account account in accounts)
            {
                Console.WriteLine(account.IdAccount + " \t\t " + account.AccountHolder + " \t\t " + account.Balance);
            }
        }

        internal static void Deposit(int idAccount, decimal deposit)
        {
            foreach (Account account in accounts)
            {
                if (account.IdAccount == idAccount)
                {
                    account.Balance = account.Balance + deposit;
                    Console.WriteLine($"Importo di {deposit}Euro depositato con successo. Il tuo saldo ora è di {account.Balance}Euro!\n");
                }
                
            }
        }
    }
}
