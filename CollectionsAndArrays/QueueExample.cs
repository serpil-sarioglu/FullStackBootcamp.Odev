using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class QueueExample
    {
        public void ExamplesWithQueue()
        {
            Queue numbers = new Queue();         
            numbers.Enqueue(10);
            numbers.Enqueue(20);
            numbers.Enqueue(30);
            numbers.Enqueue(40);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Dequeue metodu kuyruktan silerek ilk elemanı: {numbers.Dequeue()} getirir ");
            Console.WriteLine($"Dequeue metodu kullanılması sonrası Queue eleman sayısı: {numbers.Count}"); 

            int total = 0;
            foreach (var item in numbers)
            {
                 total += (int)item;
            }

            Console.WriteLine($"Peek metodu kuyruktan silmeden ilk elemanı: {numbers.Peek()} getirir ");
            Console.WriteLine($"Peek metodu kullanılması sonrası Queue eleman sayısı: {numbers.Count}");
        }
    }
}
