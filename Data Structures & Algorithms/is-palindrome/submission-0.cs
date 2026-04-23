public class Solution {
    public bool IsPalindrome(string s) {
        char[] c = s.ToCharArray();
        string newC = "";
        for(int i = 0; i < (s.Length); i++){
            if(char.IsLetterOrDigit(c[i])){
                newC += char.ToLower(c[i]);
            }
        }
        return newC == new string(newC.Reverse().ToArray());
    }
}
