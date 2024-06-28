using Extensions.App;

#region ICollection için Extension Metot 
// ICollection<int> türündeki numbers listesi  
ICollection<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// AddRange methodunu kullanarak birden fazla eleman eklenir
numbers.AddRange<int>(new List<int> { 6, 7, 8 });


// Koleksiyondaki elemanları ekrana yazdırır
Console.WriteLine("After AddRange:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// RemoveRange methodunu kullanarak birden fazla eleman çıkarır
numbers.RemoveRange(new List<int> { 2, 3 });

// Koleksiyondaki elemanları ekrana yazdırır
Console.WriteLine("After RemoveRange:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

#endregion

#region IEnumerable için Extension Method 
IEnumerable<int> intNumbers = new List<int> { 1, 5, 8, 10, 12, 3, 7 };

// WhereGreaterThan methodunu kullanarak filtreleme (int)
IEnumerable<int> intGreaterThanFive = intNumbers.WhereGreaterThan(5);

Console.WriteLine("5'ten büyük sayılar:");
foreach (var number in intGreaterThanFive)
{
    Console.WriteLine(number);
} 

#endregion

#region List için Extension Method 
List<string> names = new List<string> { "Ayşe", "Zeynep", "Mustafa", "Gülay", "Orhan", "Can" };

// ReverseOrder methodunu kullanarak önce liste küçükten büyüğe sıralanır sonra tersine çevrilir
names.ReverseOrder();
Console.WriteLine("Küçükten büyüğe sıralanıp tersine çevrilmiş liste: " + string.Join(", ", names));

#endregion

#region Dictionary için Extension Method

// Dictionary örneği
Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            { 1, "Bir" },
            { 2, "İki" },
            { 3, "Üç" }
        };

// GetOrDefault metodunu kullanma
Console.WriteLine(dictionary.GetOrDefault(1, "Varsayılan Değer")); // Çıktı: Bir
Console.WriteLine(dictionary.GetOrDefault(4, "Varsayılan Değer")); // Çıktı: Varsayılan Değer
Console.WriteLine(dictionary.GetOrDefault(4)); // Çıktı: (boş, çünkü default(string) = null) 

#endregion


