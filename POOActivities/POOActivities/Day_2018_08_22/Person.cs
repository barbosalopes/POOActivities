using System;
using System.Text;
using System.Text.RegularExpressions;

namespace POOActivities.Day_2018_08_22
{
    public class Person
    {
        private readonly Regex CPFRegex = new Regex("^\\d{3}\\.\\d{3}\\.\\d{3}\\-\\d{2}$");

        private string cpf;
        private Account[] accounts;

        public string CPF{
            get{
                return cpf;
            }
        }

        public Person(string cpf){
            if(!CPFRegex.IsMatch(cpf)){
                throw new Exception("Invalid CPF!");
            }
            else{
                this.cpf = cpf;
            }

            accounts = new Account[5];
        }

        /// <summary>
        /// Gets the finantial position.
        /// </summary>
        /// <returns>The finantial position.</returns>
        public double GetFinantialPosition(){
            double total = 0;
            foreach (Account account in accounts){
                total += account.Balance;
            }
            return total;
        }
    }
}
