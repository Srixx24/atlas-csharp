using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> node = myLList.First;
        int x = 0;

        while (node != null)
        {
            if (x == index)
            {
                myLList.remove(node);
            }

            node = node.next;
            x++;
        }
    }
}