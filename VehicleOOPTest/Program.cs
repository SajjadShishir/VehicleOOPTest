using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOOPTest.Entities;
using VehicleOOPTest.Enums;

namespace VehicleOOPTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\t\t\t Vehicle OOP Test (Sajjad Hossan Riad)");
                Console.WriteLine("\t\t\t=================================\n");
                DoTask();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadLine(); }
        }

        private static void DoTask()
        {
            printCarinformation();
            printMotorcycleInformation();
        }

        private static void printMotorcycleInformation()
        {
            Console.WriteLine("\t\t\t\tMotorcycle Information");
            Console.WriteLine("\t\t\t=================================\n");
            string modelNo = "Honda 3000 CC";

            int year = 2024;
            int numberOfGear = 6;
            int engineCapacity = 30000;
            VehicleType type = VehicleType.Personal;
            string maximumpower = "67BPH";
            string maximumTorque = "57NM";
            string mileage = "100kpml";
            string frontbrake = "Hadr Brake";
            string rearbrake = "Rear Brake";
            Motorcycle<Vehicle> cycle = new Motorcycle<Vehicle>(modelNo, year, numberOfGear, engineCapacity, type, maximumpower, maximumTorque, mileage, frontbrake, rearbrake);
            Console.WriteLine();
            cycle.GetStarMethod();
            Console.WriteLine();
            cycle.GetDetails();
            Console.WriteLine();
            Console.WriteLine("Cooling Method");
            Console.WriteLine(cycle.GetcoolingMethod());
            Console.WriteLine();
            Console.WriteLine("Motorcycle Design");

            string[] design = cycle.GetexteriorDesign<Vehicle>("Sticker, Helmat, Mobile Stand");
            for (int i = 0; i < design.Length; i++)
            { Console.WriteLine((i + 1).ToString() + ". " + design[i].Trim()); }

        }

        private static void printCarinformation()
        {
            Console.WriteLine("\t\t\t\tCar Information");
            Console.WriteLine("\t\t\t=================================\n");

            string modelNo = "Toyota 3000 CC";
            int year = 2024;
            int numberOfGear = 6;
            int engineCapacity = 30000;
            VehicleType type = VehicleType.Personal;
            int numberOfSeat = 5;
            int numberOfDoor = 4;
            Car<Vehicle> mycar = new Car<Vehicle>(modelNo, year, numberOfGear, engineCapacity, type, numberOfSeat, numberOfDoor);
            Console.WriteLine();
            mycar.GetStarMethod();
            Console.WriteLine();
            mycar.GetDetails();
            Console.WriteLine();
            Console.WriteLine("Car Design");
            Console.WriteLine();
            string[] design = mycar.GetInteriorDesign<Vehicle>("Pillow, Water Bottle, Doll");
            for (int i = 0; i < design.Length; i++)
            { Console.WriteLine((i + 1).ToString() + ". " + design[i].Trim()); }


        }
    }
}
