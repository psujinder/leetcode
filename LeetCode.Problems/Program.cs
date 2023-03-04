// See https://aka.ms/new-console-template for more information
using LeetCode.Problems;
using LeetCode.Problems.Utils;
using System.Globalization;


Person adam = new Person("Adam");
Person eve = new Person("Eve");
Person cain = new Person("Cain");
Person abel = new Person("Abel");
Person seth = new Person("Seth");
adam.Children.Add(eve);
eve.Children.Add(cain);
eve.Children.Add(abel);
eve.Children.Add(seth);
cain.Parent = eve;
abel.Parent = eve;
seth.Parent = eve;

Person ancestor = FindRelation.FindAncestorBFS(adam, "Cain");