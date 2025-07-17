public class Solution {
    public bool IsAnagram(string s, string t) {

        char[] Array1 = s.ToArray();
        char[] Array2 = t.ToArray();
        Array.Sort(Array1);
        Array.Sort(Array2);
        if (Array1.SequenceEqual(Array2)){
            return true;
        }
        else{
            return false;
        }
    }
}

//Lesson: Sort() return void type. 
