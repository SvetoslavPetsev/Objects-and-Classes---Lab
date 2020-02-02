using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Store_Boxes
{
    public class Box
    {
        public Box(string serialNumber, string item, int quantyty, double price)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantyty = quantyty;
            OnePicePrice = price;
            Price = quantyty * price;
    }

        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int Quantyty { get; set; }
        public double OnePicePrice{ get; set; }
        public double Price;


    }
    class Program
    {
        static void Main()
        {
            List<Box> Store = new List<Box>();
            List<Box> sortedList = new List<Box>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                string serN = input[0];
                string item = input[1];
                int quantyty = int.Parse(input[2]);
                double price = double.Parse(input[3]);

                Box NewBox = new Box(serN, item, quantyty, price);

                Store.Add(NewBox);
            }

            List<Box> temp = new List<Box>();
            temp.AddRange(Store);

            for (int i = 0; i < Store.Count; i++)
            {

                Box maxPriceBox = GetMaxPriceBox(temp);

                sortedList.Add(maxPriceBox);

                temp.Remove(maxPriceBox);
            }

            foreach (Box box in sortedList)
            {
                Console.WriteLine($"{box.SerialNumber}\r\n-- {box.Item} - ${box.OnePicePrice:F2}: {box.Quantyty}\r\n-- ${box.Price:F2}");
            }

        }
        static Box GetMaxPriceBox(List<Box> listOfBox)
        {
            double MaxPrice = 0;
            Box maxPriceBox = listOfBox[0];

            for (int i = 0; i < listOfBox.Count; i++)
            {
                Box currentbox = listOfBox[i];
                if (currentbox.Price > MaxPrice)
                {
                    MaxPrice = currentbox.Price;
                    maxPriceBox = currentbox;
                }
            }

            return maxPriceBox;
        }
    }
}
