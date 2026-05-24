using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            for(int num=50;  num>24; num--)
            {
                if ((num % 3 == 0)&& (num % 5 ==0))
                {
                    Console.WriteLine(num + "  [3 & 5]");
                }
                else if (num % 5 ==0)
                {
                    Console.WriteLine(num + "  [5]");
                }

                else if  (num % 3 == 0)
                {
                    Console.WriteLine(num + "  [3]");
                }
                else
                {
                    Console.WriteLine(num);
                }
             }


        
        }
    }
}


