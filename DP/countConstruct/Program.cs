public class Program{
    public static int countConstruct(string target,string[] words,
    Dictionary<string,int> dict){
        if(dict.ContainsKey(target)) return dict[target];
        if(target == "") return 1;

        int totalCount = 0;
        foreach(string word in words){
            if(target.IndexOf(word)==0){
                int numWays = countConstruct(
                    target.Substring(word.Length,target.Length-word.Length),
                    words,dict);
                totalCount+=numWays;
            }
        }
        dict.Add(target,totalCount);
        return dict[target];
    }
    public static int countHelper(string target,string[] words){
        return countConstruct(target,words,new Dictionary<string,int>());
    }
    public static void Main(){
        Console.WriteLine(countHelper("purple",
        ["purp","p","ur","le","purpl"]));
        Console.WriteLine(countHelper("abcdef",["ab","abc","cd","def","abcd"]));
        Console.WriteLine(countHelper("skateboard",["bo","rd","ate","t","ska","sk","boar"]));
        Console.WriteLine(countHelper("enterapotentpot",["a","p","ent","enter","ot","o","t"]));
        Console.WriteLine(countHelper("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
        ["e","ee","eee","eeee","eeeee"]));
    }
}