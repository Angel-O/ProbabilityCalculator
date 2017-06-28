using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace ProbabilityCalculator.Models.Utils
{
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
                    items.Add((T)item);
                }            
            }

            return items;          
        }

        /// <summary>
        /// Convert an enum to its string repesentation
        /// </summary>
        public static string Convert<T>(T enumValue) where T : struct
        {
            // TODO split the enum name...
            return enumValue.ToString();
        }
    }
}