using System;
using System.Collections.Generic;
using System.Linq;
namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit[0] > 'K' && fruit[0] < 'M'
                                          select fruit;
            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("----------------");
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 && number % 6 == 0);
            foreach (int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-----------");

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

            List<string> descend = names.OrderByDescending(name => name.First()).ToList();
            foreach (string name in descend)
            {
                Console.WriteLine(name);
                Console.WriteLine("");
            }
            Console.WriteLine("------------");

            // Build a collection of these numbers sorted in ascending order
            List<int> ascendingNumbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};


            var upNum = from n in ascendingNumbers
                        orderby n
                        select n;
            foreach (int num in upNum)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("- - - - - - - - - - -");

            // Output how many numbers are in this list
            List<int> howManyNumbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

            var countNumbers = howManyNumbers.Count();
            foreach (int num in howManyNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------------");
            Console.WriteLine(countNumbers);
            Console.WriteLine("- - - - - - - - - ");

            // How much money have we made?
            List<double> purchases = new List<double>()
{
    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
};
            var purchasesSum = purchases.Sum();
            Console.WriteLine(purchasesSum);


            // What is our most expensive product?
            List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};
            var biggestPrice = prices.Max();
            Console.WriteLine(biggestPrice);
            Console.WriteLine("- - - - - - - - - - - ");

            /*
    Store each number in the following List until a perfect square
    is detected.

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
            List<int> wheresSquaredo = new List<int>()
{
    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
};
            foreach (int num in wheresSquaredo)
            {
                if (Math.Sqrt(num) % 1 == 0)
                {
                    Console.WriteLine($"Yay the Number {num} is a perfect square");
                }
                else
                {
                    Console.WriteLine($"Negative Ghost Rider {num} is not a perfect square");
                }
            }

                

        }
    }
}
