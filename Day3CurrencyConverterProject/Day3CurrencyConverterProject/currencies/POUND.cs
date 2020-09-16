using System;
using System.Collections.Generic;
using System.Text;

namespace Day3CurrencyConverterProject.currencies
{
    class POUND : Currency
    {
        Dictionary<string, double> UkPound = new Dictionary<string, double>
        {
            ["usd"] = 1.30,
            ["pound"] = 1,
            ["euro"] = 1.10,
            ["yuan"] = 8.77
        };
        public double getRate(string c)
        {
            return UkPound[c];
        }
    }
}
