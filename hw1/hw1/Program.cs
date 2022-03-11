using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int health = 100;
            string hero = "Thor";

            int Damaged()
            {
                return health - 20;
            }


            Console.WriteLine(Damaged()); 

            int boost()
            {
                return Damaged() + 10; 
            }

            int[] HealthArray = {Damaged(), boost() };

            Console.WriteLine(HealthArray[1]);

            void comparing()
            {
                if(Damaged() > boost())
                {
                    Console.WriteLine("80 is more than 90");
                }
                else if ( Damaged() < boost())
                {
                    Console.WriteLine("80 is less than 90"); 
                }
                
            }

          
            

            Console.WriteLine("Damaged health : " + Damaged());
            Console.WriteLine("Boosted health : " + boost());
            comparing();
        }
    }
}