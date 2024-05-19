public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string> set = new();

        //we are taking first set of all the places from where we can 
        //travel to some place which are path[0]
        foreach(List<string> path in paths){
            set.Add(path[0]);
        }
        //here we are checking in the destination path[1] that if this 
        //exists in the set if so means that is not our answer so we move
        //and check for other we find the place which does exists in the set
        //and then return it as our answer.
        foreach(List<string> path in paths){
            if(!set.Contains(path[1])) return path[1];
        }
        return default;
    }
}