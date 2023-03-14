namespace SearchRotatedArray.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 0;
        int result = _test.Search(nums, target);
        Assert.AreEqual(4, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 3;
        int result = _test.Search(nums, target);
        Assert.AreEqual(-1, result);
    } 
    
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { 1 };
        int target = 0;
        int result = _test.Search(nums, target);
        Assert.AreEqual(-1, result);
    }
}