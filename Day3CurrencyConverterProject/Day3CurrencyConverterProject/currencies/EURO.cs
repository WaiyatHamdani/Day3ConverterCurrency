using System;
using System.Collections.Generic;
using System.Text;

namespace Day3CurrencyConverterProject.currencies
{
    class EURO : Currency
    {
        Dictionary<string, double> Euro = new Dictionary<string, double>
        {
            ["usd"] = 1.18,
            ["pound"] = 1,
            ["euro"] = 0.91,
            ["yuan"] = 7.99
        };

        public double getRate(string c)
        {
            return Euro[c];
        }
    }
}
