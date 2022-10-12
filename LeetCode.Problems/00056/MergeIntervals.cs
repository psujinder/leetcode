namespace LeetCode.Problems;

public class MergeIntervals{

     List<int[]> mergedIntervals = new List<int[]>();

    public int[][] Merge(int[][] intervals){

       Array.Sort(intervals, (a, b) =>
            {
                var comp = a[0].CompareTo(b[0]);
                if (comp == 0)
                    comp = a[1].CompareTo(b[1]);
                return comp;
            });
            
        mergedIntervals.Add(intervals[0]);
        for(int i=1; i < intervals.Length; i++){
            MergeArrays(mergedIntervals.Last(), intervals[i]);
        }
        return mergedIntervals.ToArray();
    }

    private void MergeArrays(int[] arr1, int[] arr2){

        List<int[]> results = new List<int[]>();

        if((arr1[1] >= arr2[0] && arr2[1] >= arr1[1]) || (arr2[1] >= arr1[0] && arr1[1] >= arr2[1])){
            arr1[0] = Math.Min(arr1[0],arr2[0]);
            arr1[1] = Math.Max(arr1[1],arr2[1]);
            mergedIntervals.RemoveAt(mergedIntervals.Count-1);
            mergedIntervals.Add(arr1);
            return;
        }else{
            mergedIntervals.Add(arr2);
        }
    }

}