using System;

namespace POOActivities.Day_2018_08_22
{
    public class Vehicle{

        public const char CarType = 'C';
        public const char VanType = 'V';
        public const char TruckType = 'T';

        private char type;
        private double price;
        private int fabricationYear;

        public char Type {
            get{
                return type;    
            }
        }

        public int FabricationYear{
            get
            {
                return fabricationYear;
            }
        }

        public double Price {
            set{
                if (value < 0){
                    throw new Exception("Invalid price");
                }
                else {
                    price = value;
                }
            }
            get{
                return price;
            }
        }

        public Vehicle(char type, int fabricationYear, double price){
            if(type != CarType || type != VanType || type != TruckType){
                throw new Exception("Invalid type of vehicle");
            }
            else {
                this.type = type;
            }

            if(fabricationYear < 0){
                throw new Exception("Invalid fabrication year.");
            }
            else{
                this.fabricationYear = fabricationYear;
            }
                
            Price = price;
        }
    }
}