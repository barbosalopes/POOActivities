using System;
namespace POOActivities.Day_2018_08_22
{
    public class Company
    {
        private static double CarTax = .04;
        private static double VanTax = .04;
        private static double TruckTax = .01;

        private static double CarInsurance = .05;
        private static double VanInsurance = .07;
        private static double TruckInsurance = .1;

        private static double OldVehicleDiscount = .15;

        private Vehicle[] fleet;

        public Vehicle[] Fleet{
            get {
                return fleet;   
            }
        }

        public Company(int fleetSize){
            if(fleetSize < 0){
                throw new Exception("Invalid fleet size.");
            }
            else {
                fleet = new Vehicle[fleetSize];
            }
        }

        public void AddVehicle(Vehicle vehicle){
            try{
                fleet.SetValue(vehicle, fleet.Length);
            }
            catch(IndexOutOfRangeException e){
                throw new Exception("Fleet already full.");
            }
        }

        private double GetTax(char type){
            switch(type){
                case Vehicle.CarType:
                    return CarTax;
                case Vehicle.VanType:
                    return VanTax;
                case Vehicle.TruckType:
                    return CarTax;
                default:
                    throw new Exception("Invalid vehicle type.");
            }
        }

        public double GetInsuranceValue(Vehicle vehicle){
            bool hasDiscount = DateTime.Today.Year - vehicle.FabricationYear > 5;
            double value = vehicle.Price * GetTax(vehicle.Type);
            if(hasDiscount){
                value *= OldVehicleDiscount;
            }
            return value;
        }

        public Vehicle GetExpensiveVehicle(){
            Vehicle expensive;

            try {
                expensive = fleet[0];
            }
            catch(IndexOutOfRangeException){
                throw new Exception("There is no vehicles on the fleet.");
            }

            foreach(Vehicle vehicle in fleet){
                if(GetInsuranceValue(expensive) < GetInsuranceValue(vehicle)){
                    expensive = vehicle;
                }
            }

            return expensive;
        }

        public double GetTotalExpense(){
            double total = 0;

            foreach(Vehicle vehicle in fleet){
                total += GetInsuranceValue(vehicle);
            }

            return total;
        }
    }
}
