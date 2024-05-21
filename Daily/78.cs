// READING THIS DP EXPLANATION MIGHT CAUSE BRAIN INJURY. PROCEED WITH CAUTION.

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        //store all the subset
        List<IList<int>> ans = new();
        DFS(nums,0,new List<int>(),ans);
        return ans;
    }
    /* start = start index like from where we want to start the next loop
    but why we are passing that 
    [1,2,3] here first time out start is 0 means the first index that means
    first time it will add 1 to res then DFS call will happen where new start is index+1
    means first index now we'll add 2 to res and the same time we are also adding all the 
    values to res as well 
    so on the first call 1 will be in res , so at that time our res looks something like this .
    first time call we will add res to ans first time res is null 
    ans = [[]]
    then res = [1]
    ans = [[],[1]]
    then res = [1,2]
    ans = [[],[1],[1,2]]
    then res  [1,2,3]
    ans = [[],[1],[1,2],[1,2,3]]
    now it's return call time this time 
    then at back time we will reach where start = 1 at that time 
    there is only single value in the list [1] now we will add 3 to list [1,3]
    then we add that to ans 
    ans = [[],[1],[1,2],[1,2,3],[1,3]]
    now again all the sub condition are finish at then end we are at start = 0
    then we can add 2 to the list at this time entire list is empty [2]
    add this to list 
    ans = [[],[1],[1,2],[1,2,3],[1,3],[2]]
    again DFS call add 3 to list [2,3]
    ans = [[],[1],[1,2],[1,2,3],[1,3],[2],[2,3]]
    again the last call which will add 3 to empty list 
    and again add that to ans
    ans = [[],[1],[1,2],[1,2,3],[1,3],[2],[2,3],[3]]
    */
    
    private void DFS(int[] nums,int start,List<int> res,IList<IList<int>> ans){
        ans.Add(new List<int>(res));
        for(int i=start;i<nums.Length;i++){
            res.Add(nums[i]);
            DFS(nums,i+1,res,ans);
            res.RemoveAt(res.Count-1);
        }
    }
}