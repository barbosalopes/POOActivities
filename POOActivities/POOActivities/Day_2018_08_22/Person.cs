using System;
using System.Text.RegularExpressions;

namespace POOActivities.Day_2018_08_22
{
    public class Person
    {
        private readonly Regex CPFRegex = new Regex("^\\d{3}\\.\\d{3}\\.\\d{3}\\-\\d{2}$");

        private string cpf;

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
        }
    }
}
