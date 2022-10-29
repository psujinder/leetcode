namespace LeetCode.Problems;

public class MaxUnitsOnTruck{
    public int MaximumUnits(int[][] boxTypes, int truckSize) {

        int ans = 0;
        int remainingBoxes = truckSize;
        
        Array.Sort(boxTypes, (a,b)=> b[1].CompareTo(a[1]));

        for(int i=0; i< boxTypes.Length; i++){
            int boxCount = 0;

            boxCount = (boxTypes[i][0] < remainingBoxes) ? boxTypes[i][0]:remainingBoxes;
            ans += boxCount * boxTypes[i][1];
            remainingBoxes -= boxCount;

            if (remainingBoxes ==0){
                break;
            }
        }

        return ans;
    }

}