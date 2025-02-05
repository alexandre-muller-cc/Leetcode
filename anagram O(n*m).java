class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {

        //The goal here is to translate each word in the Array into Array of 26 space where each index 
        //correspond to the value of the letter in the asci notation 

        //Use a hashmap that store Arraylist as value (since we will append them)

        HashMap<String,ArrayList<String>> hash1 = new HashMap<>(); 

        for (String str : strs){
            int[] count  = new int[26]; //26 because 26 Letter in the alphabet 
            for(char c : str.toCharArray() ) //Convert the String into an array of char 
            { 
                //Loop to iterate over each letter in the each words 
                count[c-'a']++;
            }
            //Transform each array of int, into a String that will be used in the Hashmap
            String key = Arrays.toString(count); 
            hash1.putIfAbsent(key,new ArrayList<>()); //Add the key if not in the list
            hash1.get(key).add(str);
        }
        return new ArrayList<>(hash1.values());

        
    }
}
