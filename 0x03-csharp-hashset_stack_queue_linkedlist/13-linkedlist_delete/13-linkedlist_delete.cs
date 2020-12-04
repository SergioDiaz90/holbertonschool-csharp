using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        LinkedListNode<int> current_Node = myLList.First;
        for (; i < index && current_Node.Next != null; i++)
            current_Node = current_Node.Next;
        if (i == index)
            myLList.Remove(current_Node);
    }
}
