using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = new LinkedListNode<int>(n);
        LinkedListNode<int> current_Node;
        current_Node = myLList.First;
        while (current_Node != null)
        {
            if (current_Node.Value < n)
            {
                current_Node = current_Node.Next;
            }
            else
            {
                return (myLList.AddBefore(current_Node, n));
            }
        }
        return (myLList.AddLast(n));
    }
}
