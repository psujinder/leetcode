namespace LeetCode.Problems;

public class TaskScheduler {

     public int LeastInterval(char[] tasks, int n) {
        
        if (n == 0){
            return tasks.Length;
        }

        //create the frequency table 
        Dictionary<char, int> taskMap = new Dictionary<char, int>();

        for(int i =0; i< tasks.Length; i++){
            if(taskMap.ContainsKey(tasks[i])){
                taskMap[tasks[i]]++;
            }else{
                taskMap.Add(tasks[i],1);
            }
        }

        taskMap.OrderByDescending(k => k.Key);  

        return 0;
        
    }

}