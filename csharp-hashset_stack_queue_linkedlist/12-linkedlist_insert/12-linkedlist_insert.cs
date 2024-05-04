using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;

        if (node != null)
        {
            if (node.value < n)
            {
                node = node.next;
            }
            else
            {
                myLList.AddAfter(node, n);
                return myLList.First;
            }
        }
        myLList.AddLast(n);
        return myLList.First;
    }
}