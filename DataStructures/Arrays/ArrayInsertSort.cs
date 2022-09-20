namespace LeetCode.Problems;

public class ArrayInsertSort{
    
    int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };

    public void Sort(){

        
        Console.WriteLine("--Before  Sort--");
        for(int i=0;i< arr.Length; i++){
            Console.Write(arr[i].ToString()+ " ");
        }

        for(int i=1; i< arr.Length; i++){
            var tmp = arr[i];
            for(int j=i-1; j>=0;){
                if(tmp < arr[j]){
                    arr[j+1] = arr[j];
                    j--;
                    arr[j+1] = tmp; 
                }else{
                    break;
                }
            }
        }
        Console.WriteLine("--After  Sort--");
        for(int i=0;i< arr.Length; i++){
            Console.Write(arr[i].ToString()+ " ");
        }
    }

}