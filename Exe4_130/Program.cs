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
            if (top == max - 1) //Jika data yang di masukkan sudah maksimal
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

        public void pop()
        {
            if (top == -1) //Jika posisi data belum lebih dari indeks 0
            {
                Console.WriteLine("Tidak ada data yang bisa di Pop/hapus");
            }

            else
            {
                top = top - 1;
                Console.WriteLine("Data Telah di Pop/hapus");
            }
        }

        void Display()
        {
            for (int i = top; i >= 0; i++) //Untuk menampilkan posisi indeks array dari kanan ke kiri
            {
                Console.WriteLine(furji[i]);
            }
            if (top == -1)
            {
                Console.WriteLine("Stack Tidak Ada");
            }
        }
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n*** Stack Menu ***\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop.");
                Console.WriteLine("3. Display.");
                Console.WriteLine("4. Exit.");
                Console.Write("\nMasukkan Pilihan: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        s.push();
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        s.Display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nPilihan salah");
                        break;

                }

            }
        }
    }
}