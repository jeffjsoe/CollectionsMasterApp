//-JESUS
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] number = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(number);


            //TODO: Print the first number of the array
            Console.WriteLine(number[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(number[49]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(number);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways


            /*  1) First way, using a custom method => Hint: Array.Reverse(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            ReverseArray(number);

            var numbersReversed = number;
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbersReversed);
            NumberPrinter(numbersReversed);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(number);
            NumberPrinter(number);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(numList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);

            //TODO: Print the new capacity
            Console.WriteLine(numList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int userNumber;
            bool isNumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                //Check if it is an integer using the try parse using the user input. If it is true then it will exit the do while loop. If it is false it will repeat again. 
                isNumber = int.TryParse(Console.ReadLine(), out userNumber);


            } while (isNumber == false);
            NumberChecker(numList, userNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numList.Sort();
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var myArray = numList.ToArray();

            //TODO: Clear the list
            numList.Clear();
            Console.WriteLine("List is clear");

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;

                }


            }

            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {

            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                //If it is s not even then we remove it
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }

            }

        }


        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {

                Console.WriteLine("Yes we have the numebr you are looking for");

            }

            else
            {
                Console.WriteLine("No the number isnt in the list");

            }

        }

        private static void Populater(List<int> numberList)
        {


            Random rng = new Random();
            while (numberList.Count <= 50)
            {
                var number = rng.Next(0, 51);

                numberList.Add(number);

            }


            NumberPrinter(numberList);

        }

        private static void Populater(int[] numbers)
        {
            //Here the numbers.Length is eqaul to 50
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                //gets a random number between 0 and 50 and adds it to the index of between 0 and 50 oes this 50 times
                numbers[i] = rng.Next(0, 50);
                //For example if it is index 0 it addsa a random number between o and 50
                //Ignore the numbers add thingy here because since it is a random numbers the way is different lol


            }
        }

        private static void ReverseArray(int[] array)
        {
            //Create a method which will reverse it and read it
            //Since we dont know the index what we will do is get the length of the array and minus 1 because we are printing out the index. So if there are 10 numbers we want to print out the index 9 of it. And then decremtnt as we go along.Thank you JESUS
            //So here we created an reversed arr and made it eual to the same length as the int array
            var reversedArray = new int[array.Length];
            var counter = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                //Here reversed array at index 0 will equal to array at ingex 49 so bascially reversing it
                reversedArray[counter++] = array[i];

            }



        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}


