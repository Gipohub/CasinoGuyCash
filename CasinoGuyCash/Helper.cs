using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGuyCash
{
    internal static class Helper
    {
        static public string Capitalize(this string upperStr) {
            string? result;
            if (upperStr == "") { return "Noname"; }
            else {
                result = upperStr[0].ToString().ToUpper() + upperStr.Remove(0, 1);
                return result;
            }
        }

    }
}
