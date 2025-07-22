public class Solution {

    public string Encode(IList<string> strs) {

        //Create a list that will have the length of each word 
        List<string> encodedList = new List<string>();
        string sentence = "";
        foreach(string word in strs){
            byte[] binaryData = System.Text.Encoding.UTF8.GetBytes(word);
            string base64EncodedData = Convert.ToBase64String(binaryData);
            sentence = sentence + base64EncodedData + "#";
        }

        Console.WriteLine(sentence);

        return sentence;

        
    }

    public List<string> Decode(string s) {

        List<string> list1 = new List<string>(s.Split("#"));
        List<string> result = new List<string>();
        foreach(string element in list1){
            byte[] binaryData =Convert.FromBase64String(element);
            string DecodedString = System.Text.Encoding.UTF8.GetString(binaryData);
            result.Add(DecodedString);
        }
        result.RemoveAt(result.Count-1);
        return result;

   }
}
