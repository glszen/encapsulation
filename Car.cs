using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    public class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int doorNumber
        {
            get { return doorNumber; }
            set
            {
                if (value != 2 && value !=4)
                {
                    Console.WriteLine("Warning!: Incorrect entry.");
                    value = -1; 
                    Console.WriteLine("New Door Number Value is: " + value);
                }
            }
        }
    }
}
