public class Solution {
    public bool IsValid(string s) {

        string inElement  = "[{(";
        HashSet<char> hash = new HashSet<char>(inElement);
        Stack<char> myStack = new Stack<char>();
        int test=0;
        foreach(char letter in s)
        {
            if(hash.Contains(letter)){
                myStack.Push(letter);
            }
            else if(letter==']' &&(myStack.Count>0)&& myStack.Peek()=='['){
                myStack.Pop();
            }
            else if(letter=='}' && (myStack.Count>0) && myStack.Peek()=='{'){
                myStack.Pop();
            }
            else if(letter==')' && (myStack.Count>0) && myStack.Peek()=='('){
                myStack.Pop();
            }
            else{
                test++;
            }  
        }
        if (myStack.Count ==0 && test == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
