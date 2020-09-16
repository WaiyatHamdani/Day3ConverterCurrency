using System;
using System.Collections.Generic;
using System.Text;

namespace Day3CurrencyConverterProject.currencies
{
    interface Currency
    {
        double getRate(string c);
    }
}
