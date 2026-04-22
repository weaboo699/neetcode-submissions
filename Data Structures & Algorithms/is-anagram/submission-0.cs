public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sortedS = s.ToCharArray();
        char[] sortedT = t.ToCharArray();

        Array.Sort(sortedS);
        Array.Sort(sortedT);

        string newS = new string(sortedS);
        string newT = new string(sortedT);
        
        return newS == newT;
    }
}
