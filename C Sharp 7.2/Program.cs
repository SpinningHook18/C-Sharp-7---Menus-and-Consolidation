using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_7._2
{
    class Program
    {
        static void SetUpArray(ref string[,] Countries)
        {
            Countries = new string[20, 2] {{"Greece", "Athens" } ,{"Bulgaria", "Sofia" }, {"Peru", "Lima" },
            {"Australia", "Canberra" },{"Austria" ,"Vienna" }, {"Finland","Helsinki" },{"Albania" ,"Tirana" },{"Cyprus", "Nicosia" },
            {"Zambia", "Lusaka" },{"Canada" , "Ottawa" },{"Bangladesh" , "Dhaka" }, {"Columbia", "Bogota" }, {"Ghana" , "Accra" },
            {"Kenya","Niarobi" }, {"New Zealand", "Wellington" }, {"Pakistan", "Islamabad" }, {"Turkey", "Ankara" },
            {"Switzerland", "Bern" }, {"Norway","Oslo" }, {"Vietnam","Hanoi" } };
        }

        static void capital(ref string[,] Countries)
        {
            Random num = new Random();
            Console.WriteLine(Countries[num.Next(), 1]);

        }
        static void Main(string[] args)
        {
            string[,] Questions = new string[20, 2];
            SetUpArray(ref Questions);
            capital(ref 
        }
    }
}
