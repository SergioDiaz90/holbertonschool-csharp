using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> new_List = new LinkedList<int>();
        if (size < 0)
            return (new_List);
        for (int i = 0; i < size; i++)
            new_List.AddLast(i);
        foreach (int node in new_List)
            Console.WriteLine(node);
        return (new_List);
    }
}
