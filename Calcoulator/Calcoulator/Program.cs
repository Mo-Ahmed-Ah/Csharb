using System;
namespace Calcoulator
{
    class Calcoulator
    {
        static void Main()
        {
            char ca;
            bool check = true;
            while (check)
            {
                Console.Write("What the calcoulatio (+ , - , / or *) ? ");
                ca =  char.Parse(Console.ReadLine());

                Console.Write("Enter the number one : ");
                int num_1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the number two : ");
                int num_2 = int.Parse(Console.ReadLine());
                if(ca == '+')
                {
                    Console.WriteLine("{0} + {1} = {2}",num_1 , num_2 , num_1 + num_2);

                    Console.Write("whant use again (Y or N) : ");
                    ca = char.Parse(Console.ReadLine());
                    if (ca == 'n' || ca == 'N')
                    {
                        check = false;
                    }
                }
                else if (ca == '-')
                {
                    Console.WriteLine("{0} - {1} = {2}", num_1, num_2, num_1 - num_2);
                    Console.Write("whant use again (Y or N) : ");
                    ca = char.Parse(Console.ReadLine());
                    if (ca == 'n' || ca == 'N')
                    {
                        check = false;
                    }
                }
                else if (ca == '*')
                {
                    Console.WriteLine("{0} x {1} = {2}", num_1, num_2, num_1 * num_2);
                    Console.Write("whant use again (Y or N) : ");
                    ca = char.Parse(Console.ReadLine());
                    if (ca == 'n' || ca == 'N')
                    {
                        check = false;
                    }
                }
                else if (ca == '/')
                {
                    if (num_2 != 0) {
                        Console.WriteLine("{0} / {1} = {2}", num_1, num_2, num_1 / num_2);

                        Console.Write("whant use again (Y or N) : ");
                        ca = char.Parse(Console.ReadLine());
                        if (ca == 'n' || ca == 'N')
                        {
                            check = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("the oberation is not trou number tow equal 0");
                    }

                }
                else
                {
                    Console.WriteLine("Enter (+ , - , / or *)");
                }

                Console.WriteLine("Good By..!");

            }
        }

    }
}