using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProbabilityCalculator.Models.Utils
{
    /// <summary>
    /// Utility class to perform enum conversions
    /// </summary>
    public static class EnumUtils
    {
        /// <summary>
        /// Returns all enum values for the given type
        /// </summary>
        public static IEnumerable<T> Values<T>() where T : struct 
        {
            IList<T> items = new List<T>();

            foreach (var item in Enum.GetValues(typeof(T)))
            {
                if (item is T)
                {
                    items.Add((T) item);
                }            
            }

            return items;          
        }

        /// <summary>
        /// Convert an enum to its string repesentation
        /// </summary>
        public static string ConvertToString<T>(T enumValue) where T : struct
        {
            // TODO split the enum name or use reflection to get display attribute value..
            return enumValue.ToString();
        }

        /// <summary>
        /// Convert a string to the specified enum type, if not found it will return the default enum
        /// </summary>
        public static T ConvertToEnum<T>(string enumStringRepresentation) where T : struct
        {
            return Values<T>().FirstOrDefault(value => value.ToString() == enumStringRepresentation);
        }
    }
}