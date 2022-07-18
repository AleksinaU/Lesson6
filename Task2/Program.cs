using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания и узнайте, является ли оно палиндромом");
            string str = Console.ReadLine();
            string str2 = "";
            str = str.Replace(" ", "");
            str = str.ToLower();
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            if (str == str2)
                Console.WriteLine("Предложение является палиндромом");
            else
                Console.WriteLine("Предложение не является палиндромом");
            Console.ReadKey();
        }
    }
}
