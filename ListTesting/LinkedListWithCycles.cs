using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTesting
{
  public class LinkedListWithCycles
  {
    Node Head;

    public LinkedListWithCycles(Node head)
    {
      this.Head = head;
    }

    public bool IsTheLinkedListCyclic()
    {
      Node slow = Head;
      Node fast = Head.next;

      while (slow != null && fast != null)
      {
        if (slow == fast)
        {
          return true;
        }

        slow = slow.next;
        fast = fast.next.next;
      }
      return false;
    }
  }
}
