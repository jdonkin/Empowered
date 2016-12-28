using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTesting   
{
  [TestFixture]
  public class LinkedListWithCyclesTests
  {
    [Test]
    public void WithoutCyclesTest()
    {
      Node head = new Node(1);
      var ll = new LinkedListWithCycles(head);
      Node node2 = new Node(2);
      Node node3 = new Node(3);
      
      head.next = node2;
      node2.next = node3;
      node3.next = null;

      Assert.False(ll.IsTheLinkedListCyclic());
    }

    [Test]
    public void WithCyclesTest()
    {
      Node head = new Node(1);
      var ll = new LinkedListWithCycles(head);
      Node node2 = new Node(2);
      Node node3 = new Node(3);

      head.next = node2;
      node2.next = node3;
      node3.next = node2;

      Assert.True(ll.IsTheLinkedListCyclic());
    }
  }
}
