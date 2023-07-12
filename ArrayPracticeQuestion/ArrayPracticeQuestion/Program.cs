using System;

namespace ArrayPracticeQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "hashim";

            for (int i = 0; i < userName.Length; i++)
            {
                Console.WriteLine(userName[i]);
            }

            // AddFiveNumbersUsingVariables();
            //Console.WriteLine("---------------------------------------------------------");
            //Console.WriteLine("---------------------------------------------------------");
            //Console.WriteLine("---------------------------------------------------------");
            //AddFiveNumbersUsingArray();


            //int[] numbers = new int[5]; // Declare and initialize an integer array with 5 elements

            //numbers[0] = 10; // Assign value 10 to the first element
            //numbers[1] = 20; // Assign value 20 to the second element

            //Console.WriteLine(numbers[0]); // Output: 10
            //Console.WriteLine(numbers[1]); // Output: 20


            //string[] fruits = { "Apple", "Banana", "Orange", "Mango" };

            //// Using a for loop to iterate through the array
            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //// Using a foreach loop to iterate through the array
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}


            //int[] numbersArray = { 10, 5, 20, 15, 25 };
            //SumOfArray(numbersArray);


            Console.ReadKey();
        }

        static void AddFiveNumbersUsingVariables()
        {
            int numberOne;
            int numberTwo;
            int numberThree;
            int numberFour;
            int numberFive;

            Console.WriteLine("Enter first number: ");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter three number: ");
            numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter four number: ");
            numberFour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter five number: ");
            numberFive = int.Parse(Console.ReadLine());

            int sum = numberOne + numberTwo + numberThree + numberFour + numberFive;

            Console.WriteLine("Sum of the Five Integers is: " + sum);
        }

        static void AddFiveNumbersUsingArray()
        {
            int sum = 0;
            int[] numbers = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter the " + (i+1) + " number: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i]; // where sum += numbers[i] means sum = sum + numbers[i]
            }
            Console.WriteLine("Sum of All Integers is: " + sum);
        }

        static void SumOfArray(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num; // Add each number to the sum
            }
            Console.WriteLine("The sum of all numbers is: " + sum); // Output: 75
        }
    }
}







//using System;

//class Program
//{
//    static void Main()
//    {
//        //Console.Write("Enter the number of rows: ");
//        //int n = int.Parse(Console.ReadLine());

//        //for (int i = 1; i <= n; i++)
//        //{
//        //    // Print spaces
//        //    for (int j = 1; j <= n - i; j++)
//        //    {
//        //        Console.Write(" ");
//        //    }

//        //    // Print left side asterisks
//        //    for (int k = 1; k <= i; k++)
//        //    {
//        //        Console.Write("*");
//        //    }

//        //    // Print right side asterisks
//        //    for (int l = i - 1; l >= 1; l--)
//        //    {
//        //        Console.Write("*");
//        //    }

//        //    Console.WriteLine();
//        //}


