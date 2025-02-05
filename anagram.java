class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {

        //Hashmap can have String an list has value. 

        HashMap <String, List<String>> hash1 = new HashMap<>();

        for(String s: strs)
        {

            char[] chartoArray =  s.toCharArray();
            Arrays.sort(chartoArray); //Sort the char array
            String sortedWord = new String(chartoArray); //Change the char array into a String

            hash1.putIfAbsent(sortedWord, new ArrayList<>()); //If the sorted word is not in the Hashmap, then it store an ArrayList in the value 
            //No need to provide the type of the ArrayList since it is already defined in the Hashmap declaration 
            hash1.get(sortedWord).add(s); //Add the word from the initial array into the hashmap value ArrayList. 

            //Anagram will have the same Key, ensuring that they will be added to the samelist. 
        }

        return new ArrayList<>(hash1.values());





        //


        
    }
}
