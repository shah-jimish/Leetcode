public class Solution {
    //to add all the subset need to make it public 
    //so we can access it in the Subset function.
    public List<List<int>> subSets  = new();
    public int SubsetXORSum(int[] nums) {
        Subset(nums,0,[]);        
        int sum = 0;
        //loop through each subset and store that 
        //to local s then add it to sum variable.
        foreach(var r in subSets){
            int s = 0;
            for(int i=0;i<r.Count;i++){
                s ^= r[i];
            }
            sum+=s;
        }
        return sum;
    }
    //using backtracking to get the list 
    // of all the subsets
    private void Subset(int[] nums,int start,List<int> lst){
        subSets.Add(new List<int>(lst));
        for(int i=start;i<nums.Length;i++){
            lst.Add(nums[i]);
            Subset(nums,i+1,lst);
            lst.RemoveAt(lst.Count-1);
        }
    }
}