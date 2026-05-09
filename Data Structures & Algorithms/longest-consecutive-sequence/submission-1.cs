public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0){
            return 0;
        }
        Array.Sort(nums);
        int count = 1;
        int max = 0;
        for(int i =1; i < (nums.Length); i++){
            Console.Write(nums[i]+" ");
            if(nums[i]-1 == nums[i-1]){
                count++;
            }
            else if(nums[i] != nums[i-1]){
                if(max < count)
                    max = count;
                count = 1;
            }   
        }
        if(count > max){
            return count;
        }
        return max;
    }
}
