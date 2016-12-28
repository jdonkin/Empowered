using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTesting
{
  [TestFixture]
  public class DuplicatesTest
  {
    Duplicates dup = new Duplicates();
    [TestCase(new int[] { 1, 2, 3, 4, 5, 1 })]
    [TestCase(new int[] {1,1,2,2,3,3,4,4,5,5 })]
    public void AreThereDuplicatesTrueTest(int[] testArray)
    {
      var testValues = dup.AreThereDuplicates(testArray);
      Assert.True(testValues);
    }

    [TestCase(new int[] { 1,2,3,4})]
    [TestCase(new int[] { 5,6,7,8})]
    public void AreThereDuplicatesFalseTest(int [] testArray)
    {
      var testValues = dup.AreThereDuplicates(testArray);
      Assert.False(testValues);
    }


  }
}
