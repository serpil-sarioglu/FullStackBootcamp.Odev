using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.App
{

    //DataStorage<T> generic sınıfı, farklı veri tipleriyle tekrar tekrar yazılmadan kullanılabilir.
    //Generics kullanarak derleme zamanı tip kontrolü sağlanır sadece belirtilen veri türündeki verilerin DataStorage içine eklenmesini sağlar.

    public class DataStorage<T>
    {
        //Generic tipte liste tanımlanır
        private List<T> _data = new();


        // Liste eleman sayısını verecek property  
        public int Count 
        { 
            get { return _data.Count; } 
        }

        // Sınıfı tanımlarken verilen tip T türünden öğeleri listeye ekleyen metot
        public void Add(T item)
        { 
            _data.Add(item);
        }

        // Indekse göre elemanı veren metot 
        public T GetByIndex(int index)
        {
            if (index < 0 || index >= _data.Count)
            {
                throw new IndexOutOfRangeException("Geçersiz indeks");
            }
            return _data[index];
        }

        // Listedeki elemanları yazdıran metot
        public void DisplayAll()
        {
            foreach (T item in _data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
