using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;

        if (node != null)
        {
            while (node != null && node.Value < n)
            {
                node = node.Next;
            }

            if (node != null)
            {
                myLList.AddBefore(node, n);
                return myLList.First;
            }
        }

        myLList.AddLast(n);
        return myLList.First;
    }
}