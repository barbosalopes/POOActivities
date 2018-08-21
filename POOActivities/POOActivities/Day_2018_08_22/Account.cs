using System;
using System.Collections.Generic;
using System.Text;

namespace POOActivities.Day_2018_08_22
{
    public struct Operation
    {
        public bool isDeposit;
        public double value;
        public DateTime date;
    }

    public class Account
    {
        List<Operation> operations;
        private double balance;

        public Account(){
            operations = new List<Operation>();
        }

        public double GetBalance(){
            return 0;
        }
        
        public Operation[] GetAccountStatement(){
            return null;
        }

        public override string ToString(){
            StringBuilder accountString = new StringBuilder();
            accountString.AppendLine("Total Balance: " + balance);

            accountString.AppendLine("Operations:");
            foreach(Operation operation in operations){
                accountString.AppendLine();
                accountString.Append(operation.isDeposit ? "Deposit" : "Claim");
                accountString.Append(operation.value);
            }
            return accountString.ToString();
        }
    }
}
