public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> countS = new Dictionary<char, int>();
        Dictionary<char, int> countT = new Dictionary<char, int>();
        
        char[] charS = s.ToCharArray();
        char[] charT = t.ToCharArray();

        if((charS.Length) != (charT.Length))
            return false;

        for(int i = 0; i < (charS.Length); i++){
            if(!countS.ContainsKey(charS[i]))
                countS[charS[i]] = 1;
            else 
                countS[charS[i]] += 1; 
        }
        for(int i = 0; i < (charT.Length); i++){
            if(!countT.ContainsKey(charT[i]))
                countT[charT[i]] = 1;
            else 
                countT[charT[i]] += 1;  
        }

        foreach(var pair in countS){
            if(!countT.ContainsKey(pair.Key))
                return false;
            else if(countS[pair.Key] != countT[pair.Key]){
                return false;
            }
        }
        return true;
    }
}
