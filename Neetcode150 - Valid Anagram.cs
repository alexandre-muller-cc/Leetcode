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


//Better 
public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }
        
        Dictionary<char,int> dict1 =  new Dictionary<char,int>();
        Dictionary<char,int> dict2 =  new Dictionary<char,int>();

        for(int i = 0;i<s.Length;i++){
            dict1[s[i]] = dict1.GetValueOrDefault(s[i],0)+1;
            dict2[t[i]] = dict2.GetValueOrDefault(t[i],0)+1;
        }
        return (dict1.Count==dict2.Count && !dict1.Except(dict2).Any());  
    }
}

//Lesson: Method Except return a Itrable, using Any make it a boolean. 
// Use the GetValueOrDefault that will get the value of the given key, or make it 0 if there is none. 
