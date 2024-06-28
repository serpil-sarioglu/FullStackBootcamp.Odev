using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.App
{
    public static class ListExtensions
    {
        public static void ReverseOrder<T> (this List<T> list) where T: IComparable<T>
        {
            // Küçükten büyüğe sırala
            list.Sort();

            // Sonra sıralamayı tersine çevir
            list.Reverse();        
        }
    }
}
