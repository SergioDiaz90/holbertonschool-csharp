using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int result = 0;
        List<int> new_List = myList;
        new_List.Sort();
        for (int i = 0; i < new_List.Count; i++)
        {
            if (i == 0 || new_List[i] != new_List[i - 1])
                result += myList[i];
        }
        return (result);
    }
}
