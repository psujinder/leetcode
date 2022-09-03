namespace LeetCode.Problems;

public class SpecialIntegers{

/*
    1 - 9 there are 0 non special and 10 special 
    10 - 99 there are 9 non special and 91 special 
    100 - 99 there are 99 non special


    count the number of thousands, hundreds, tens and ones

    for one there are 9 specials
    for every tens there are 9 special
    for every hundreds there are 81 special
    for every thousands tehre are 729 special

*/




    public int SpecialIntegerCount(int num){
        
        int len = num.ToString().Length;
        int nonSpecialCount = 0;
        int specialCount = 0;
        int thousands = 0;
        int hundreds = 0;
        int tens = 0;
        int ones = 0;

        if (num > 10)
            ones = num % 10;
        else
            ones = num;
        specialCount += ones;

        num = num / 10;
        tens = num % 10;
        specialCount += tens *9;
        
        return specialCount;
    }

}