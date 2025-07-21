public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        //For anagram we can use an array of 26 charactere which represent the alphabet. 

        Dictionary <string,List<string>> dict = new Dictionary<string,List<string>>();

        foreach(string word in strs)
        {
            int[] value = new int[26]; //initialized all of them to 0 at first 
            foreach(char letter in word){
                value[letter - 'a']++; //Each time a letter appear it will increase its value by one
            }

            string element = string.Join(",",value); //Here the , is important because they can supperpose if only ""
            Console.WriteLine(element);

            if(!dict.ContainsKey(element)){
                dict[element] = new List<string>();
            }
            dict[element].Add(word);
            
        }
        return dict.Values.ToList();
        //lesson dict.Value return a collection. 
    }
}
