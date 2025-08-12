public class Solution {
    public int FindMin(int[] nums) {

        //Define the boudary of the array, use index only here 

        int left = 0;
        int right = nums.Length-1;
        int middle  = (right+left)/2;

        while(left<right)
        {
            if(nums[right]<nums[middle]){
                left = middle+1;
                middle = (left+right)/2;
                Console.WriteLine("The value of Left is now at index " + left + " and value " + nums[left]);
            }
            else if(nums[right]>nums[middle]){
                right=middle;
                middle = (left+right)/2;
                Console.WriteLine("The value of rigth is now at index " + right + " and value " + nums[right]);
            }
            }
        return nums[middle];
    }
}

