public class Solution {
    public int CharacterReplacement(string s, int k) {

        //I think it's the same method but we give k joker 

        HashSet<char> hash = new HashSet<char>(s); //Hashset of unique letter

        int max = 0;
       

        //Iterate for each letter in the hashset
        //The trick here is that we find the longest substring where K element are not part of the substring. If more than k then we move using the sliding windows
        //Also here once thw sliding windows will never shrink, ever stay the same if max, or increase 

        foreach(char c in hash)
        {
             int l = 0;
             int count = 0;

             for (int r=0; r<s.Length;r++)
                {
                if(s[r]==c){
                    count++;
                }
                while((r-l+1-count)>k) //Here we count how many letter are different the one we are iterating over
                {
                    if(s[l]==c)
                    {
                        count--;
                    }
                    l++;
                }
                Console.WriteLine(r-l);
                max  = Math.Max(max,r-l+1);
             }
             
        }
        return max;


            }
        }
        

