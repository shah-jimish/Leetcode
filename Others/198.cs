/*here the main problem is we can no rob the 
house which are right next to each other 
[1,2,3,1] here can rob
-> 1 , 3
-> 2 , 1
obviously first one is our answer 
let's look at the other example 

[2,7,9,3,1]
-> 2 , 9 , 1
-> 7 , 3
got the point so what here we can do is 
we can skip the first 2 house and start at index - 2
then each time we are adding index - 2 to the current index which can
not give use some thing like this.
Index = 2 -> [2,7,11,3,1]
Index = 3 -> [2,7,11,10,1]
Index = 4 -> [2,7,11,10,12]
now know that last 2 value contains  then answer 
so from that we just have to take the max and that is our answer.
*/
public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length==1) return nums[0];
        int l = nums.Length;
        for(int i=2;i<l;i++){
            nums[i]+=nums[i-2];
        }
        return Math.Max(nums[l-1],nums[l-2]);
    }
}