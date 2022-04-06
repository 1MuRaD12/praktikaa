using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Pharmacy
    {
        public string Name { get; set; }
        public int _id { get; set; }
        public Drug[] drugs = new Drug[0];

        public override string ToString()
        {
            return $"Id:{_id} Name:{Name}";
        }
        public void Adddrug(Drug drug)
        {
            Array.Resize(ref drugs, drugs.Length + 1);
            drugs[drugs.Length - 1] = drug;
        }
        public void Drugelist()
        {
            foreach (var item in drugs)
            {
                Console.WriteLine(item);
            }
        }
        public void Saledrug(string name, int count, int monay)
        {
            foreach (var item in drugs)
            {
                if (item.Name == name || item.Count == count || item.price == monay)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
