using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.App
{
    public class GenericSorter
    {
        // Sort<T> metotu `T` tipinde bir dizi alır. 
        // Tek bir generic method ile hem int[] hem de string[] gibi farklı veri tiplerini sıralayabiliriz.
        // IComparable<T> kısıtı T tipinin IComparable<T> arayüzünü uygulaması gerektiğini belirtir.
        // Bu arayüzü uygulayan, T tipindeki elemanların birbirleriyle karşılaştırılabileceğini garanti eder.
        public static void Sort<T>(T[] array) where T: IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        // array[i] elamanı array[j] elemanından büyükse öğeleri yer değiştir
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

        }
    }
}
