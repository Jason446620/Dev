using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace de_CH
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the current UI culture to de-CH.
            CultureInfo.CurrentUICulture = new CultureInfo("de-CH", false);
            Console.WriteLine("CurrentUICulture is now {0}.", CultureInfo.CurrentUICulture.CultureTypes);
            NumberFormatInfo nfi = CultureInfo.CurrentUICulture.NumberFormat;
            Console.WriteLine(nfi.NumberGroupSeparator);
            Console.WriteLine(((int)(nfi.NumberGroupSeparator.Single())).ToString("X4"));

            Console.ReadKey();
        }
    }
}
