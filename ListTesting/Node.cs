using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTesting
{
  public class Node
  {
    private object data;
    public Node next { get; set; }
    public Node(object data)
    {
      this.data = data;
    }
  }
}
