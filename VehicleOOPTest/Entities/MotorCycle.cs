using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOOPTest.Enums;

namespace VehicleOOPTest.Entities
{
    public sealed class Motorcycle<T> : TwoWheeler<T> where T : Vehicle
    {
        string maximumpower;
        string maximumTorque;
        string mileage;
        string frontbrake;
        string rearbrake;
        public Motorcycle(string modelNo, int year, int numberOfGear, int engineCapacity, VehicleType type, string maximumpower, string maximumTorque, string mileage, string frontbrake, string rearbrake) : base(modelNo, year, numberOfGear, engineCapacity, type)
        {
            this.maximumpower = maximumpower;
            this.maximumTorque = maximumTorque;
            this.mileage = mileage;
            this.frontbrake = frontbrake;
            this.rearbrake = rearbrake;
        }

        public override string GetcoolingMethod(string cool = "system cool Operator")
        {
            return base.GetcoolingMethod(cool);
        }
        public override void GetStarMethod()
        {
            base.GetStarMethod();
        }
        public override void GetDetails()
        {
            Console.WriteLine($"ModelNo={ModelNo}\nYearMake={Year}\nNumberOfGear={NumberOfGear}\nEngineCapacity={EngineCapacity}\nVehicleType={Type}\nMaximumPowerInBPH={maximumpower}\nMaximumTorqueNM={maximumTorque}\nMileage={mileage}\nFrontBrake={frontbrake}\nRearBrake={rearbrake}");
        }
    }
}
