using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.App
{
    public static class DictionaryExtensions
    {
        public static TValue GetOrDefault<TKey,TValue>(
            this Dictionary<TKey,TValue> dictionary, 
            TKey key,
            TValue defaultValue = default)
        {
            if (dictionary.TryGetValue(key,out TValue value))
            {
                return value;
            }
            return defaultValue;
        }
    }
}



//Extension metot nasıl yazılmalıdır?
//* Statik bir sınıf içinde tanımlanmalı.
//* Statik bir metot olmalı.
//* İlk parametresi this anahtar kelimesi ile belirtilmeli ve genişletilmek istenen sınıf türünde olmalı (Dictionary bu durumda).


//GetOrDefault extension metodu açıklamaları:

// => Generic Türler : TKey, TValue

// => Parametreler : this Dictionary<TKey,TValue> dictionary, TKey key, TValue defaultValue = default
// `this Dictionary<TKey,TValue> dictionary`: Bu, metodun Dictionary<TKey, TValue> türündeki herhangi bir nesne için bir extension method olduğunu belirtir. 
// `TKey key`: Bu, Dictionary içinde aramak istediğiniz anahtarı temsil eder.
// `TValue defaultValue = default` : Bu, opsiyonel parametredir ve belirtilmezse türün varsayılan değeri kullanılır.

// => `Dictionary`'nin TryGetValue metodu belirtilen anahtarın değerini bulmaya çalışır.
// Eğer anahtar bulunursa, ilgili değeri döner. Bulunamazsa, defaultValue parametresini döner.


//Extension metot yararları:

//Kolay kullanım sağlar. Dictionary türüne eklenen GetOrDefault metodu ile değerleri daha kolay alabiliriz.
//Kodun kapsamını genişletir. Dictionary sınıfına GetOrDefault metodu ile yeni işlevsellik eklendi.
//Kodun yeniden kullanılabilirliğini artırır. Farklı türdeki tüm Dictionary nesnelerinde kullanılabilir.