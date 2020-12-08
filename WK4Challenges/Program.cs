using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK4Challenges
{
    abstract class Liquor
    {
        public string BottleSize { get; set; }
        public bool IsInStock { get; set; }
        public double Rating { get; set; }
        public string Distillery { get; set; }
        public Liquor() { }
        public Liquor(string bottleSize, bool isInStock, double rating, string distillery)
        {
            BottleSize = bottleSize;
            IsInStock = isInStock;
            Rating = rating;
            Distillery = distillery;
        }
        public abstract int GetInventoryCount();
    }

    class Whiskey : Liquor
    {
        int count = 12;
        public bool Rye { get; set; }
        public bool Bourbon { get; set; }
        public bool Scotch { get; set; }
        public Whiskey() { }
       
     
        public override int GetInventoryCount() => count;
    }

    class Vodka : Liquor
    {
        int count = 15;
        public bool IsFlavored { get; set; }
        public bool IsPremium { get; set; }
        public Vodka() { }
        public override int GetInventoryCount() => count;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bottleID100 = new Whiskey
            {
                BottleSize = "1 liter",
                IsInStock = true,
                Rating = 5.0,
                Distillery = "Jack Daniels",
                Rye = false,
                Bourbon = false,
                Scotch = false
            };
            Console.WriteLine($"Current quantity of {bottleID100.Distillery} is {bottleID100.GetInventoryCount()}");

            var bottleID200 = new Vodka();
            bottleID200.BottleSize = "1.5 liter";
            bottleID200.IsInStock = true;
            bottleID200.Rating = 4.5;
            bottleID200.Distillery = "Grey Goose";
            bottleID200.IsFlavored = false;
            bottleID200.IsPremium = true;
            Console.WriteLine($"Current quantity of {bottleID200.Distillery} is {bottleID200.GetInventoryCount()}");
            
        }
    }

}
