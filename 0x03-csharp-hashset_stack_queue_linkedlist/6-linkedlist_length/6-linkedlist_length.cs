using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int ct = 0;
        foreach (int node in myLList)
            ct ++;
        return (ct);
    }
}
