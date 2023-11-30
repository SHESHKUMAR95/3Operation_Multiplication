using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Operation_Multiplication
{
    internal class Program
    {
        public void Multiplication()
        {
            int a = 10, b = 20;
            int c = a * b;
            Console.WriteLine("Multipliation : " + c);
        }
        static void Main(string[] args)
        {
            Program op = new Program();
            op.Multiplication();
            Console.ReadLine(); 
        }
    }
}
