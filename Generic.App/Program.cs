using Generics.App;

#region Sıralama Algoritması
int[] intArray = { 3, 1, 4, 1, 5, 9 };
string[] stringArray = { "ayakkabı", "çanta", "kalem", "defter", "cüzdan"};

Console.WriteLine("Orijinal int array: " + string.Join(", ", intArray));
GenericSorter.Sort<int>(intArray);
Console.WriteLine("Küçükten büyüğe sıralı int array: " + string.Join(", ", intArray));

Console.WriteLine("Orijinal string array: " + string.Join(", ", stringArray));
GenericSorter.Sort<string>(stringArray);
Console.WriteLine("Küçükten büyüğe sıralı string array: " + string.Join(", ", stringArray));
#endregion

#region Veri Depolama 

var intStore = new DataStorage<int>();
intStore.Add(1);
intStore.Add(2);
intStore.Add(3);

Console.WriteLine("Integer değerler için veri depolama");
intStore.DisplayAll();

var stringStore = new DataStorage<string>();
stringStore.Add("Ayşe");
stringStore.Add("Zeynep");
stringStore.Add("Mehmet");

Console.WriteLine("String değerler için veri depolama");
stringStore.DisplayAll();

Console.WriteLine("String Liste 0.elemanı: " + stringStore.GetByIndex(0));
Console.WriteLine("String Liste eleman sayısı: " + stringStore.Count); 
#endregion