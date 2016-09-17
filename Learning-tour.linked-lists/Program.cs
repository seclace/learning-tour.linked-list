using System;

namespace Learning_tour.linked_lists {
    class Program {
        static void Main(string[] args) {
            LinkedList list = new LinkedList();
            list.add("Первый узел");
            list.add("Second node");
            list.add("Tres node");
            list.add("4 node");

            for (int i = 0; i < list.count;) {
                Console.WriteLine(list.get(i++).data);
            }

            list.add("Temp data", 2);

            for (int i = 0; i < list.count;) {
                Console.WriteLine(list[i++].data);
            }

            Console.ReadKey();
        }
    }
}
