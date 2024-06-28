using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.App
{
    public class DataTransformer
    {
        public static List<T2> ConvertTo<T1, T2>(List<T1> inputList) where T2 : IConvertible
        {
            List<T2> outputList = new List<T2>();

            foreach (var item in inputList)
            {                
                try
                {
                    T2 convertedItem = (T2)Convert.ChangeType(item, typeof(T2));
                    outputList.Add(convertedItem);
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine($"Cannot convert item {item} to type {typeof(T2)}.");
                }
            }
            return outputList;
        }
    }
}
// List<string> inputList item değerleri int türüne dönüşecek List<int> outputList listesine eklenecek