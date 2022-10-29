namespace LeetCode.Problems;

public class MeetingRooms2{

    public int MinMeetingRooms(int[][] intervals) {
        
        //int rooms = 0;
        Dictionary<int, List<int[][]>> rooms = new Dictionary<int, List<int[][]>>();

        //sort the intervals
        Array.Sort(intervals, (a,b) => {
            var comp = a[0].CompareTo(b[0]);
            if(comp == 0){
                comp = a[1].CompareTo(b[1]);
            }
            return comp;
         });
        
        int i=1;

        int[][] mtg1 = {
         new int[]{intervals[0][0], intervals[0][1]}
        };

        rooms.Add(i, new List<int[][]>(){mtg1});

        for(int j=1; j< intervals.Length; j++){

            int start = intervals[j][0];
            int end = intervals[j][1];
            int[][] mtg = {
                    new int[]{intervals[j][0], intervals[j][1]}
                };

            bool allocated = false;

            foreach(int key in rooms.Keys){
                int[][] lastmtg = rooms[key].Last();
                if(mtg[0][0] >= lastmtg[0][1]){
                    rooms[key].Add(mtg);
                    allocated = true;
                    break;
                }
            }

            if(!allocated){
                i++;
                rooms.Add(i,new List<int[][]>(){mtg});
            }
        }
        return rooms.Count;
    } 

}