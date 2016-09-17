using System;

namespace Learning_tour.linked_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.addNode("Первый узел");
            list.addNode("Second node");
            list.addNode("Tres node");
            list.addNode("4 node");

            for (int i = 0; i < list.count; )
            {
                Console.WriteLine(list.getNodeByIndex(i++).data);
            }

            list.addNodeByIndex("Temp data", 2);

            for (int i = 0; i < list.count; )
            {
                Console.WriteLine(list[i++].data);
            }

            Console.ReadKey();
        }
    }
}
