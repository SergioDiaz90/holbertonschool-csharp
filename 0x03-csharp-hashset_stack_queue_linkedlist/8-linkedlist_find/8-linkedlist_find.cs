using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int ct = 0;
        foreach (int node in myLList)
        {
            if (value == node)
                return (ct);
            ct ++;
        }
        return (-1);
    }
}
