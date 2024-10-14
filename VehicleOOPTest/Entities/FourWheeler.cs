using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOOPTest.Enums;
using VehicleOOPTest.Interfaces;

namespace VehicleOOPTest.Entities
{
    public class FourWheeler<T> : Vehicle, IInteriorDesign<T>
    {
        public FourWheeler(string modelNo, int year, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, year, numberOfGear, engineCapacity, type)
        {
            this.ModelNo = modelNo;
            this.Year = year;
            this.NumberOfGear = numberOfGear;
            this.EngineCapacity = engineCapacity;
            this.Type = type;
        }

        public override string ModelNo { get; set; }
        public override int Year { get; set; }
        public override int NumberOfGear { get; set; }
        public override int EngineCapacity { get; set; }
        public override VehicleType Type { get; set; }

        public string[] GetInteriorDesign<T>(string data)
        {
            string[] design = data.Split(',');
            return design;
        }

        public override void GetStarMethod()
        {
            Console.WriteLine("start car");

        }
        public virtual void GetDetails()
        { Console.WriteLine("detail"); }
    }
}
