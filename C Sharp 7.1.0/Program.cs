using System;

namespace C_Sharp_7._1._0
{
    class Program
    {
        static void poundsEuros()
        {
            Console.WriteLine("Enter amount in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double euros = pounds * 1.18;
            Console.WriteLine("£{0} = {1} Euros", pounds, euros);
        }

        static void eurosPounds()
        {
            Console.WriteLine("Enter amount in euros: ");
            double euros = Convert.ToDouble(Console.ReadLine());
            double pounds = euros / 1.18;
            Console.WriteLine("{0} Euros = £{1}", euros, pounds);
        }

        static void poundsDollars()
        {
            Console.WriteLine("Enter amount in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double dollars = pounds * 1.36;
            Console.WriteLine("£{0} = ${1}", pounds, dollars);
        }

        static void dollarsPounds()
        {
            Console.WriteLine("Enter amount in dollars: ");
            double dollars = Convert.ToDouble(Console.ReadLine());
            double pounds = dollars / 1.36;
            Console.WriteLine("${0} = £{1}", dollars, pounds);
        }

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Exchange Menu:");
                Console.WriteLine("1. Pounds to Euros");
                Console.WriteLine("2. Euros to Pounds");
                Console.WriteLine("3. Pounds to US Dollars");
                Console.WriteLine("4. US Dollars to Pounds");
                Console.WriteLine("5. Exit the program");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        poundsEuros();
                        break;
                    case 1:
                        eurosPounds();
                        break;
                    case 2:
                        poundsDollars();
                        break;
                    case 3:
                        dollarsPounds();
                        break;
                    case 4:
                        exit = true;
                        Console.ReadLine();
                        break;

                }
            }
            
        }
    }
}
