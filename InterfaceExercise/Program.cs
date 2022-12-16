using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany -Done
            //Create 3 classes called Car , Truck , & SUV-Done


            //Now, create objects of your 3 classes and give their members values;
            SUV suv1 = new SUV()
            {
                CargoHoldSize = "Large",
                HasThirdRow = true
            };
            Car car1 = new Car()
            {
                TrunkSize = "Small",
                IsACoupe= true
            };
            Truck truck1 = new Truck()
            {
                BedSize = "4x4",
                CabType = "Crewcab"
            };

            List<IVehicle> list = new List<IVehicle>();
            list.Add(car1);
            list.Add(truck1);
            list.Add(suv1);
            
            //Creatively display and organize their values

            foreach (var item in list) 
            {
                item.CompanyMoto();
                item.CorporateOrLocal();
                item.NumWheels();
                item.NumWindows();
                item.Numdoors();
                item.HasAirbags();
                item.PrintVehicleDetails();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
