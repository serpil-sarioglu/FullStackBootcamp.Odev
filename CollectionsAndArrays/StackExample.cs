using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class StackExample
    {
        public void ExamplesWithStack()
        {
            Stack numbers = new Stack();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
           

            Console.WriteLine($"Pop metodu stackten silerek en üstte son giren ilk elemanı: {numbers.Pop()} getirir ");
            Console.WriteLine($"Pop metodu kullanılması sonrası Stack eleman sayısı: {numbers.Count}");

            int total = 0;
            foreach (var item in numbers)
            {
                total += (int)item;
            }
            Console.WriteLine($"Toplam: {total}");

            Console.WriteLine($"Peek metodu stackten silmeden en üstteki ilk elemanı: {numbers.Peek()} getirir ");
            Console.WriteLine($"Peek metodu kullanılması sonrası Stack eleman sayısı: {numbers.Count}");

            
        }
    }
}
