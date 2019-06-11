using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace repro
{
    public class Program
    {
        private static ILoggerFactory LoggerFactory;

        public static void Main(string[] args)
        {
            var culture = new CultureInfo("fr-FR");
            Console.WriteLine(culture.DisplayName);

            var @decimal = "32 000,1";
            try
            {
                var d = Decimal.Parse(@decimal, NumberStyles.Float | NumberStyles.AllowThousands, culture);
                Console.WriteLine("Parsed: " + d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
