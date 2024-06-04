public class Program{
    public static bool canConstruct(string target,string[] words,
    Dictionary<string,bool> dict){
        if(dict.ContainsKey(target)) return dict[target];
        if(target == "") return true;
        foreach(string word in words){
            if(target.IndexOf(word) == 0){
                string suffix = target.Substring(word.Length,target.Length-word.Length);
                if(canConstruct(suffix,words,dict)){
                    dict.Add(target,true);
                    return true;
                }
            }
        }
        dict.Add(target,false);
        return dict[target];
    }
    public static bool helpConstruct(string target,string[] words){
        return canConstruct(target,words,new Dictionary<string,bool>());
    }
    public static void Main(){
        Console.WriteLine(helpConstruct("abcdef",["ab","abc","cd","def","abcd"]));
        Console.WriteLine(helpConstruct("skateboard",["bo","rd","ate","t","ska","sk","boar"]));
        Console.WriteLine(helpConstruct("enterapotentpot",["a","p","ent","enter","ot","o","t"]));
        Console.WriteLine(helpConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
        ["e","ee","eee","eeee","eeeee"]));
    }
}