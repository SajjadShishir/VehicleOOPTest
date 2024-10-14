using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOOPTest.Entities;

namespace VehicleOOPTest.Interfaces
{
    internal interface IExteriorDesign<T> where T : Vehicle
    {
        string[] GetexteriorDesign<T>(string data) where T : Vehicle;
    }
}
