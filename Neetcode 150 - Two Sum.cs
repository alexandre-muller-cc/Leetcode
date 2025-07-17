public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> list1 =  new List<int>();
        Dictionary<int,int> dict1 = new Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++){
            dict1[nums[i]] = i;
        }
        for(int j=0;j<nums.Length;j++)
        {
            int diff = target-nums[j];
            Console.WriteLine(diff);
            if(dict1.ContainsKey(diff) && j!=dict1[diff] )
            {
                list1.Add(j);
                list1.Add(dict1[diff]);
                break;
            }
        }
        return list1.ToArray();
    }
}
