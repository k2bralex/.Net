using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_02
{
    class BalanceIsNotNull : Exception { }
    class InvalidKey : Exception { }
    class Bank
    {
        const string OPERATION_DENIED_INFORMER = "Operation Denied.";
        const string OPERATION_ACCEPTED_INFORMER = "Operation Accepted.";

        private const string INVALID_KEY = "Invalid key.";

        private List<Client> client = new List<Client>();
        private Dictionary<ulong, Account> accounts { get; set; } = new Dictionary<ulong, Account>();

        public Bank()
        {

        }

        public void AddNewAccount()
        {
            Client newClient = new Client();
            Account newAcc = new Account();
            accounts.Add(newAcc.GetAccountNumber(), newAcc);
        }

        public void RemoveAccount(ulong accountNumber)
        {
            AccountsView(accountNumber);
            ulong.TryParse(Console.ReadLine(), out var keyToRemove);
            bool isValidKey = accounts.ContainsKey(keyToRemove);
            try
            {
                if (isValidKey)
                {
                    accounts.Remove(keyToRemove);
                    Console.WriteLine(OPERATION_ACCEPTED_INFORMER + " Account removed.");
                }
                else
                {
                    throw new InvalidKey();
                }
            }
            catch (BalanceIsNotNull)
            {
                Console.WriteLine($"Account balance is not empty. {OPERATION_DENIED_INFORMER}");
            }
            catch (InvalidKey)
            {
                Console.WriteLine($"{INVALID_KEY} {OPERATION_DENIED_INFORMER}");
            }
        }

        public void AccountsView()
        {
            Console.WriteLine("\n===============");
            foreach (var i in accounts)
            {
                Console.WriteLine($" {i.Value}");
            }
            Console.WriteLine("===============\n");
        }
        public void AccountsView(ulong accountNumber)
        {
            var newSearch = accounts.Where(
                acc => acc.Key.Equals(accountNumber));
            Console.WriteLine("\n===============");
            foreach (var i in newSearch)
            {
                Console.WriteLine($" {i.Value}");
            }
            Console.WriteLine("===============\n");
        }

        public void AskPin(ulong accountNumber)
        {
            bool isCorrectPin;
            int attemt = 1;
            do
            {
                Console.WriteLine($"Attempt #{attemt}");
                Console.WriteLine("ENTER PIN-CODE: ");
                if ((int.TryParse(Console.ReadLine(), out int pin))
                    && (accounts[accountNumber].IsCorrectPin(pin)))
                {
                    isCorrectPin = false;
                }
                else
                {
                    isCorrectPin = true;
                }
            } while (!isCorrectPin);

        }

        private void MainMenu()
        {
            Console.WriteLine("User menu:");
            Console.WriteLine("A - Add New Client");
            Console.WriteLine("F - View Accounts");
            Console.WriteLine("R - Remove Account ");

            Console.WriteLine("E - Enter Account Menu");

            Console.WriteLine("Esc - Exit");
            Console.Write(" User Choice: ");
        }

        public void AccountMenu()
        {
            Console.WriteLine("Account menu:");
            Console.WriteLine("P - Put");
            Console.WriteLine("W - Withdraw");
            Console.WriteLine("G - Get Balance");

            Console.WriteLine("C - PIN Code Change");

            Console.WriteLine("Esc - Exit");
            Console.Write(" User Choice: ");
        }

        public void AccountMenuRun(ulong accountNumber)
        {
            AskPin(accountNumber);
            ConsoleKey key;
            do
            {
                AccountMenu();
                key = Console.ReadKey().Key;
                Console.WriteLine("\n--------------");

                switch (key)
                {
                    case ConsoleKey.P:
                        accounts[accountNumber].GetBalance();
                        Console.Write("Enter sum you put: ");
                        if (double.TryParse(Console.ReadLine(), out double sum))
                            accounts[accountNumber].Put(sum);
                        else
                            Console.WriteLine("Incorrect sum entered. Try one more time.");
                        break;

                    case ConsoleKey.W:
                        accounts[accountNumber].GetBalance();
                        if (double.TryParse(Console.ReadLine(), out sum))
                            accounts[accountNumber].Withdraw(sum);
                        else
                            Console.WriteLine("Incorrect sum entered. Try one more time.");
                        break;

                    case ConsoleKey.G:
                        accounts[accountNumber].GetBalance();
                        break;

                    case ConsoleKey.C:
                        Console.Write("Enter new PIN: ");
                        int.TryParse(Console.ReadLine(), out int newPin);
                        accounts[accountNumber].PinCodeChange(newPin);
                        break;

                    case ConsoleKey.Escape:
                        return;
                }

                Console.WriteLine("\n--------------");
                Console.WriteLine("Press Any Key!");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }


        public void Run()
        {
            ConsoleKey key;
            do
            {
                MainMenu();
                key = Console.ReadKey().Key;
                Console.WriteLine("\n--------------");

                switch (key)
                {
                    case ConsoleKey.A:
                        AddNewAccount();
                        break;

                    case ConsoleKey.F:
                        AccountsView();
                        break;

                    case ConsoleKey.R:
                        Console.WriteLine("Enter Account Number: ");
                        ulong.TryParse(Console.ReadLine(),out ulong accountNumber);
                        RemoveAccount(accountNumber);
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Enter Account Number: ");
                        ulong.TryParse(Console.ReadLine(), out accountNumber);
                        AccountMenuRun(accountNumber);
                        break;

                    case ConsoleKey.Escape:
                        return;
                }

                Console.WriteLine("\n--------------");
                Console.WriteLine("Press Any Key!");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
