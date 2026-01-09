using System.Collections;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        // HashTableDemo.Demo();
        // SortedListDemo.Demo();
        // StackDemo.Demo();
        // QueueDemo.Demo();
        // BoxingUnBoxing.Demo(); 
        // WithoutGenericDemo.Demo();
        // WithGenericDemo.Demo();
        // GenericListDemo.Demo();
        // GenericSortedListDemo.Demo();
        // GenericDictionaryDemo.Demo();
        // GenericStackDemo.Demo();
        // GenericQueueDemo.Demo();

        MyCollection obj = new MyCollection();
        foreach(int i in obj){
            Console.WriteLine(i);
        }
    }
}