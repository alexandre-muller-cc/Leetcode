public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        List<int> list  = new List<int>();

        int k = numbers.Length-1;
        int i = 0;
       while(numbers[i]+numbers[k]!=target)
       {
            if(numbers[i]+numbers[k]>target){
                k--;
            }
            else if(numbers[i]+numbers[k]<target){
                i++;
            }
        }
        return new int[]{i+1, k+1};        
    }
}
