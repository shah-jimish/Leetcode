/*
there are muliple ways to solve the problem
first one is that we just do the double for loop and 
swap the values
*/
public class Solution {
    public void SortColors(int[] nums) {
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[j]<nums[i]) {
                    (nums[j],nums[i]) = (nums[i],nums[j]);
                }
            }
        }
    }
}


/*
this in solution first we are just counting the occurence of 0,1 and 2
cuase we know that there are only 3 possbile values 
and based count list we can just overright the existing nums.
*/

public class Solution {
    public void SortColors(int[] nums) {
    int[] count = new int[3];
        foreach(int num in nums){
            count[num]++;
        }
        int idx = 0;
        for(int val=0;val<count.Length;val++){
            int p = count[val];
            while(p>0){
                nums[idx] = val;
                idx++;
                p--;
            }
        }
    }
}



/*
this solution is little different than other 
here we are just focusing on the 0 and 2 cause we know 
that there are only 3 posible values and we are sorting 
0 and 2 if we find 0 so the 1 will automatically get sorted.

the main logic is if we find any one 1 then we have put that one front side side of array
and if we find 2 then put on back side of array.

for front and back we are maintaining one variable l and r 
if we find 0 then swap that with nums[l] position and then l++ time we find 0.
same for 2 for that put that 2 in nums[r] and r-- for next time we find 2.
and for that 1 we are not checking any thing for that we have  go through example 
ex : nums = [2,0,2,1,1,0];

l , r , i , nums
0   5   0   [2,0,2,1,1,0]  // first time chcking nums[i]==2 then we will swap it swapped it with last element
0   4   1   [0,0,2,1,1,2]  // nums[i] = 0 then swap it with nums[l]
1   4   2   [0,0,2,1,1,2]  // nums[2] = 2 swap with right side.
1   3   3   [0,0,1,1,2,2]  // as we can see it alredy sorted then for nums[3] = 1 then skip     

*/
public class Solution {
    public void SortColors(int[] nums) {
        int l = 0;
        int r = nums.Length
         - 1;
        int i=0;
        while(i<=r){
            if(nums[i]==0){
                (nums[l],nums[i]) = (nums[i],nums[l]);
                l++;
            }
            else if(nums[i]==2){
                (nums[r],nums[i]) = (nums[i],nums[r]);
                r--;
                i--;
            }
            i++;
        } 
    }

}