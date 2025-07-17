public class Solution {
    public bool hasDuplicate(int[] nums) {

        HashSet<int> hash1 = new HashSet<int>();

        foreach (int element in nums){
            if(!hash1.Contains(element))
            {
                hash1.Add(element);
            }
        }
        if(nums.Length>hash1.Count())
        {
            return true;
        }
        else{
            return false;
        }

        
    }
}

//Lesson: Can pass an array as parameter of a Hashset
