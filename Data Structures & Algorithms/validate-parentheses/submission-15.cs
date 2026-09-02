public class Solution {
    public bool IsValid(string s) {
        Stack<char> par = new();

        foreach(char c in s) {
            if(c == '{') par.Push('}');
            else if(c == '[') par.Push(']');
            else if(c == '(') par.Push(')');
            else if(par.Count == 0 || par.Pop() != c){
                return false;
            }
        }

        return par.Count == 0;
    }
}
