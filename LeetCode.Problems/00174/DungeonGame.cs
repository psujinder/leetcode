namespace LeetCode.Problems;

public class DungeonGame{

    
    public int CalculateMinimumHP(int[][] dungeon) {
        
      return calculateMinimumHP(0, 0, dungeon);
    }

     private int calculateMinimumHP(int r, int c, int[][] dungeon) {
        if ((r == dungeon.Length && c == dungeon[0].Length - 1) || (r == dungeon.Length - 1 && c == dungeon[0].Length)) return 1;
        if (r >= dungeon.Length || c >= dungeon[0].Length) return Int32.MaxValue;

        int hp1 = calculateMinimumHP(r, c + 1, dungeon);
        int hp2 = calculateMinimumHP(r + 1, c, dungeon);
        int health = Math.Min(hp1, hp2) - dungeon[r][c];

        return health > 0 ? health : 1;
    }
}