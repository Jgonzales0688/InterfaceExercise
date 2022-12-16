using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV:IVehicle,ICompany
    {//In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public string CargoHoldSize { get; set; }
        public bool HasThirdRow { get; set; }

        public void CompanyMoto()
        {
            Console.WriteLine("Built for your Family"); 
        }

        public void CorporateOrLocal()
        {
            Console.WriteLine("Corporate owned");
        }

        public void HasAirbags()
        {
            Console.WriteLine( "Airbags: all around"); 
        }

        public void Numdoors()
        {
            Console.WriteLine("Door: 5"); 
        }

        public void NumWheels()
        {
            Console.WriteLine("Wheels: 4");
        }

        public void NumWindows()
        {
            Console.WriteLine("Windows: 8");
        }
       
        public void PrintVehicleDetails()
        {
            Console.WriteLine($"Cargo Hold Size:{CargoHoldSize} \nHas third row option: {HasThirdRow}");
        }
    }
}
