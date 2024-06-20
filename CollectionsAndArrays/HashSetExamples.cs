using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class HashSetExamples
    {
        public void ExamplesWithHashSet()
        {
            HashSet<string> bigCities = new HashSet<string>();
            bigCities.Add("İstanbul");
            bigCities.Add("Ankara");
            bigCities.Add("İzmir");
            bigCities.Add("Bursa");
            bigCities.Add("Samsun");

         
            var bigCities2 = new[] { "İzmir", "Ankara", "Antalya", "Adana" };


            #region HashSet vs List Contains() metoduyla işlem yapılırken performans ölçümü 
            
            List<string> newBigCitiesList = new List<string>(bigCities2);

            var s2 = Stopwatch.StartNew();
            foreach (var item in bigCities2)
            {
                newBigCitiesList.Contains(item);
            }
            s2.Stop();
            Console.WriteLine("List kolleksiyonu işlem süresi: " + s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));


            // newBigCities HashSet kolleksiyonu, başlangıçta bigCities2 dizisini içine alarak tanımlanır
            HashSet<string> newBigCities = new HashSet<string>(bigCities2);

            var s1 = Stopwatch.StartNew();
            foreach (var item in bigCities2)
            {
                newBigCities.Contains(item);
            }
            s1.Stop();
            Console.WriteLine("HashSet kolleksiyonu işlem süresi: " + s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); 
            #endregion


            Console.WriteLine("UnionWith() metodu newBigCities ve bigCities iki hashset kolleksiyonu birleştirir");
            newBigCities.UnionWith(bigCities);

            Console.Write($"{newBigCities.Count} elemanlı newBigCities hashset kolleksiyonu:");
            DisplaySet(newBigCities);
            

            Console.WriteLine("RemoveWhere() metodu şart tanımı yapılır içinde 'an' karakteri olan elamanları siler");
            newBigCities.RemoveWhere(r => r.Contains("an"));
            DisplaySet(newBigCities);

            Console.WriteLine("IntersectWith() metodu newBigCities koleksiyonu bigCities koleksiyonuyla kesişim elemanlarını alarak değiştirir");
            newBigCities.IntersectWith(bigCities);
            DisplaySet(newBigCities);


            Console.WriteLine("ExceptWith() metodu newBigCities koleksiyonunda bigCities koleksiyonundaki kesişim elemanlarını siler");
            newBigCities.ExceptWith(bigCities);
            DisplaySet(newBigCities);


        }
        public void DisplaySet(HashSet<string> collection)
        {
            Console.Write("{");
            foreach (var item in collection)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine(" }");
        }
    }
}