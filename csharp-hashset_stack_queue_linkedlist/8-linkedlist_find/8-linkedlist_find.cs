using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        LinkedListNode<int> node = myLList.First;

        foreach (int val in myLList)
        {
            if (node.Value == value)
                {
                    return index;
                }
            node = node.Next;
            index++;
        }

        return -1;
    }
}