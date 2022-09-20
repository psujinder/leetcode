namespace LeetCode.Problems;

public class CourseSchedule{

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        
        if (prerequisites.Length == 0)
        return true;

        Dictionary<int,List<int>> courseMap = new Dictionary<int, List<int>>();
        List<int> visitedCourses = new List<int>();

        //construct the graph of the rouces
        
        for(int i = 0; i< prerequisites.Length; i++){
            if(courseMap.ContainsKey(prerequisites[i][0])){
                courseMap[prerequisites[i][0]].AddRange(prerequisites[i].Skip(1).Take(prerequisites[i].Length-1));
            }else{
            courseMap.Add(prerequisites[i][0], prerequisites[i].Skip(1).Take(prerequisites[i].Length-1).ToList());
            }
        }

        bool[] path = new bool[numCourses];
        for(int i=0; i < numCourses; i++){
            if(IsCourseCyclic(i, courseMap, path)){
                return false;
            }
        }

        return true;

    }

    private bool IsCourseCyclic(int course, Dictionary<int,List<int>> courseMap, bool[] path){

        bool ret = false;

        if(path[course])
            return true;

        if(!courseMap.ContainsKey(course)){
            return false;
        }
        
        path[course] = true;

        foreach(var newCourse in courseMap[course]){
            ret = IsCourseCyclic(newCourse, courseMap, path);
            if (ret)
                break;
        }

        path[course] = false;

       return ret;
    }

}