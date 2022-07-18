namespace LeetCode.Tests;

using NUnit.Framework;
using LeetCode.Problems;

public class ContainerWithMostWater_Test{

    private ContainerWithMostWater _solution;

    [SetUp]
    public void ContainerWithMostWater(){
        _solution = new ContainerWithMostWater();
    }

    [Test]
    public void Test1(){
        int[] arr = {1,8,6,2,5,4,8,3,7};

        var result = _solution.MaxArea(arr);
        Assert.AreEqual(49, result);
    }

    public void Test2(){
        int[] arr = {1,1};

        var result = _solution.MaxArea(arr);
        Assert.AreEqual(1, result);
    }

}