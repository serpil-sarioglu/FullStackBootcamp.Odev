using CollectionsAndArrays;
using System.Collections;

// System.Collections Namespace

#region Array 
//var arrayExample = new ArrayExamples();
//arrayExample.ExamplesWithArray();
#endregion

#region ArrayList 
//var arrayListExample = new ArrayListExamples();
//arrayListExample.ExamplesWithArrayList();
#endregion

#region Hashtable 
//var hastableExample = new HashTableExamples();
//hastableExample.ExamplesWithHashTable();
#endregion

#region Queue 
//var queueExample = new QueueExample();
//queueExample.ExamplesWithQueue();
#endregion

#region Stack
//var stackExample = new StackExample();
//stackExample.ExamplesWithStack();
#endregion

// System.Collections.Generic Namespace

#region List<T> GenericExamples & GenericExamples2 
//var genericListExample = new GenericListExamples();
//genericListExample.ExamplesWithGenericList();

//var bookService = new BookService(new BookRepository());
//bookService.Add(new Book(1, "Vatan Yahut Silistre", "Namık Kemal", 100));
//bookService.Add(new Book(2, "Tutunamayanlar", "Oguz Atay", 150));
//bookService.Add(new Book(3, "Yaban", "Yakup Kadri Karaosmanoğlu", 200));
//bookService.Add(new Book(4, "Zeytindağı", "Falih Rıfkı Atay", 250));
//bookService.Add(new Book(5, "Sodom ve Gomore", "Yakup Kadri Karaosmanoğlu", 250));


//var bookList = bookService.GetBooks();

//List<Book> bookSubList = bookList.Where(p => p.Author == "Yakup Kadri Karaosmanoğlu").ToList();

//foreach (var item in bookSubList)
//{
//	Console.WriteLine($"{item.Title} - {item.Author} {item.Price}");
//}
#endregion

#region Dictionary<TKey,TValue 
//var dictionaryExample = new DictionaryExamples();
//dictionaryExample.ExamplesWithDictionary();
#endregion

#region SortedList<TKey,TValue>
var genericSortedListExample = new GenericSortedListExamples();
genericSortedListExample.ExamplesWithGenericSortedList();
#endregion

#region Queue<T> 
//var genericQueueExample = new GenericQueueExamples();
//genericQueueExample.ExamplesWithGenericQueue();
#endregion

#region Stack<T> 
//var genericStackExample = new GenericStackExamples();
//genericStackExample.ExamplesWithGenericStack();
#endregion

#region HashSet<T> 
//var hashSetExample = new HashSetExamples();
//hashSetExample.ExamplesWithHashSet();

#endregion

#region LinkedList<T>
//var linkedListExample = new LinkedListExamples();
//linkedListExample.ExamplesWithLinkedList();
#endregion




