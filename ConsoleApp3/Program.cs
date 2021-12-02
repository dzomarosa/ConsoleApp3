using System;

namespace ConsoleApp3
{
    using System;



    class Backpack
    {
        public string color;
        public double capacity;

        public Backpack()
        {

        }


        public Backpack(string color, double capacity)
        {
            this.color = color;
            this.capacity = capacity;

        }

        public static void BackpackSize()
        {
            Console.WriteLine("Please enter wanted backpack capacity:");
            
            try
            {
                var capacity = Convert.ToDouble(Console.ReadLine());

                if (capacity >= 6 & capacity <= 10)
                    Console.WriteLine($"The size {capacity} refers to MINI/SMALL backpack");
                else if (capacity >= 10 & capacity <= 30)
                    Console.WriteLine($"This size {capacity} refers to DAYBACKPACKS");
                else if (capacity <= 30 & capacity >= 50)
                    Console.WriteLine($"The size{capacity} means that this is MEDIUM BACKPACK ");
                else if (capacity > 50)
                    Console.WriteLine($"The size {capacity} means that this is LARGE RUCKSACK");
                else if (capacity < 6)
                    Console.WriteLine("We don't have sizes under 6 in offer, sorry. Please, enter another size, thank you.");

                else
                    Console.WriteLine("We don't have sizes under 6, sorry. Please entere another size, thank you.");
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message + "..please, enter number!");
            }
            Console.ReadLine();
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Backpack backpack1 = new Backpack();
                Backpack.BackpackSize();
                Backpack.BackpackSize();
                Backpack.BackpackSize();
                Backpack.BackpackSize();
                Backpack.BackpackSize();
                Backpack.BackpackSize();
                backpack1.color = "black";
                backpack1.capacity = 12;


            }
        }
    
}
    
    
    
    
    
    
    
    
    
    
    
    
    
    

    


