using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck: IVehicle, ICompany
    {//In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public string BedSize { get; set; }
        public string CabType { get; set; }
        public void CompanyMoto()
        {
            Console.WriteLine("Built tough"); 
        }

        public void CorporateOrLocal()
        {
            Console.WriteLine("Corporate"); 
        }

        public void HasAirbags()
        {
            Console.WriteLine("Airbags: Only in cab"); 
        }

        public void Numdoors()
        {
            Console.WriteLine("Doors: 4"); 
        }

        public void NumWheels()
        {
            Console.WriteLine("Wheels: 4"); 
        }

        public void NumWindows()
        {
            Console.WriteLine("Windows: 6"); 
        }
       
        public void PrintVehicleDetails()
        {
            Console.WriteLine($"BedSize: {BedSize} \nType of cab: {CabType}");
        }
    }
}
