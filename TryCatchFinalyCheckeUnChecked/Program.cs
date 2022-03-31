using System;

namespace TryCatchFinalyCheckeUnChecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try Catch Finaly
            //Console.WriteLine("Deyer Daxil Et");
            //string name = Console.ReadLine();

            //int a = 5;
            //int b = 0;

            //int[] nums = { 5, 7, 10 };

            //try 
            //{
            //    int num = int.Parse(name);
            //    bool check = bool.Parse(name);

            //    int result = a / b;

            //    Console.WriteLine(nums[51]);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Daxil Edilen Deyer Int-e Cevrile Bilmir");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Sifira Bolunme Mumkun Deyil");
            //}catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Daxil Olunan Index Duz Deyil");
            //}
            //finally
            //{
            //    Console.WriteLine("P128 CSharp");
            //}
            #endregion

            #region Example Try Catch Finaly
            //Console.WriteLine("Ededi Daxil Edin");
            //Console.WriteLine("Birinci");
            //string numstr1 = Console.ReadLine();
            //Console.WriteLine("Ikinci");
            //string numstr2 = Console.ReadLine();
            //Console.WriteLine("Ucuncu");
            //string numstr3 = Console.ReadLine();

            //try
            //{
            //    int num1 = int.Parse(numstr1);
            //    int num2 = int.Parse(numstr2);
            //    int num3 = int.Parse(numstr3);

            //    int count = 0;

            //    if (num1 > 1)
            //    {
            //        for (int i = 1; i < num1; i++)
            //        {
            //            if (num1 % i == 0)
            //            {
            //                count++;
            //            }

            //            if (count > 2)
            //            {
            //                Console.WriteLine("Eded Murekkebdir");
            //                break;
            //            }
            //        }

            //        if (count <= 2)
            //        {
            //            Console.WriteLine("Eded Sadedir");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eded Ne 1 Nede 1-den Kicik Ola Bilmez");
            //    }

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Duzgun Daxil Et");
            //}
            #endregion

            #region Checked UnChecked
            //int a = 54654;
            //byte b = 0;
            //b = (byte)a;

            //try
            //{
            //    checked
            //    {
            //        b = (byte)a;
            //    }

            //    //unchecked
            //    //{
            //    //    b = (byte)a;
            //    //}
            //}
            //catch (OverflowException)
            //{

            //    Console.WriteLine("Interval Asildi");
            //}
            //finally
            //{
            //    Console.WriteLine(b);

            //}
            #endregion

        }
    }
}
