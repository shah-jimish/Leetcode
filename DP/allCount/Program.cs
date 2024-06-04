public class Program{
    public static List<List<string>> allContruct(string target,string[] words){
        if(target == "") return [[]];
        List<string> res = [];
        foreach(string word in words){
            if(target.IndexOf(word)==0){
                string suffix = target.Substring(word.Length,target.Length-word.Length);
                var suffixWays = allContruct(suffix,words);
                var targetWays = suffixWays.
            }
        }

    }
    public static void Main(){
        Console.WriteLine(allContruct("purple",["purp","p","ur","le","purpl"]));
        Console.WriteLine(allContruct("abcdef",["ab","abc","cd","def","abcd"]));
        Console.WriteLine(allContruct("skateboard",["bo","rd","ate","t","ska","sk","boar"]));
        Console.WriteLine(allContruct("enterapotentpot",["a","p","ent","enter","ot","o","t"]));
        Console.WriteLine(allContruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
        ["e","ee","eee","eeee","eeeee"]));
    }
}