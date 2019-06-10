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
        public static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        public static async Task MainAsync()
        {
            // Arrange
            var bindingContext = GetBindingContext(typeof(decimal));
            bindingContext.ValueProvider = new SimpleValueProvider(new CultureInfo("fr-FR"))
            {
                { "theModelName", "32 000,1" }
            };
            var binder = GetBinder();

            // Act
            await binder.BindModelAsync(bindingContext);

            // Assert
            System.Console.WriteLine(bindingContext.Result.Model);
            Console.WriteLine("IsModelSet: " + bindingContext.Result.IsModelSet);
            // Console.WriteLine(32_000.1M == (decimal)bindingContext.Result.Model);
            Console.WriteLine("Contains: " + bindingContext.ModelState.ContainsKey("theModelName"));
        }

        private static DefaultModelBindingContext GetBindingContext(Type modelType)
        {
            return new DefaultModelBindingContext
            {
                ModelMetadata = new EmptyModelMetadataProvider().GetMetadataForType(modelType),
                ModelName = "theModelName",
                ModelState = new ModelStateDictionary(),
                ValueProvider = new SimpleValueProvider() // empty
            };
        }

        private static IModelBinder GetBinder()
        {
            return new DecimalModelBinder(NumberStyles.Float | NumberStyles.AllowThousands, NullLoggerFactory.Instance);
        }
    }


    public sealed class SimpleValueProvider : Dictionary<string, object>, IValueProvider
    {
        private readonly CultureInfo _culture;

        public SimpleValueProvider()
            : this(null)
        {
        }

        public SimpleValueProvider(CultureInfo culture)
            : base(StringComparer.OrdinalIgnoreCase)
        {
            _culture = culture ?? CultureInfo.InvariantCulture;
        }

        public bool ContainsPrefix(string prefix)
        {
            foreach (string key in Keys)
            {
                if (ModelStateDictionary.StartsWithPrefix(prefix, key))
                {
                    return true;
                }
            }

            return false;
        }

        public ValueProviderResult GetValue(string key)
        {
            if (TryGetValue(key, out var rawValue))
            {
                if (rawValue != null && rawValue.GetType().IsArray)
                {
                    var array = (Array)rawValue;

                    var stringValues = new string[array.Length];
                    for (var i = 0; i < array.Length; i++)
                    {
                        stringValues[i] = array.GetValue(i) as string ?? Convert.ToString(array.GetValue(i), _culture);
                    }

                    return new ValueProviderResult(stringValues, _culture);
                }
                else
                {
                    var stringValue = rawValue as string ?? Convert.ToString(rawValue, _culture) ?? string.Empty;
                    return new ValueProviderResult(stringValue, _culture);
                }
            }

            return ValueProviderResult.None;
        }
    }
}
