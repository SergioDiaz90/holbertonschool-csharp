using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n > myLList.Count)
            return (0);
        int ct = 0;
        foreach (int node in myLList)
        {
            if (ct == n)
                return (node);
            ct ++;
        }
        return (0);
    }
}
