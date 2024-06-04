/*so here instead of worring about frequency of all the char let's 
break it into small chunk here we are using hashset. 
ex : --> s = "abccccdd"
first time check if the a exists in the hashset if yes then we know that we already have 'a' then we can add +2 to len,
1 for the current and 1 for the previously added 'a' now  here a does not exists so add it to hashset.

s = "abccccdd"
value    set      len
a        []        0    -> [a]
b        [a]       0    -> [a,b]
c        [a,b]     0    -> [a,b,c]
c        [a,b,c]   2    -> [a,b]     -> c exists remove it, add +2   
c        [a,b]     2    -> [a,b,c]
c        [a,b,c]   4    -> [a,b]     -> c exists remove it, add +2
d        [a,b]     4    -> [a,b,d] 
d        [a,b,d]   6    -> [a,b]     -> d exists remote it, add +2


now final hashset constsin [a,b] now we can take one odd which ever we take is fine 
cause we are just showing the number so on the last line we are looking 
if the hashset contains value if yes then add +1 to the len else return the len.

*/
public class Solution {
    public int LongestPalindrome(string s) {
        if(s.Length==1) return 1;
        HashSet<char> set = new();
        int len=0;
        foreach(char ch in s){
            if(set.Contains(ch)){
                len+=2;
                set.Remove(ch);
            }
            else set.Add(ch);
        }
        return set.Count > 0 ? len+1 : len;
    }
}