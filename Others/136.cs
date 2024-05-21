/*
for this there are actully multiple solution available 
it is easy problem so we can use dictionary or hashset to check
the occurrence but we are not suppose to use other variable so
those are out of question so in that case we have to use bit wise operator
specially XOR but why XOR 
let me explain you see XOR or same value gives us 0
1^1 = 0
1^1^2 = 2;
you can see the pattern here that we know that there is only 
one value which is dublicate from that we can xor and return that
value without using any extra variable. 
*/
public class Solution {
    public int SingleNumber(int[] nums) {
        for(int i=1;i<nums.Length;i++){
            nums[0] ^= nums[i];
        }
        return nums[0];
    }
}