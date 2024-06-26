﻿namespace Race.Objects.Vehicles
{
    public class FuelTank
    {
        // *******************************************************
        // PROPERTIES
        // ******************************************************* 
        public int FuelTankID { get; set; }
        public String FuelTankName { get; set; }
        public int FuelTankSize { get; set; } // litres


        // *******************************************************
        // CONSTRUCTOR
        // *******************************************************
        public FuelTank(List<FuelTank> fuelTanks, String fuelTankName, int fuelTankSize)
        {
            FuelTankID = fuelTanks.Count();
            FuelTankName = fuelTankName;
            FuelTankSize = fuelTankSize;
            fuelTanks.Add(this);
        }
    }
}