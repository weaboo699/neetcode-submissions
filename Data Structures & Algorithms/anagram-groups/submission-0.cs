public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> group = new Dictionary<string, List<string>>();
        foreach(var s in strs){
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedS = new string(charArray);
            if(!group.ContainsKey(sortedS)){
                group[sortedS] = new List<string>();
            }
            group[sortedS].Add(s);
        }
        return group.Values.ToList();;
    }
}
