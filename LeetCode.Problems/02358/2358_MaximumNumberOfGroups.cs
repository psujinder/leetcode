namespace LeetCode.Problems;

/*
    The actual grades of the students dont matter if the grades array is rearranged in ascending order. 
    Follow a greedy algoright to satisfy the condition that the number of students in the ith group should be less than the number of students in the i+1th group. 
    For an array of 6 students: this will lead to the following:
    1st group has 1 student
    2nd grou has 2 students
    3rd group has 3 students
    Total Number of students = 1+2+3  = 6

    Taking another example of 7 students
    1st group has 1 student
    2nd group has 2 students
    3rd group has 3 students
    4th group has 1 students

    Total Number of studends = 1+2+3+1 = 7
    However the 4th group should have more students than the 3rd group. To satisfy this combine the 4th and 3rd grop. 
    1st group has 1 student
    2nd group has 2 students
    3rd group has 4 students

    Hence the solution is to find the number N where the sum of all natural numbers is less than or equal to the number of students (S)
    N(N+1)/2 <=S
    
*/

public class MaximumNumberOfGroups {


    //This solution has a time compleity of O(N). Need to work on a solution that yields a time complexity of O(log n).
    public int MaximumGroups(int[] grades){

        int i = 0;
        int studentsNum = grades.Length;

        for(i = 0; i <= studentsNum; i++){
            if((i*(i+1))/2 > studentsNum){                
                break;
            }
        }

        return i - 1;

    }


/*     public int MaximumGroups2(int[] grades){

      int left = 0;
      int right = grades.Length;
      int mid = 0;

      if (grades.Length == 1 || grades.Length == 2){
        return 1;
      }

      while(left<right){
         mid = (left + right)/2;

         if ((mid *(mid+1))/2 > grades.Length){
            right = mid;
         }else{
            left = mid;         
         }
      }

      if((((mid+1)*(mid+1+1))/2) <= grades.Length){
        return mid+1;
      }else
      {
        return mid;
      }

    }*/

}