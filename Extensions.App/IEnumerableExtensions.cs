using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.App
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> WhereGreaterThan<T>(this IEnumerable<T> source, T threshold) where T : IComparable<T>
        {
            // Belirtilen `threshold` eşik değerden büyük olan item değerleri filtrelenir
            foreach (var item in source)
            {
                if (item.CompareTo(threshold) > 0)
                {
                    yield return item;
                }
            }
        }
    }
}

// Bu extension metot, IEnumerable<T> türünde tanımlı bir nesne üzerinden direkt çağrılarak kullanılır.
// where T : IComparable<T> kısıtı, T tipinin IComparable<T> arayüzünü implement etmesini zorunlu kılar.
// CompareTo metotu karşılaştırma yapar `item` değeri `threshold`'den büyükse pozitif değer döner.
// WhereGreaterThan<T> metotu bir IEnumarable<T> döndürür.