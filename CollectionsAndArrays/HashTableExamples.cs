using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class HashTableExamples
    {
        // Hashtable object tipinde key/value alır. Okuma işleminde dataları eklediğim sırada vermez. 
        public void ExamplesWithHashTable()
        {
            var ht = new Hashtable();
            
            // Add key/value pair
            ht.Add("meyve", "elma");
            ht.Add("meyve2", "incir");
            ht.Add("meyve3", "kayısı");
            ht.Add("ali", 30);
            ht.Add("veli", 15);
          
            Console.WriteLine("Key-value pairs");
            foreach (DictionaryEntry de in ht)
            {               
                Console.WriteLine("Key: {0}, Value:{1}",de.Key,de.Value);
            }

            Console.WriteLine("getting the keys from the hashtable");            
            foreach (var key in ht.Keys)
            {
                Console.WriteLine($" {key} ");
            }

          
            Console.WriteLine("getting the values from the hashtable");
            foreach (var values in ht.Values)
            {
                Console.WriteLine($" {values} ");
            }
            
            // update value of meyve key
            ht["meyve"] = "ayva";

            // cast to string value
            var keyStr = "meyve3";
            var valueStr = ht[keyStr] as string;
            Console.WriteLine($"Key: {keyStr} Value: {valueStr}");



            // check if key present or not
            bool containsKey = ht.ContainsKey("ali");
            Console.WriteLine($"Contains Key 'ali': {containsKey}");

            ht.Remove("ali");
            ht.Clear();
            Console.WriteLine($"HashTable ht Count: {ht.Count}");
        }
    }
}
