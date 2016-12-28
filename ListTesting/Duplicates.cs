using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTesting
{
  public class Duplicates
  {
    public bool AreThereDuplicates(int[] values)
    {
      var result = values.GroupBy(v => v).Where(c => c.Count() > 1).Select(s=>s.Key).ToList();
      if (result.Count >= 1)
      {
        return true;
      }
      return false;
    }
  }
}
