namespace LeetCode.Problems;
using System.Collections.Generic;

public class IntersectionOfTwoArraysII {

    public int[] Intersect(int[] nums1, int[] nums2){

        if(nums1.Length > nums2.Length){
            return Intersect(nums2, nums1);
        }

        Dictionary<int,int> position = new Dictionary<int, int>();
        List<int> intersection = new List<int>();

        for(int i=0; i < nums1.Length; i++){
            if(position.ContainsKey(nums1[i])){
                position[nums1[i]] ++;
            }else{
                position.Add(nums1[i],1);
            }
        }

        for(int i=0; i < nums2.Length; i++){

            if(position.ContainsKey(nums2[i]) && position[nums2[i]] > 0 ){
                intersection.Add(nums2[i]);
                position[nums2[i]] --;
            } 

        }
        

        return intersection.ToArray();

    }
    
}