using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car: IVehicle, ICompany
    {//In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */

        public string TrunkSize { get; set; }
        public bool IsACoupe { get; set; }
        public void CompanyMoto()
        {
            Console.WriteLine("Compact or coupes, thats what we do");
        }
        public void CorporateOrLocal()
        {
            Console.WriteLine("Locally Owned"  ); 
        }

        public void HasAirbags()
        {
            Console.WriteLine("Airbags: All around"); 
        }

        public void Numdoors()
        {
            Console.WriteLine("Doors: 2");
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
            Console.WriteLine($"Trunk size: {TrunkSize} \nCoupe: {IsACoupe}"); 
        }
    }
}
