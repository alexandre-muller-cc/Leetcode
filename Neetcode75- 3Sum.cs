public class Solution 
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<List<int>> result  =  new List<List<int>>();

        for(int i=0;i<nums.Length-2;i++){
            
            int l=i+1;
            int k = nums.Length-1;
            if(nums[i]>0){break;}
            else if(i>0 && nums[i]==nums[i-1]){continue;}

            while(l<k)
            {
                
                 //Means go to the next iteration 
                if(nums[i]+nums[l]+nums[k]>0){
                    k--;
                }
                else if(nums[i]+nums[l]+nums[k]<0){
                    l++;
                }
                else
                {
                     //When it is equal to zero
                    result.Add(new List<int>{nums[i],nums[l],nums[k]});
                    l++;
                    k--;
                    while(l<k && nums[l]==nums[l-1])
                    {
                        l++;
                    }
                }
            }
        }
        return result;
    }
}

//Lesson: Continu keyword inside while and forloop, jsut not gonna do the rest of the loop and will goes to the next iteration
