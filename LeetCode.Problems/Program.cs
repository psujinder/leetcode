// See https://aka.ms/new-console-template for more information
using LeetCode.Problems;
using LeetCode.Problems.Utils;
using System.Globalization;


TicTacToe2 obj = new TicTacToe2(3);
Console.WriteLine(obj.Move(0,0,1));
Console.WriteLine(obj.Move(0,2,2));
Console.WriteLine(obj.Move(2,2,1));
Console.WriteLine(obj.Move(1,1,2));
Console.WriteLine(obj.Move(2,0,1));
Console.WriteLine(obj.Move(1,0,2));
Console.WriteLine(obj.Move(2,1,1));
