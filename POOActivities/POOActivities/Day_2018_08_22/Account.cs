using System;
using System.Collections.Generic;
using System.Text;

namespace POOActivities.Day_2018_08_22
{
    public struct Operation{
        public char type;
        public double value;
        public DateTime date;

    }

    public class Account
    {
        private double balance;
        private List<Operation> operations;

        public double Balance{
            get{
                return balance;
            }
        }

        public Account(){
            operations = new List<Operation>();
            balance = 0;
        }


        public List<Operation> GetBankStatement(){
            return operations;
        }

        public string PrintBankStatement(){
            StringBuilder statement = new StringBuilder();

            statement.AppendLine("Total in account: " + balance);

            foreach(Operation operation in operations){
                statement.AppendLine();
                statement.Append(operation.type == 'D' ? "Deposit" : "Claim");
                statement.Append("Value: " + operation.value);
            }
            return statement.ToString();
        }


    }
}
