using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {/*
            bool canIVote = true;

            Console.WriteLine("Biggest interger : {0}", int.MaxValue);
            Console.WriteLine("Smallest interger : {0}", int.MinValue);

            Console.WriteLine("Longest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            decimal decPiVal = 3.1415965M;
            decimal decBigNum = 3.000000000M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", decimal.MaxValue);*/

            Console.WriteLine("Biggest Long : {0}", Double.MaxValue);
            double dblPiVal = 3.14159;
            double dblBigNum = 3.00002;
            Console.WriteLine("DBL : PI + bigNum {0}",
                dblPiVal +dblBigNum);

            Console.WriteLine("Biggest Float : {0}", float.MaxValue);
            double fltPiVal = 3.14159F;
            double fltBigNum = 3.00002F;
            Console.WriteLine("FLT : PI + bigNum {0}",
                fltPiVal + fltBigNum);

        }
    }
}