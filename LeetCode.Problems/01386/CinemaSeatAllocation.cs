namespace LeetCode.Problems;

public class CinemaSeatAllocation{

    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        
        int result = 0;
        int rowCount = 0;

        //convert to List
        Dictionary<int, List<int>> bookedSeats = new Dictionary<int, List<int>>();

        for(int i=0; i<reservedSeats.Length;i++){
            var seat = reservedSeats[i];

            int row = seat[0];
            int col = seat[1];

            if(bookedSeats.ContainsKey(row)){
                bookedSeats[row].Add(col);
            }else{
                bookedSeats.Add(row, new List<int>{col});
            }
        }

        result = (n - bookedSeats.Count)*2;

        foreach(int key in bookedSeats.Keys){
            rowCount = 0;

            if(!bookedSeats[key].Contains(2) && !bookedSeats[key].Contains(3)
                && !bookedSeats[key].Contains(4) && !bookedSeats[key].Contains(5)){
                    rowCount++;
                }

            if(!bookedSeats[key].Contains(6) && !bookedSeats[key].Contains(7)
                && !bookedSeats[key].Contains(8) && !bookedSeats[key].Contains(9)){
                    rowCount++;
                }

            if(rowCount == 0 && !bookedSeats[key].Contains(4) && !bookedSeats[key].Contains(5)
                && !bookedSeats[key].Contains(6) && !bookedSeats[key].Contains(7)){
                    rowCount++;
                }     
            

            result += rowCount;
        }

        return result;
    }

}