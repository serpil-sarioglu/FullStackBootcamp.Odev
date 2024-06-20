using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class GenericSortedListExamples
    {
        public void ExamplesWithGenericSortedList() 
        {
            // Sorted List anahtar değerine göre eleman ekleme sırasına bakılmaksızın yeniden sıralayan bir koleksiyon tipidir.
            var numberNames = new SortedList<int,string>();
            numberNames.Add(3, "Üç");
            numberNames.Add(4, "Dört");
            numberNames.Add(1, "Bir");
            numberNames.Add(2, "İki");
            numberNames.Add(5, "Beş");

            numberNames[5] = "BEŞ";
            numberNames[6] = "ALTI";

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


            string result = "";
            if (numberNames.TryGetValue(4, out result))
                Console.WriteLine("Key: {0}, Value: {1}", 4, result);
            else
                Console.WriteLine("Sonuç bulunamadı");            



            SortedList<string, string> cities = new SortedList<string, string>() {
                {"İstanbul", "Marmara"},
                {"Trabzon", "Karadeniz"},
                {"Erzurum", "Doğu Anadolu"},
                {"Adana", "Akdeniz"},
                {"Aydın", "Ege"},
                {"Ankara", "İç Anadolu"}
            };
    
            foreach (KeyValuePair<string, string> kvp in cities)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

        }
    }
}
