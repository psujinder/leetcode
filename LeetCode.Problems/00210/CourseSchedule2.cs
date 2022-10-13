namespace LeetCode.Problems;
using System.Collections.Generic;

public class CourseSchedule2{

    Stack<int> courses = new Stack<int>();
    List<int> visited = new List<int>();
    Dictionary<int, List<int>> courseMap = new Dictionary<int, List<int>>();

    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        
        for(int i=0; i< numCourses; i++){
            courseMap.Add(i, new List<int>());
        }

        for(int i=0; i< prerequisites.Length; i++){
            courseMap[prerequisites[i][1]].Add(prerequisites[i][0]);
        }

        bool[] path;
        bool[] visited = new bool[numCourses];

        for(int i=0; i < numCourses; i++){
            path = new bool[numCourses];
            if(IsCourseCyclic(i, courseMap, path, visited)){
                return new int[]{};
            }
        }

        Array.Fill(visited, false);

        for(int i=0; i < numCourses; i++){
            if(!visited[i])
                topoSort(i);
        }

        return courses.ToArray();
    }


    private bool IsCourseCyclic(int course, Dictionary<int,List<int>> courseMap, bool[] path, bool[] visited){

        if(visited[course])
            return false;

        if(path[course])
            return true;

        if(courseMap[course].Count ==0){
            visited[course] = true;
            return false;
        }

        path[course] = true;
       
        bool ret = false;
        foreach(int nextcourse in courseMap[course]){
            ret = IsCourseCyclic(nextcourse, courseMap, path, visited);
            if(ret){
                break;
            }
        }

        visited[course] = true;
        return ret;
    }

    private void topoSort(int startingCourse){

        if(visited.Contains(startingCourse)){
            return;
        }else{
            visited.Add(startingCourse);
        }

        if(courseMap.ContainsKey(startingCourse)){
            foreach(int course in courseMap[startingCourse]){
                if(!visited.Contains(course))
                    topoSort(course);
            }
        }
        
        courses.Push(startingCourse);
    }



}