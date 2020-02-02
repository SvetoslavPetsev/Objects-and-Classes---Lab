using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Vehicle_Catalogue
{
    public class Cars
    { 
        public string Brand { get; set; }

        public string Model { get; set; }

        public string HorsePower { get; set; }
    }

    public class Trucks
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Weight { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Cars> carsCatalog = new List<Cars>();
            List<Trucks> truckCatalog = new List<Trucks>();

            bool haveCars = false;
            bool haveTrucks = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split('/');

                if (input[0] == "end")
                {
                    break;
                }

                string type = input[0];
                string brand = input[1];
                string model = input[2];
                string hpOrWight = input[3];

                if (type == "Car")
                {
                    haveCars = true;
                    Cars newCar = new Cars();
                    newCar.Brand = brand;
                    newCar.Model = model;
                    newCar.HorsePower = hpOrWight;
                    carsCatalog.Add(newCar);
                }
                else if (type == "Truck")
                {
                    haveTrucks = true;
                    Trucks newTruck = new Trucks();
                    newTruck.Brand = brand;
                    newTruck.Model = model;
                    newTruck.Weight = hpOrWight;
                    truckCatalog.Add(newTruck);
                }
            }

            List<Cars> sortetAlphabCarList = new List<Cars>();
            List<Cars> tempCars = new List<Cars>();
            tempCars.AddRange(carsCatalog);

            for (int i = 0; i < carsCatalog.Count; i++)
            {
                Cars SortedCar = GetFirstCar(tempCars);

                sortetAlphabCarList.Add(SortedCar);
                tempCars.Remove(SortedCar);
            }

            List<Trucks> sortetAlphabTruckList = new List<Trucks>();
            List<Trucks> tempTrucks = new List<Trucks>();
            tempTrucks.AddRange(truckCatalog);

            for (int i = 0; i < truckCatalog.Count; i++)
            {
                Trucks SortedTruck = GetFirstTruck(tempTrucks);

                sortetAlphabTruckList.Add(SortedTruck);
                tempTrucks.Remove(SortedTruck);
            }
            if (haveCars)
            {
                Console.WriteLine("Cars:");
                foreach (Cars item in sortetAlphabCarList)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            if (haveTrucks)
            {
                Console.WriteLine("Trucks:");
                foreach (Trucks item in sortetAlphabTruckList)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }

        }

        static Cars GetFirstCar(List<Cars> listOfCars)
        {
            Cars firstCar = listOfCars[0];
            char firstLetter = 'z';

            for (int i = 0; i < listOfCars.Count; i++)
            {
                Cars currentCar = listOfCars[i];
                string model = currentCar.Model;
                char firstLetterOfModel = model[0];

                if (firstLetterOfModel < firstLetter)
                {
                    firstLetter = firstLetterOfModel;
                    firstCar = currentCar;
                }

            }
            return firstCar;
        }
        static Trucks GetFirstTruck(List<Trucks> listOfTrucks)
        {
            Trucks firstTruck = listOfTrucks[0];
            char firstLetter = 'z';

            for (int i = 0; i < listOfTrucks.Count; i++)
            {
                Trucks currentTruck = listOfTrucks[i];
                string model = currentTruck.Model;
                char firstLetterOfModel = model[0];

                if (firstLetterOfModel < firstLetter)
                {
                    firstLetter = firstLetterOfModel;
                    firstTruck = currentTruck;
                }

            }
            return firstTruck;
        }
    }
}
