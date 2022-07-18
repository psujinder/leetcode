namespace LeetCode.Tests;

using NUnit.Framework;
using LeetCode.Problems;
using System;

[TestFixture]
public class ValidParentheses_Test{

    private ValidParentheses _solution;

    [SetUp]
    public void Setup(){
        _solution = new LeetCode.Problems.ValidParentheses();
    }

    [Test]
    public void IsValid_1(){
        string s = "()";
        
        var result = _solution.IsValid(s);

        Assert.AreEqual(true, result);
    }
    
    [Test]  
    public void IsValid_2(){
        string s = "()[]{}";
        
        var result = _solution.IsValid(s);

        Assert.AreEqual(true, result);
    }

    [Test]
    public void IsValid_3(){
        string s = "(]";
        
        var result = _solution.IsValid(s);

        Assert.AreEqual(false, result);
    }

}