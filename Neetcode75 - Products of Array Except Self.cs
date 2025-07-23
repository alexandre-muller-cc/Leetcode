public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        //For the left product
        for(int i=0;i<nums.Length;i++){
            if(i==0){
                left[i] = nums[i];
            }
            else{
                int temp = nums[i];
                left[i] = left[i-1]*temp;
            }
        }
        for(int i=nums.Length-1;i>=0;i--){
            if(i==nums.Length-1){
                right[i]=nums[i];
            }
            else{
                int temp = nums[i];
                right[i] = right[i+1]*temp;
            }
        }

        //Now the final Array
        int[] final = new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            if(i==0){
                final[i] = right[i+1];
            }
            else if(i==nums.Length-1){
                final[i] =left[i-1];
            }
            else{
                final[i] = left[i-1]*right[i+1];
            }
        }
        
        foreach(int element in right){
            Console.WriteLine(element);
        }

        return final;

      //In O(n)
            
        }
    }

