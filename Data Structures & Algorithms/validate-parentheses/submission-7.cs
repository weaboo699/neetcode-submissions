public class Solution {
    public bool IsValid(string s) {
        Stack<char> right = new Stack<char>();
        int pushtimes = 0;
        int size = s.Length;
        foreach(char n in s){
            if(n == '[' ||n == '(' ||n == '{'){
                right.Push(n);
                pushtimes++;
            }
            else if(right.Count() == 0)
                return false;
            else if(n == ']'){
                if(right.Peek() != '['){
                    return false;
                }
                else
                    right.Pop();
                
            }
            else if(n == ')'){
                if(right.Peek() != '('){
                    return false;
                }
                else
                    right.Pop();
            }
            else if(n == '}'){
                if(right.Peek() != '{'){
                    return false;
                }
                else
                    right.Pop();
            }
            else
                return false;
        }
        if(pushtimes != size/2)
            return false;
        return true;
    }
}
