using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] types = new int[] { 1, 2, 3, 4 };
            decimal[] prices = new decimal[] { 45.50m, 99.9m, 165.25m, 1095.50m };
            string[] namesType = new string[] { "Single", "Double", "Luxury", "Penthouses" };


            Console.WriteLine("Room Types\n");


            for (int i = 0; i< types.Length; i++)
            {
                Console.WriteLine("{0}. {1} {2:c} per night", types[i], namesType[i], prices[i]);
            }


            int priceIndex;

            //getting the  user's choice room type 

            Console.Write("\nPlease select a room type 1, 2, 3 or 4 : ");

            int roomType = int.Parse(Console.ReadLine());

            for (int j = 0; j < types.Length; j++)
            {

                if (roomType  == types[j])
                {
                    priceIndex = j;


                    //getting number of nghts from the user

                    Console.Write("Please enter the number of nights : ");

                    int numNights = int.Parse(Console.ReadLine());
                    decimal price = numNights * prices[priceIndex];
                    string nameType = namesType[priceIndex];

                    Console.WriteLine("\nThank you, the total cost for staying in the {0} room for {1} nights is {2:c}", nameType, numNights, price);
                    break;
                }
                /*
                  else
                  {
                      Console.WriteLine("/n  Oops !! Choose your room type and number of nights properly");
                  }    */

            }


        }
    }
}
