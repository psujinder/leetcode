namespace LeetCode.Problems;

public class ArraySelectionSort{

    int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };

    public void Sort(){

        Console.WriteLine("--Before  Sort--");
        for(int i=0;i< arr.Length; i++){
            Console.Write(arr[i].ToString()+ " ");
        }
        int min =0;
        for(int i=0; i< arr.Length-1; i++){
            min = i;
            for(int j=i+1; j< arr.Length; j++){
                if(arr[j] < arr[min]){
                    min =j;
                }
            }
            var tmp = arr[i];
            arr[i] = arr[min];
            arr[min] = tmp;
        }
        Console.WriteLine("--After  Sort--");
        for(int i=0;i< arr.Length; i++){
            Console.Write(arr[i].ToString()+ " ");
        }
    }
}