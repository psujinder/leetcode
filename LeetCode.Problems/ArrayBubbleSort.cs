namespace LeetCode.Problems;

public class ArrayBubbleSort{

    int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };

    public void Sort(){

        Console.WriteLine("--Before Insert Sort--");
        for(int i=0;i< arr.Length; i++){
            Console.Write(arr[i].ToString()+ " ");
        }

        bool itemMoved = false;

        do{
            itemMoved = false;
            for(int i=0; i< arr.Length-1;i++){
                if(arr[i] > arr[i+1]){
                    var tmp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = tmp;
                    itemMoved = true;
                }
            }
        }while (itemMoved);

        
        Console.WriteLine("--After Insert Sort--");
        for(int i=0;i< arr.Length; i++){
            Console.Write(arr[i].ToString()+ " ");
        }

    }

}