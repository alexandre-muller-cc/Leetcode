public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        //Create an array of list
        List<int>[] array = new List<int>[nums.Length+1];
        for (int i=0;i<array.Length;i++){
            array[i]= new List<int>(); //Initialize the list here. 
        }

        //Now create the dictionanry based on the frequence 

        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int number in nums){
            if(!dict.ContainsKey(number)){
                dict[number]=1;
            }
            else{
                dict[number]++;
            }
        }

        //Now we place these element in the array 
        foreach(var line in dict){
            array[line.Value].Add(line.Key);
        }
        //Now that everything is placed in the array we can retrieved the elements. 
        int index=0;
        int[] result = new int[k];
        for(int i=array.Length-1;i>0 && index<k;i--){
            foreach(int element in array[i]){
                result[index]=element;
                index++;
                if(index>=k){
                    return result;
                }
            }


        }
        return result;   
    }
}

//Bucket Sort, use array of list to retrive by index

