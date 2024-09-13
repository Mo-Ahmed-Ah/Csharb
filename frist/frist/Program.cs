using System;
using System.Xml;
namespace Program
{

   
        
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 12; i >= 1; i--) {
                for (int j = i; j >= 1; j--) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }


}