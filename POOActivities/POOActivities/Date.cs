using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities
{

    /*
    Activity:
    1) Implemente a classe Data utilizada como exemplo na aula teórica,
    considerando as operações:
        • Verificar validade da data
        • Adicionar dias a uma data
        • Dizer o dia da data no ano (1 a 366)
    */
    class Date
    {
        private static int[] DaysOnMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private int day;
        private int month;
        private int year;

        public int Day
        {
            set {
                if(DateIsValid(value, month, year))
                    day = value;
            }

            get {
                return day;
            }
        }

        public int Month {
            set {
                if (DateIsValid(day, value, year))
                    month = value;
            }

            get {
                return month;
            }
        }

        public int Year {
            set {
                if (DateIsValid(day, month, value))
                    year = value;
            }
        }
        
        public bool DateIsValid(int day, int month, int year)
        {
            if (year < 0)
                throw new Exception("Invalid year!");

            if (month < 1 || month > 12)
                throw new Exception("Invalid month!");

            if (year % 4 == 0)
                DaysOnMonth[1] = 29;

            if (day < 0 || day > DaysOnMonth[month - 1])
                throw new Exception("Invalid day!");

            return true;
        }

        public Date(int day, int month, int year){
            try{
                if (DateIsValid(day, month, year)){
                    this.year = year;
                    this.month = month;
                    this.day = day;
                }
            }
            catch (Exception e){
                throw new Exception("Error while trying to create date: " + e.Message);
            }
        }

        public void AddDays(int days){
            day += days;
            while (day > DaysOnMonth[month - 1]){
                day -= DaysOnMonth[month - 1];
                if (month == 12){
                    year++;
                    month = 1;
                }
                else{
                    month++;
                }
            }
        }

        public int GetDaysOnYear(){
            int month = this.month - 1;
            int days = this.day;
            while (month > 0){
                days += DaysOnMonth[month - 1];
                month--;
            }
            return days;
        }
        
        public override string ToString(){
            return day + "/" + month + "/" + year;
        }
    }
}
