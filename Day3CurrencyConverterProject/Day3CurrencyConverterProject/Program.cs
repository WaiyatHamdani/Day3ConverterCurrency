using System;
using Day3CurrencyConverterProject.calculation;
using Day3CurrencyConverterProject.enumaration;
using Day3CurrencyConverterProject.UtilScanner;

namespace Day3CurrencyConverterProject
{
    class Program
    {
        public static void display(string curr, double amount, string tocurr, double convertedammount)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("                   Calculated                     ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("the {0} : {1} " +
                "\nand the converted value to {2} is {3}", curr, amount, tocurr, convertedammount);
            Console.WriteLine("--------------------------------------------------");
        }
        static void Main(string[] args)
        {
            CALCULATE cal = new CALCULATE();
            ASK a = new ASK();
            //Console.WriteLine((EnumCurrency)1);

            try
            {
                var type = int.Parse(a.askingquestion("1)usd" +
                    "\n2)pound" +
                    "\n3)euro" +
                    "\n4yuan " +
                    "\ntype what currency are you currently using: "));
                Console.WriteLine("--------------------------------------------------");
                var amount = double.Parse(a.askingquestion("amount of money without the sign : "));
                Console.WriteLine("--------------------------------------------------");
                var typeto = int.Parse(a.askingquestion("1)usd" +
                    "\n2)pound" +
                    "\n3)euro" +
                    "\n4yuan  " +
                    "\ntype what currency you want to convert to: "));

                var type_EnumtoString = (EnumCurrency)type;
                var type_toEnumtoString = (EnumCurrency)typeto;

                var convertedvalue = cal.calculating(type_EnumtoString.ToString(), amount, type_toEnumtoString.ToString());
                //Console.WriteLine("the {0} : {1} \nand the converted value to {2} is {3}", type_EnumtoString.ToString(), amount, type_toEnumtoString.ToString(), convertedvalue);

                display(type_EnumtoString.ToString(), amount, type_toEnumtoString.ToString(), convertedvalue);

            }
            catch (Exception)
            {
                Console.WriteLine("Error, may be because you the number of the type currency not exist" +
                    "\n or " +
                    "\n the amount has to be a number!!");
            }




            /*
            var type = a.askingquestion("(usd, pound ,euro ,yuan) \ntype what currency are you currently using: ");
            var amount = double.Parse(a.askingquestion("amount of money without the sign : "));
            var typeto = a.askingquestion("(usd, pound ,euro ,yuan) \ntype what currency you want to convert to: ");
            var convertedvalue = cal.calculating(type, amount, typeto);
            Console.WriteLine("the {0} : {1} \nand the converted value to {2} is {3}", type, amount, typeto, convertedvalue);
            */
        }
    }
}
