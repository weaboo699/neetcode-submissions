public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> Count = new Dictionary<int,int>();

        for(int c = 0; c < (nums.Length); c++){
            if(Count.ContainsKey(nums[c])){
                Count[nums[c]] += 1; 
            }
            else{
                Count[nums[c]] = 1;
            }
        }
        
        var sorted = Count.OrderByDescending(x => x.Value).ToArray();

        int[] result = new int[k];

        for(int i = 0; i < k; i++){
            result[i] = sorted[i].Key;
        }
        return result;
    }
}
