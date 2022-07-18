namespace LeetCode.Tests;

using LeetCode.Problems;
using NUnit.Framework;
using System;

public class LRUCache_Test{

    private LRUCache _solution;

    [SetUp]
    public void LRUCache(){
        //_solution = new LRUCache(4);
    }

    [Test]
    public void Test1(){
        int capacity = 2;

        _solution = new LRUCache(capacity);

        Assert.AreEqual(capacity, _solution.Capacity);

        Assert.AreEqual(-1, _solution.Get(1));
        _solution.Put(1,1);
        _solution.Put(2,2);   

        Assert.AreEqual(1, _solution.Get(1));

        _solution.Put(3,3);

        Assert.AreEqual(-1, _solution.Get(2));
        _solution.Put(4,4);
        Assert.AreEqual(-1, _solution.Get(1));
        Assert.AreEqual(3, _solution.Get(3));
        Assert.AreEqual(4, _solution.Get(4));
        
    }

    [Test]
    public void Test2(){
        int capacity = 2;

        _solution = new LRUCache(capacity);
        
        _solution.Put(1,1);
        _solution.Put(2,2);   

        Assert.AreEqual(1, _solution.Get(1));

        _solution.Put(3,3);

        Assert.AreEqual(-1, _solution.Get(2));
        _solution.Put(4,4);
        Assert.AreEqual(-1, _solution.Get(1));
        Assert.AreEqual(3, _solution.Get(3));
        Assert.AreEqual(4, _solution.Get(4));
        
    }

}