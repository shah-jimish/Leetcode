/*
question is simple in teams of couting 0 
in string but tough at a same if we take little 
different approach 
here if n = 3
in binary n = 1011 answer = 3
so here we are checking if n > 0 
as base condition and each time what we are doing is 
we are comparing as (n & 1) with least 
significant bit but what is least significant bit 
that is the last bit but how does that even work
see n & 1 where n = 3 works like this 
1011 & 0001 and we are comparing if the last bit is 1 
if yes then we incement the count 
at first time count increase then we are shifting to right
we shift n to right by 1 bit now n become 101
again compare 101 & 001 == 1  -> count = 2
right shift again 10 and comapre 10 & 01 now that comapre is not 1 
then we don't increase the count 
again shift it to right n = 1 and comapre 1 & 1 -> count = 3
again right shift which gives us n = 0 this time our base condition
fails and we just return count which is 3. 
*/
public class Solution {
    public int HammingWeight(int n) {
        //store count
        int count = 0;

        //base condition
        while(n>0){
            //comapre with least significant bit
            if((n & 1) == 1) count++;

            //right shift
            n >>= 1;
        }

        //return ans
        return count;
    }
}