using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class GenericStackExamples
    {
        public void ExamplesWithGenericStack()
        {
            // Stack => LIFO last in first out
            Stack<int> numbers = new Stack<int>();
            // Using the Push method
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            
            // Using the Pop method
            Console.WriteLine("Pop '{0}'", numbers.Pop());
            Console.WriteLine("Pop metodu kullandıktan sonra Stack eleman sayısı '{0}'", numbers.Count());


            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
                        
            // Using the Peek method
            Console.WriteLine("Peek '{0}'", numbers.Peek());
            Console.WriteLine("Peek metodu kullandıktan sonra Stack eleman sayısı '{0}'", numbers.Count());

            Console.WriteLine("Stack koleksiyonundan pop metodu ile elemanları çıkar...");
            while (numbers.Any())
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
