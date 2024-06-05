/*
    first we know that we want to take only common chars
    so by taking the first word we are creating dict which contains 
    frequency of all the chars
    now in the for loop starting with seconed word we are creating dict of that 
    word and then for each key in dict we are checking that the same key
    exists in the new created dict if so means that both the chars exists in the
    dict so we can take if the key does not exists then we simply remove it from the 
    first dict , again if key exists then we have to take which ever the min value 
    suppose 
    dict['o',2] means dict contains 2 o's 
    but in the forloop dict --> d['o',1] means only contains 1 o,
    then we can not take the 2 o's cause the second dict only contains 1 o. we have to find the char
    which consist in all the words.
*/
public class Solution {
    public IList<string> CommonChars(string[] words) {
        Dictionary<char,int> dict = new();
        foreach(var ch in words[0]){
            if(dict.ContainsKey(ch)){
                dict[ch]++;
            }
            else{
                dict.Add(ch,1);
            }
        }
        for(int i=1;i<words.Length;i++){
            Dictionary<char,int> d = new();
              foreach(var ch in words[i]){
                if(d.ContainsKey(ch)){
                    d[ch]++;
                }
                else{
                    d.Add(ch,1);
                }
            }
            foreach(KeyValuePair<char,int> di in dict){
                if(!d.ContainsKey(di.Key)) dict.Remove(di.Key);
                else if(dict[di.Key] > d[di.Key]){
                    dict[di.Key] = d[di.Key];
                }
            }
        }
        List<string> ans = new();
        foreach(KeyValuePair<char,int> d in dict){
            int k = d.Value;
            while(k>0){
                ans.Add(d.Key.ToString());
                k--;
            }
        }
        return ans;
    }
}