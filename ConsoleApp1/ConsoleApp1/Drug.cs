using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Drug
    {
        public int _id { get; }
        public string Name { get; set; }
        public Typedrug Typ { get; set; }
        public double price { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Id:{_id} Name:{Name} Price:{price} Count:{Count}";
        }
    }
}
