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
        // قائمة المرتبات
        private static List<double> Salaries = new List<double>() { 100, 3000, 1200, 1500, 1000, 1800, 2000, 900, 600 };

        static void Main(string[] args)
        {

            #region Imparative 
            foreach (double x in Salaries)
            {
                Console.WriteLine(AddFiftyPercent(AddOneHunderd(CutFifty(x))).ToString());
            }
            Console.Read();
            #endregion

            #region Declarative

            //Salaries.Select(CutFifty).Select(AddOneHunderd).Select(AddFiftyPercent).ToList().ForEach((x) => Console.WriteLine(x.ToString()));

            //Console.Read();

            //Salaries.Select(IncomeTax).Select(SocialSecurityTex).Where(x => x > 20).Select(AddBonus).ToList().ForEach((x) => Console.WriteLine(x.ToString()));
            //Salaries.Select(IncomeTax).Select(SocialSecurityTex).Where(x => x < 70).OrderBy(x => x).Take(2).Select(AddBonus).ToList().ForEach((x) => Console.WriteLine(x.ToString()));


            Console.Read();
            #endregion
        }



        // خصم ضرائب  50 دينار
        public static double CutFifty(double x)
        {

            return x - 50;
        }

        // اضافة علاوات 100 دينار
        public static double AddOneHunderd(double x)
        {

            return x + 100;
        }

        //  زيادة  100 دينار على المرتب   
        public static double AddFiftyPercent(double x)
        {
            double percent = x * 50 / 100;
            return x + percent;
        }

    }
}
