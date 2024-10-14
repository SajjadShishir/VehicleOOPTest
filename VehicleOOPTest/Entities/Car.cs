using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOOPTest.Enums;

namespace VehicleOOPTest.Entities
{
    public sealed class Car<T> : FourWheeler<T>
    {
        int numberOfSeat;
        int numberOfDoor;



        public Car(string modelNo, int year, int numberOfGear, int engineCapacity, VehicleType type, int numberOfSeat, int numberOfDoor) : base(modelNo, year, numberOfGear, engineCapacity, type)
        {
            this.numberOfSeat = numberOfSeat;
            this.numberOfDoor = numberOfDoor;
        }
        public override void GetStarMethod()
        {
            base.GetStarMethod();
        }
        public override void GetDetails()
        {
            Console.WriteLine($"ModelNo={ModelNo}\nYearMake={Year}\nNumberOfGear={NumberOfGear}\nEngineCapacity={EngineCapacity}\nVehicleType={Type}\nNumberOfSeat={numberOfSeat}\nNumberOfDoor={numberOfDoor}");
        }
    }
}
