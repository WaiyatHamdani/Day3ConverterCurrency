using System;
using System.Collections.Generic;
using System.Text;
using Day3CurrencyConverterProject.currencies;

namespace Day3CurrencyConverterProject.calculation
{
    class CALCULATE
    {
        public USD usd;
        public POUND pound;
        public EURO euro;
        public YUAN yuan;

        public double calculating(string typecurency, double amount, string tocurrency)
        {
            usd = new USD();
            pound = new POUND();
            euro = new EURO();
            yuan = new YUAN();

            if (typecurency.Equals("usd"))
            {
                return amount * usd.getRate(tocurrency);
            }
            else if (typecurency.Equals("pound"))
            {
                return amount * pound.getRate(tocurrency);
            }
            else if (typecurency.Equals("euro"))
            {
                return amount * euro.getRate(tocurrency);
            }
            else
            {
                return amount * yuan.getRate(tocurrency);
            }

        }
    }
}
