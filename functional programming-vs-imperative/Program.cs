using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional_programming_vs_imperative
{
    internal class Program
    {
        private static List<double> mydata=new List<double>() { 7,4,5,6,3,8,10};

        static void Main(string[] args)
        {

            //#region Imparative 
            // foreach(double x in mydata)
            //{
            //    Console.WriteLine(SubtractTen(Square(AddOne(x))).ToString());
            //}
            //Console.Read();
            //#endregion

            #region Declarative

            mydata.Select(AddOne).Select(Square).Select(SubtractTen).ToList().ForEach((x) => Console.WriteLine(x.ToString()));

            Console.Read();

            mydata.Select(AddOne).Select(Square).Where(x=> x>20).Select(SubtractTen).ToList().ForEach((x) => Console.WriteLine(x.ToString()));
            mydata.Select(AddOne).Select(Square).Where(x => x < 70).OrderBy(x => x).Take(2).Select(SubtractTen).ToList().ForEach((x) => Console.WriteLine(x.ToString()));


            Console.Read();
            #endregion
        }

        public static double AddOne(double x)
        {
            return x+1;
        }

        public static double Square(double x)
        {
            return Math.Pow(x,2);
        }

        public static double SubtractTen(double x)
        {
            return x-10;
        }




        
    }
}
