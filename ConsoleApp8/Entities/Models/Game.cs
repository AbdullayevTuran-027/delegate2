using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace Entities
{
    internal class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Platform_enum Platform { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public int DiscountPercent { get; set; }
        public bool IsDeleted { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}- Price{Price}- Name:{Name}");
        }
        public double GetDiscountedPrice()
        {
            return Price - (Price * (DiscountPercent / 100));
        }
        public Game(string name, Platform_enum platform, double price)
        {
            Name = name;
            Platform = platform;
            Price = price;
        }

    }
}
