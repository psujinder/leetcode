namespace LeetCode.Problems;

public class CourseSchedule{

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        
        if (prerequisites.Length == 0)
        return true;

        Dictionary<int,List<int>> courseMap = new Dictionary<int, List<int>>();
        List<int> visitedCourses = new List<int>();

        //construct the graph of the courses
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
                return false;
            }
        }

        return true;

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

}