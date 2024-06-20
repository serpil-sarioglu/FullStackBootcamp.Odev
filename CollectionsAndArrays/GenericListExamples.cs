using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class GenericListExamples
    {
        public void ExamplesWithGenericList()
        {
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);             

            var cities = new List<string>();
            cities.Add("Adana");
            cities.Add("Adıyaman"); 

            cities.Remove("Adıyaman");
            
            cities.AddRange(new List<string>() { "İstanbul", "Ankara" });            
            cities.Sort();

            cities.ForEach(x => Console.WriteLine($"{cities.IndexOf(x)} - {x}"));
            Console.WriteLine($"Count: {cities.Count()}");

            var bigCities = new List<string>()
            {
                "İstanbul",
                "Ankara",
                "İzmir",
                "Bursa",
                "Samsun"
            };

            List<string> newBigCities = new List<string>() { "İzmir","Ankara","Antalya","Adana"};

            bigCities.ForEach(x =>
            {
                if (!newBigCities.Contains(x))
                {
                    newBigCities.Add(x);
                }
            });

            Console.WriteLine("New Big Cities için örnek");

            foreach (var item in newBigCities)
            {
                Console.WriteLine(item);
            }

 

            Console.WriteLine("List<Book> için örnek");

            //List<Book> books = new List<Book>()
            //{
            //    new Book(1,"Vatan Yahut Silistre","Namık Kemal",100),
            //    new Book(2,"Tutunamayanlar","Oguz Atay",150),
            //    new Book(3,"Yaban","Yakup Kadri Karaosmanoğlu",200),
            //    new Book(4,"Zeytindağı","Falih Rıfkı Atay",250),
            //    new Book(5,"Sodom ve Gomore","Yakup Kadri Karaosmanoğlu",250)
            //};
            
            //List<Book> bookSubList = books.Where(p => p.Author == "Yakup Kadri Karaosmanoğlu").ToList();
            
            //foreach (var item in bookSubList)
            //{
            //    Console.WriteLine($"{item.Title} - {item.Author} {item.Price}");
            //}


        }

    }
    
}
