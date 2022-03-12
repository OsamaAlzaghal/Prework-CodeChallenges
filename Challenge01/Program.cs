using System;

namespace Challenge01
{
    class Program
    {
        public static int score(int[] arr, int number)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    counter++;
                }
            }
            return counter * number;
        }

        public static void leapYear()
        {
            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine(year + " " + "is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " " + "is not a Leap Year.");
            }
        }

        public static string prefectSeq(int[] arr)
        {
            int sum = 0;
            int mul = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                mul *= arr[i];
            }
            if (sum == mul) return "Yes";
            return "No";
        }

        public static int[] sumOfRows(int[,] arr)
        {
            int[] result = new int[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                result[i] = sum;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Please enter five integers!");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));

            Console.Write("Please select a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The score of {number} equals: {score(arr, number)}.");

            Console.WriteLine("");
            // Leap Year.
            leapYear();
            Console.WriteLine("");

            // Prefect Score.
            int[] arr1 = { 1, 2, 3 };
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            Console.WriteLine(prefectSeq(arr1));
            Console.WriteLine("");

            // Sum Of The Rows.
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Console.Write("Array : ");
            Console.WriteLine("[{0}]", string.Join(", ", sumOfRows(myArray)));


        }
    }
}