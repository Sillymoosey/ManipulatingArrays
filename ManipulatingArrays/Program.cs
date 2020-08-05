using System;

namespace ManipulatingArrays
{
    class Program
    {
        // Array A: 0, 2, 4, 6, 8, 10
        // Array B: 1, 3, 5, 7, 9
        // Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9

        public static double Count(int[] AverageArray)
        {
            double average = 0.0;
            for(int i = 0; i < AverageArray.Length; i++)
            {
                average += AverageArray[i];
                average /= AverageArray.Length;
            }

            return average;
        }
        public static void ArrayReverse(int[] ReverseArray)
        {
            int[] CopyArr = new int[ReverseArray.Length];
            Array.Copy(ReverseArray, 0, CopyArr, 0, ReverseArray.Length);
            Array.Reverse(CopyArr);
            Console.WriteLine($"Reversed Array");
            foreach (int i in CopyArr)
            {
                Console.Write(i + ",");
            }
            Console.Write("\n");
        }
        public static void Rotating( string direction, int numPlace, int[] RArray)
        {
            direction.ToLower();
            int n = RArray.Length;
            int[] CopyArr = new int[RArray.Length];
            Array.Copy(RArray, 0, CopyArr, 0, RArray.Length);
            if (direction == "left")
            {
                for (int i = 0; i < numPlace; i++)
                {
                    int temp = CopyArr[0];
                    for (int j = 1; j < n; j++)
                    {
                        CopyArr[j - 1] = CopyArr[j];
                    }
                    CopyArr[n - 1] = temp;
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < numPlace; i++)
                {
                    int temp = CopyArr[n-1];
                    for (int j = n - 2; j >= 0; j--)
                    {
                        CopyArr[j + 1] = CopyArr[j];
                    }
                    CopyArr[0] = temp;
                }
            }
            Console.Write($"The Array was shifted {numPlace}, towards the {direction}, ");
            foreach (var item in CopyArr)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n");
        }
        public static void Sort(int[] ArrayC)
        {
            int holder;
            for (int i = 0; i < ArrayC.Length; i++)
            {
                for (int j = i + 1; j < ArrayC.Length; j++)
                {
                    if (ArrayC[i] > ArrayC[j])
                    {
                        holder = ArrayC[i];
                        ArrayC[i] = ArrayC[j];
                        ArrayC[j] = holder;
                    }
                }

            }
            Console.WriteLine("Array C sorted is ");
            foreach (var item in ArrayC)
            {
                Console.Write(item + ",");
            }

        }
        static void Main(string[] args)
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };

            int[] ArrayB = {1, 3, 5, 7, 9};

            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("Averaging Arrays!");

            Console.WriteLine($"ArrayA's average:{Count(ArrayA)}\nArrayB's average:{Count(ArrayB)}\nArrayC's average:{Count(ArrayC)}");

            ArrayReverse(ArrayA);

            ArrayReverse(ArrayB);

            ArrayReverse(ArrayC);

            Rotating("left", 2, ArrayB);

            Rotating("right", 2, ArrayA);

            Sort(ArrayC);
        }
    }
}
