namespace LeetCode.Problems;
using System.Collections.Generic;

public class CourseSchedule2{

    Stack<int> courses = new Stack<int>();
    List<int> visited = new List<int>();
    Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        
        for(int i=0; i< prerequisites.Length; i++){
            int course = prerequisites[i][1];
            int pre = prerequisites[i][0];

            if(adjList.ContainsKey(course)){
                adjList[course].Add(pre);
            }else{
                adjList.Add(course, new List<int>(){pre});
            }
        }

        Stack<int> courses = new Stack<int>();

        for(int i=0; i < numCourses; i++){
            if(!visited.Contains(i))
                dfs(i);
        }

        return courses.ToArray();
    }

    private void dfs(int startingCourse){

        if(visited.Contains(startingCourse)){
            return;
        }else{
            visited.Add(startingCourse);
        }

        if(adjList.ContainsKey(startingCourse)){
            foreach(int course in adjList[startingCourse]){
                if(!visited.Contains(course))
                    dfs(course);
            }
        }
        
        courses.Push(startingCourse);
    }

}