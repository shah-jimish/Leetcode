/*
here take string  
s = abcabcbb
going through string we are checking if that current char exist in the 
set or not if so means we found our first element which is alreay
in the set means we have to remove it 
before that let's go through the string
a not exists then add it set = [a], maxLen = 1
b not exists set = [a,b], maxLen = 2
c not exists set = [a,b,c] , maxLen = 3
now we are at c that is already exist in the set then we'll
start from the left = 0 and remove that element from the list until
we remove the current element
first remove a then b then c now we are at a again then add
a then b and c and repeat the same process until we reach the end. 
*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new();
        int left = 0;
        int maxLen = 0;
        for(int i=0;i<s.Length;i++){
            while(set.Contains(s[i])){
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[i]);
            maxLen = Math.Max(maxLen,i-left+1);
        }
        return maxLen;
    }
}