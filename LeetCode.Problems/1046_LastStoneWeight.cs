namespace LeetCode.Problems;

using System.Collections.Generic;

public class LastStoneWeight{

    public int LastWeight(int[] stones){

        List<int> stoneList = new List<int>();
        foreach(int stone in stones){
            stoneList.Add(stone);
        }

        while(stoneList.Count > 1){
            int stone1 = HeaviestStone(stoneList);
            int stone2 = HeaviestStone(stoneList);

            if(stone1 !=  stone2){
                stoneList.Add(stone1 - stone2);
            }
        }

        if(stoneList.Count == 0){
            return 0;
        }else{
            return stoneList[0];
        }

    }

    private int HeaviestStone(List<int> stones){
        int heavyStone = stones.Max();
        stones.Remove(heavyStone);
        return heavyStone;
    }

}