// See https://aka.ms/new-console-template for more information
using LeetCode.Problems;
using LeetCode.Problems.Utils;
using System.Globalization;

int i=0;
int j=3;

Console.WriteLine((i/3)*3 + (j/3));

char[][] board = new char[9][]{
    new char[9]{'5','3','.','.','7','.','.','.','.'},
    new char[9]{'6','.','.','1','9','5','.','.','.'},
    new char[9]{'.','9','8','.','.','.','.','6','.'},
    new char[9]{'8','.','.','.','6','.','.','.','3'},
    new char[9]{'4','.','.','8','.','3','.','.','1'},
    new char[9]{'7','.','.','.','2','.','.','.','6'},
    new char[9]{'.','6','.','.','.','.','2','8','.'},
    new char[9]{'.','.','.','4','1','9','.','.','5'},
    new char[9]{'.','.','.','.','8','.','.','7','9'},
};

char[][] board2 = new char[9][]{
    new char[9]{'8','3','.','.','7','.','.','.','.'},
    new char[9]{'6','.','.','1','9','5','.','.','.'},
    new char[9]{'.','9','8','.','.','.','.','6','.'},
    new char[9]{'8','.','.','.','6','.','.','.','3'},
    new char[9]{'4','.','.','8','.','3','.','.','1'},
    new char[9]{'7','.','.','.','2','.','.','.','6'},
    new char[9]{'.','6','.','.','.','.','2','8','.'},
    new char[9]{'.','.','.','4','1','9','.','.','5'},
    new char[9]{'.','.','.','.','8','.','.','7','9'},
};

Console.WriteLine(new ValidSudoku().IsValidSudoku(board2));