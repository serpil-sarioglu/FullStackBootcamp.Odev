using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class DictionaryExamples
    {
        public void ExamplesWithDictionary()
        {
            var cities = new Dictionary<string, string>(){

                {"TR","Ankara,İstanbul,Antalya"},
                {"US","Los Angeles,New York City, Miami"},
                {"DE","Berlin,Hamburg,Düsseldorf" },
                {"UK", "Londra,Liverpool,Manchester" }
            };

            WriteKeyValuePairs(cities);
            //Console.WriteLine(cities["TR"]);

            // Check if a Key or Value exists with Contains
            var containsKeyTR = cities.ContainsKey("TR");
            var containsValueTR = cities.ContainsValue("Ankara,İstanbul,Antalya");
            Console.WriteLine($"ContainsKey (\"TR\"): {containsKeyTR} \nContainsValue(\"Ankara,İstanbul,Antalya\"):{containsValueTR}");
                

            // Update values of Key US: 
            cities["US"] = "Los Angeles, Boston";

            // Remove an item based on the Key:
            var wasRemoved = cities.Remove("US");
            Console.WriteLine($"US key'i olan cities dictionary elemanı silindi mi:{wasRemoved}");

            // Get target value searching by key
            var keyToSearch = "US";
            if (cities.TryGetValue(keyToSearch, out string resultValue))
            {
                Console.WriteLine($"{keyToSearch} anahtarı bulundu. Aranan değerleri: {resultValue}");
            }
            else
            {
                Console.WriteLine($"{keyToSearch} anahtarı bulunamadı");
            }


            //Add Key/Values pair to a Dictionary
            var frCityAdded = cities.TryAdd("FR", "Paris, Strazburg, Versay");
            Console.WriteLine($"Fransa şehirleri eklendi mi :{frCityAdded}");
            //WriteKeyValuePairs(cities);

            //Dictionary'de var olan bir anahtar eklenirse hata fırlatır
            //cities.Add("FR", "Paris"); 


            //Searching with LINQ
            var citiesDict = cities
                .Where(pair => pair.Key == "FR")
                .Select(pair => pair.Value)
                .FirstOrDefault();
            
            if (citiesDict != null)
            {
                Console.WriteLine($"FR anahtarına ait değerler: {citiesDict}");
            }
            else
            {
                Console.WriteLine("FR anahtar değer çifti bulunamadı");
            }

        }



        private static void WriteKeyValuePairs(Dictionary<string, string> keyValuePairs)
        {
            foreach (var kvp in keyValuePairs)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value:{kvp.Value}");
            }
        }
    }
}
