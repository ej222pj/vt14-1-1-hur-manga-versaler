using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Hur_många_versaler.Model
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text) 
        {
            int upperCases;
            Regex Reg = new Regex("[A-ZÅÄÖ]");
            upperCases = Reg.Matches(text).Count;

            return upperCases;
        }
    }
}