namespace CollectionsAndArrays
{
    public class LinkedListExamples
    {
        public void ExamplesWithLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("Ahmet");
            linkedList.AddLast("Mehmet");
            LinkedListNode<string> aliNode = linkedList.AddLast("Ali");
            linkedList.AddLast("Hayri");           
            
            linkedList.AddAfter(aliNode, "Cihan");            
            var ahmetNode = linkedList.Find("Ahmet");
            linkedList.AddAfter(ahmetNode, "Fatma");

            WriteLinkedList(linkedList);

            var firstElement = linkedList.First();
            Console.WriteLine("LinkedList First Element:" + firstElement);
           
            linkedList.Remove("Ahmet");
            Console.WriteLine("LinkedList Elements After Remove & RemoveFirst");
            linkedList.RemoveFirst();
            
            WriteLinkedList(linkedList);

            Console.WriteLine("Is Ali value exists:" + linkedList.Contains("Ali"));

        }

        private static void WriteLinkedList(LinkedList<string> linkedList)
        {
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
