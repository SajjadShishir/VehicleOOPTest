using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOOPTest.Enums;

namespace VehicleOOPTest.Entities
{
    public abstract class Vehicle
    {
        string modelNo;
        int year;
        int numberOfGear;
        int engineCapacity;
        VehicleType type;

        protected Vehicle(string modelNo, int year, int numberOfGear, int engineCapacity, VehicleType type)
        {
            this.modelNo = modelNo;
            this.year = year;
            this.numberOfGear = numberOfGear;
            this.engineCapacity = engineCapacity;
            this.type = type;
        }

        public abstract string ModelNo { get; set; }
        public abstract int Year { get; set; }
        public abstract int NumberOfGear { get; set; }
        public abstract int EngineCapacity { get; set; }
        public abstract VehicleType Type { get; set; }
        public abstract void GetStarMethod();
    }
}
