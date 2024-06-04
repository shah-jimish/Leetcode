/*
Grid traveler in a 2D grid. You begin in the top-left corner
and your gola is to travel to the bottom-left corner.
You may only move down or right.
Find ways to travel to on m*n grid.
GridTraveler(2,3)
travel from top left to bottom right on 2X3 grid.
*/

using System.Collections.Generic;
using System.Linq;

public class Program{
    public static Dictionary<string,Int64> dict = new();
    public static Int64
     GridTraveler(int m,int n){
        string key = m+"-"+n;
        if(dict.ContainsKey(key)){
            return dict[key];
        }
        if(m == 1 && n == 1){
            return 1;
        }
        if(m == 0 || n == 0){
            return 0;
        }
        var ans = GridTraveler(m-1,n)+GridTraveler(m,n-1);
        dict.Add(key,ans);
        return dict[key];
    } 
    public static void Main(){
        Console.WriteLine(GridTraveler(1,1));
        Console.WriteLine(GridTraveler(2,3));
        Console.WriteLine(GridTraveler(3,2));
        Console.WriteLine(GridTraveler(3,3));
        Console.WriteLine(GridTraveler(18,18));
    }
}   