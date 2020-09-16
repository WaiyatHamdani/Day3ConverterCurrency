using System;
using System.Collections.Generic;
using System.Text;

namespace Day3CurrencyConverterProject.currencies
{
    class USD : Currency
    {
        Dictionary<string, double> usDollar = new Dictionary<string, double>
        {
            ["usd"] = 1,
            ["pound"] = 0.77,
            ["euro"] = 0.84,
            ["yuan"] = 6.75
        };

        public double getRate(string c)
        {
            return usDollar[c];
        }
    }
}
