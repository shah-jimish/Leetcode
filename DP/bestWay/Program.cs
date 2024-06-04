public class Program{
    public static Dictionary<int,List<int>> dict  = new();
    public static List<int>? bestSum(int target,int[] nums){
        if(dict.ContainsKey(target)) return dict[target];
        if(target == 0) return [];
        if(target < 0 ) return null;

        List<int> shortCob = null;
        
        foreach(int num in nums){
            int rem = target - num;
            var remCom = bestSum(rem,nums);
            if(remCom != null){
                var comb = new List<int>(remCom);
                comb.Add(num);
            
                if(shortCob == null || comb.Count < shortCob.Count){
                    shortCob = comb;
                }
            }
        }
        dict.Add(target,shortCob);
        return dict[target];
    }
    public static void Main(){
        Console.WriteLine(string.Join(",",bestSum(7,[5,3,4,7])));
        Console.WriteLine(string.Join(",",bestSum(8,[2,3,5])));
        Console.WriteLine(string.Join(",",bestSum(8,[1,4,5])));
        Console.WriteLine(string.Join(",",bestSum(100,[1,2,5,25])));
    }
}