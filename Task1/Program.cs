using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания и мы найдем самое длинное слово");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            int max = 0;
            foreach (string s in strArray)
            {
                if (s.Length > max)
                {
                    max = s.Length;
                }
            }
            foreach (string s in strArray)
            {
                if (s.Length == max)
                {
                    Console.WriteLine(s); 
                }
            }
            Console.ReadKey();
        }
    }
}
