using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FanEase.Model.Common
{
    public class EntityMapper<TSource, TDestination>
        where TSource : class
        where TDestination : class
    {
        public static TDestination Map(TSource source, TDestination destination, IEnumerable<string> sourcePropertiesToMap = null)
        {
            if (source != null)
            {
                // Get all the properties from source and destination objects
                PropertyInfo[] sourceProperties = source.GetType().GetProperties();
                PropertyInfo[] destinationProperties = destination.GetType().GetProperties();

                if (sourcePropertiesToMap != null)
                {
                    sourceProperties = sourceProperties.Where(c => sourcePropertiesToMap.Contains(c.Name)).ToArray();
                }

                foreach (var item in sourceProperties)
                {
                    if (destinationProperties.Any(prop => prop.Name == item.Name))
                    {
                        destination.GetType().GetProperty(item.Name).SetValue(destination, item.GetValue(source, null), null);
                    }
                }
            }

            return destination;
        }

        public static TDestination Map(TSource source)
        {
            // Create a new Object
            TDestination destination = Activator.CreateInstance<TDestination>();

            return Map(source, destination);
        }

        public static TDestination MapFromJson(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
            {
                return Activator.CreateInstance<TDestination>();
            }
            return JsonConvert.DeserializeObject<TDestination>(jsonString);
        }
    }
}
