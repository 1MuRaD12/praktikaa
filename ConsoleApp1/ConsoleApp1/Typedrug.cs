using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Typedrug
    {
        private int _id;
        public static int id;
        public int Id
        {
            get => _id;
            set
            {
                id++;
                _id = id;
                _id = value;
            }
        }
        public string Typename { get; set; }
    }
}
