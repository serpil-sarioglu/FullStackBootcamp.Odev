using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class ArrayListExamples
    {
        public void ExamplesWithArrayList()
        {
            // adding elements using object initializer syntax
            ArrayList arrList2 = new ArrayList() { 2, "Veli", true," ", 4.5, null, "Veli"};
            arrList2.Insert(1, "Venüs");
            arrList2[4] = "Dünya";
            arrList2.RemoveAt(0);
            
            WriteArrayList(arrList2);
            Console.WriteLine(arrList2.IndexOf("Dünya"));

            var newArrList = arrList2.GetRange(0, 4);
            WriteArrayList(newArrList);

            // adding elements using ArrayList.Add() method
            ArrayList arrList = new ArrayList();
            arrList.Add("Merkür");
            arrList.Add(10);
            arrList.Add(true);

            arrList[0] = "Dünya";
            arrList[2] = "Merkür";
          

            List<Shape> shapes = new List<Shape>() {
                new Shape() {Id = 1, Name = "Kare"},
                new Shape() {Id = 2, Name = "Daire"},
                new Shape() {Id = 3, Name = "Üçgen"}
            };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");

            //Use AddRange method
            //Adding entire List<>, Queue into ArrayList
            arrList.AddRange(shapes);
            arrList.AddRange(myQ);

            //Accessing Elements of ArrayList
            string firstElement = arrList[0] as string;
            int secondElement = (int)arrList[1];
            Shape? fourthElement = arrList[4] as Shape;
            Console.WriteLine(fourthElement != null ? "Shape" : "Null");

            var fifthElement = arrList[5];
            Console.WriteLine(fifthElement);

            //Iterate Arraylist
            WriteArrayList(arrList);

        }

        private static void WriteArrayList(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
    public class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
