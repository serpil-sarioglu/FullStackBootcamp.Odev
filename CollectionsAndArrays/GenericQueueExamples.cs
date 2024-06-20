using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class GenericQueueExamples
    {
        public void ExamplesWithGenericQueue()
        {
            // Queue => FIFO first in first out
            Queue<string> myQueue = new Queue<string>();

            // Adding elements in Queue 
            // Using Enqueue() method  
            Console.WriteLine("Enqueue metodu ile kuyruğun sonuna eleman eklendi");
            myQueue.Enqueue("one");
            myQueue.Enqueue("two");
            myQueue.Enqueue("three");
            myQueue.Enqueue("four");
            myQueue.Enqueue("five");

            // Accessing the elements of myQueue Queue 
            // Using foreach loop 
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

   
            Console.WriteLine("myQueue koleksiyonu eleman sayısı: {0}", myQueue.Count);

            // Get the top element of myQueue
            // Using the Dequeue method
            Console.WriteLine("Dequeuing '{0}'", myQueue.Dequeue());
            
            // After Dequeue method 
            Console.WriteLine("Dequeue metodu ile myQueue kuyruğunun en üstteki ilk elemanı elde edilir ve kuyruktan çıkarılır" +
                "\nmyQueue koleksiyonu eleman sayısı: {0}", myQueue.Count);

            // Get the top element of myQueue
            // Using the Peek method
            Console.WriteLine("Peek metodu ile myQueue kuyruğunun en üstteki ilk elemanı : {0} elde edilir" +
                "\nmyQueue koleksiyonu eleman sayısı: {1}", myQueue.Peek(), myQueue.Count());

            // Checking if the element is 
            // present in the Queue or not           
            var result = (myQueue.Contains("five") == true) ? "Öğe bulunuyor" : "Öğe bulunmuyor";
            Console.WriteLine(result);
        }
    }
}
