class Solution {
    public int[] twoSum(int[] nums, int target) {

        ///Sort the the Arrays directly with the Arrays utilities.

        // Arrays.sort(nums); //Sort the Array in the ascending order.
        // //A double for loop is possible here. 

        // //Return an array of two index 
        // int[] index = new int[2];

        // for(int i=0;i<nums.length;i++)
        // {
        //     for(int j =i+1;j<nums.length;j++)
        //     {
        //         if(nums[i]+nums[j]==target)
        //         {
        //             index[0] = i;
        //             index[1]= j;
        //             break;
                    
        //         } 
               
        //     }          
        // }
        // return index;
        //Do it with o(n)
        HashMap <Integer,Integer> hash1 = new HashMap<>();
        int[] index = new int[2];

        //Populate the Hashmap

        for(int i=0;i<nums.length;i++){
            int complement = target - nums[i];

            hash1.put(complement,i);

        }

        for( int j=0;j<nums.length;j++){
            if(hash1.containsKey(nums[j]) && j!=hash1.get(nums[j])){
                index[0]= j;
                index[1] = hash1.get(nums[j]);
                break;

            }
        }

        System.out.println(hash1.keySet());
        return index;


    }
}


