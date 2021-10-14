using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Practice_02
{
    class OutOfBalanceLimits:Exception{}

    delegate void Informer();
    class Account
    {
        const string OPERATION_ACCEPTED_INFORMER = "Operation Accepted.";
        const string OPERATION_DENIED_INFORMER = "Operation Denied.";
        const string BALANCE_INFORMER = "Balance: ";
        private const string OUT_OF_BALANCE = "Out of balance.";

        private static ulong ID = 0;
        private ulong AccountNumber { get; set; }
        private double Balance { get; set; }
        private int PinCode { get; set; } = 1234;

        public Account()
        {
            ID++;
            AccountNumber = ID + 100000000;
            Balance = 20000;
        }

        public void PinCodeChange(int newPin)
        {
            PinCode = newPin;
        }

        public ulong GetAccountNumber()
        {
            return AccountNumber;
        }

        public void Put(double sum)
        {
            Balance += sum;
            Console.WriteLine(OPERATION_ACCEPTED_INFORMER + BALANCE_INFORMER + Balance);
        }

        public void Withdraw(double sum)
        {
            bool isWithdrawDenied = false;
            do
            {
                try
                {
                    if (Balance >= sum)
                    {
                        Balance -= sum;
                        Console.WriteLine(OPERATION_ACCEPTED_INFORMER + BALANCE_INFORMER + Balance);
                    }
                    else
                    {
                        throw new OutOfBalanceLimits();
                    }
                }
                catch (OutOfBalanceLimits)
                {
                    Console.WriteLine(OPERATION_DENIED_INFORMER + OUT_OF_BALANCE);
                    isWithdrawDenied = true;
                }
            } while (isWithdrawDenied);
        }

        public void GetBalance()
        {
            Console.WriteLine(BALANCE_INFORMER + Balance);
        }

        public bool IsCorrectPin(int pin)
        {
            return PinCode == pin;
        }

        public override string ToString()
        {
            return $"Account#: {AccountNumber} | {BALANCE_INFORMER} {Balance}";
        }
    }
}
