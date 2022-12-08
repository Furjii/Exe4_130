using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_130
{
    class Stacks
    {
        private string[] furji;
        private int top;
        private int max;

        public Stacks()
        {
            furji = new string[49];
            top = -1;
            max = 49;
        }

        public void push()
        {
            string item;
            if (top == max - 1)
            {
                Console.WriteLine("\nMaksimal Data");
            }
            else
            {
                Console.WriteLine("Masukkan Data");
                item = Console.ReadLine();
                top = top + 1;
                furji[top] = item;
                Console.WriteLine("Data telah di Push");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
