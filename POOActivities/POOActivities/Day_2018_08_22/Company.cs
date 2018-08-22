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

        /// <summary>
        /// Adds a vehicle in the fleet.
        /// </summary>
        /// <param name="vehicle">Vehicle.</param>
        public void AddVehicle(Vehicle vehicle){
            try{
                fleet.SetValue(vehicle, fleet.Length);
            }
            catch(IndexOutOfRangeException){
                throw new Exception("Fleet already full.");
            }
        }

        /// <summary>
        /// Gets the insurence by it's type.
        /// </summary>
        /// <returns>The insurence according it's type.</returns>
        /// <param name="type">Type.</param>
        private double GetInsurenceByType(char type){
            switch(type){
                case Vehicle.CarType:
                    return CarInsurance;
                case Vehicle.VanType:
                    return VanInsurance;
                case Vehicle.TruckType:
                    return TruckInsurance;
                default:
                    throw new Exception("Invalid vehicle type.");
            }
        }

        /// <summary>
        /// Gets the insurance value of the given vehicle.
        /// </summary>
        /// <returns>The insurance value.</returns>
        /// <param name="vehicle">Vehicle.</param>
        public double GetInsuranceValue(Vehicle vehicle){
            bool hasDiscount = DateTime.Today.Year - vehicle.FabricationYear > 5;
            double value = vehicle.Price * GetInsurenceByType(vehicle.Type);
            if(hasDiscount){
                value *= OldVehicleDiscount;
            }
            return value;
        }

        /// <summary>
        /// Gets the expensive vehicle of the fleet.
        /// </summary>
        /// <returns>The expensive vehicle of the fleet.</returns>
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

        /// <summary>
        /// Gets the total expense of the company.
        /// </summary>
        /// <returns>The total expense.</returns>
        public double GetTotalExpense(){
            double total = 0;

            foreach(Vehicle vehicle in fleet){
                total += GetInsuranceValue(vehicle);
            }

            return total;
        }
    }
}
