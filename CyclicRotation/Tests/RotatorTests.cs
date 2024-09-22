using CyclicRotation;

namespace Tests;

public class RotatorTests
{
    [Test]
    public void Test_Various()
    {
        var result = Rotator.Rotate([3, 8, 9, 7, 6], 3);

        CollectionAssert.AreEqual(
                                  new[]
                                  {
                                      9, 7, 6, 3, 8
                                  },
                                  result);
    }
    
    [Test]
    public void Test_SameElems()
    {
        var result = Rotator.Rotate([0, 0, 0], 1);

        CollectionAssert.AreEqual(
                                  new[]
                                  {
                                      0, 0, 0
                                  },
                                  result);
    }
    
    [Test]
    public void Test_RotationsEqualToLength()
    {
        var result = Rotator.Rotate([1, 2, 3, 4], 4);

        CollectionAssert.AreEqual(
                                  new[]
                                  {
                                      1, 2, 3, 4
                                  },
                                  result);
    }
    
    [Test]
    public void Test_RotationsTimesMore()
    {
        var result = Rotator.Rotate([3, 8, 9, 7, 6], 14);

        CollectionAssert.AreEqual(
                                  new[]
                                  {
                                      8, 9, 7, 6, 3
                                  },
                                  result);
    }
    
    [Test]
    public void Test_Empty()
    {
        var result = Rotator.Rotate([], 14);

        CollectionAssert.AreEqual(Array.Empty<int>(), result);
    }
}