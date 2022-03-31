using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methods Example

            //Dont Repeat Yourself
            //int sum = 0;

            //foreach (int item in arr)
            //{
            //    if (item % 5 == 0)
            //    {
            //        sum += item;
            //    }
            //}

            //Console.WriteLine(sum);

            //int[] arr = { 5, 8, 15, 24 };
            //int[] arr1 = { 9, 7, 13, 25 };

            //Sum(arr);
            //Sum(arr1);

            //string namr = Console.ReadLine();

            //int herhansi = Sum(arr);

            //if (herhansi % 5 == 0)
            //{
            //    Console.WriteLine("5- Bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("Bolunmur");
            //}
            #endregion


            #region Example Method Task
            //string num1str = Console.ReadLine();
            //string num2str = Console.ReadLine();

            //int num1 = int.Parse(num1str);
            //int num2 = int.Parse(num2str);

            //SumIntervalNums(num1, num2);

            //SumIntervalNums(15, 72);

            //SumIntervalNums(2, 150);

            //Console.WriteLine(sum);
            #endregion

            #region Task - 1
            //double a = 5.3;
            //int[] arr = { };

            //Test(5, a, true, arr, "Test");
            #endregion
        }

        #region Methods Example
        //static void Test()
        //{

        //}

        //ReUsable Code Block
        //Return Type Void Olan Methodlar Geriye Deyer Qaytarmir
        static int Sum(int[] nums)
        {
            int sum1 = 0;

            foreach (int item in nums)
            {
                if (item % 2 == 0)
                {
                    sum1 += item;
                }
            }

            return sum1;
        }
        #endregion

        //Isdifadeci Terefinden Daxil Edilen n ve m ededleri
        //araliginda cutlerin cemini tap

        #region Example Method Task
        static void SumIntervalNums(int a, int b)
        {
            int min = 0;
            int max = 0;

            int sum = 0;

            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }

            while (min <= max)
            {
                if (min % 2 == 0)
                {
                    sum += min;
                }
            }

            Console.WriteLine(sum);

            return;
        }
        #endregion

        #region Task - 1
        //static void Test(int a, double b, bool check, int[] arr, string tes)
        //{

        //}

        //static void Test1(int min, int max, int average)
        //{

        //}
        #endregion

        #region Task 2
        static void TaskTwo(int a)
        {

        }
        #endregion
    }
}
