namespace LeetCode.Tests;

using LeetCode.Problems;
using NUnit.Framework;
using System;

public class Atoi_Test{

    private Atoi _solution;

    [SetUp]
    public void Atoi(){
        _solution = new Atoi();
    }

    [Test]
    public void Is42(){
        var s = "42";

        var result = _solution.MyAtoi(s);

        Assert.AreEqual(42, result);
        
    }

    
    [Test]
    public void IsNeg42(){
        var s = "  -42";

        var result = _solution.MyAtoi(s);

        Assert.AreEqual(-42, result);
        
    }

    [Test]
    public void Is4132(){
        var s = "4193 with words";
        var result = _solution.MyAtoi(s);

        Assert.AreEqual(4193, result);
    }

    [Test]
    public void IsIntMax(){
        var s = "2147483647";
         var result = _solution.MyAtoi(s);

        Assert.AreEqual(2147483647, result);
    }

    [Test]
    public void IsOverFlow(){
        var s = "2147483648";
         var result = _solution.MyAtoi(s);

        Assert.AreEqual(2147483647, result);
    }

    [Test]
    public void IsIntMin(){
        var s = "-2147483647";
         var result = _solution.MyAtoi(s);

        Assert.AreEqual(-2147483647, result);
    }

    [Test]
    public void IsUnderflow(){
        var s = "-2147483648";
         var result = _solution.MyAtoi(s);

        Assert.AreEqual(-2147483647, result);
    }
    

}