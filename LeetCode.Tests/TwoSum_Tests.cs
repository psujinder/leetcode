namespace LeetCode.Tests;

using NUnit.Framework;
using LeetCode.Problems;
using System;

[TestFixture]
public class TwoSum_Test{

    private TwoSum _solution;

    [SetUp]
    public void Setup(){
        _solution = new LeetCode.Problems.TwoSum();
    }

    [Test]
    public void SumIs_9(){
        int[] arr = new int[]{2,7,11,15};
        int target = 9;

        var result = _solution.Execute(arr,target);

        Console.WriteLine(result);
        Assert.AreEqual(2, result.Length);
        Assert.AreEqual(result[0], 0);
        Assert.AreEqual(result[1], 1);
    }

    [Test]
    public void SumIs_6(){
        int[] arr = new int[]{3,2,4};
        int target = 6;

        var result = _solution.Execute(arr,target);

        Assert.AreEqual(2, result.Length);
        Assert.AreEqual(result[0], 1);
        Assert.AreEqual(result[1], 2);
    }


    [Test]
    public void SumIs_6_v2(){
        int[] arr = new int[]{3,3};
        int target = 6;

        var result = _solution.Execute(arr,target);

        Assert.AreEqual(2, result.Length);
        Assert.AreEqual(result[0], 0);
        Assert.AreEqual(result[1], 1);
    }
}