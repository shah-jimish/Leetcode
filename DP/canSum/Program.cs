/*
canSum(7,[5,3,4,7]) -> true
we can re use elements.
*/

using System.Collections.Generic;

public class Program{
    public static bool CanSum(int target,int[] nums){
        if(target == 0) return true;
        if(target < 0) return false;

        for(int i=0;i<nums.Length;i++){
            if(CanSum(target-nums[i],nums)){
                return true;
            }
        }
        return false;
    }
    public static List<int> HowSumHelper(int target,int[] nums){
        return HowSum(target,nums,new Dictionary<int,List<int>>());
    }
    public static List<int> HowSum(int target,int[] nums,Dictionary<int,List<int>> dict){
        if(dict.ContainsKey(target)) return dict[target];
        if(target == 0) return new List<int>();
        if(target < 0) return null;
        foreach(int num in nums){
            int rem = target - num;
            var remRes = HowSum(rem,nums,dict);
            if(remRes != null){
                dict.Add(target, new List<int>(remRes) { num });
                return dict[target];
            }
        }
        dict[target] = null;
        return null;
    }
    private static string FormatResult(List<int> result) {
        return result == null ? "null" : string.Join(" ", result);
    }
    public static void Main(){
        /*
        Console.WriteLine(CanSum(7,[2,3]));
        Console.WriteLine(CanSum(7,[5,3,4,7]));
        Console.WriteLine(CanSum(7,[2,4]));
        Console.WriteLine(CanSum(8,[2,3,5]));
        Console.WriteLine(CanSum(300,[7,14]));
        */

        Console.WriteLine(FormatResult(HowSumHelper(7, new int[] { 2, 3 })));
        Console.WriteLine(FormatResult(HowSumHelper(7, new int[] { 5, 3, 4, 7 })));
        Console.WriteLine(FormatResult(HowSumHelper(7, new int[] { 2, 4 })));
        Console.WriteLine(FormatResult(HowSumHelper(8, new int[] { 2, 3, 5 })));
        Console.WriteLine(FormatResult(HowSumHelper(300, new int[] { 7, 14 })));
    }
}