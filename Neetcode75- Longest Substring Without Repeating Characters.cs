public class Solution {
    public int LengthOfLongestSubstring(string s) {


        HashSet<char> hash = new HashSet<char>();

        int indexLeft = 0;
        int max = 0;


        for(int i=0;i<s.Length;i++)
        {
            while(hash.Contains(s[i])){
                hash.Remove(s[indexLeft]);
                indexLeft++;
            }
            hash.Add(s[i]);
            max = Math.Max(max,i-indexLeft+1);
        }
            return max;
        }
    }

//The while loop is progressively reduicing the length of the substring.
