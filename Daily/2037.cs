/*
here we are sorting both the array and then taking the 
abs values on the index.

the idea is that we are moving the use to the nearest seat
possible that's why this sorting and abs works.

*/
public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        Array.Sort(seats);
        Array.Sort(students);
        int ans = 0;
        for(int i=0;i<seats.Length;i++){
            ans+=Math.Abs(seats[i]-students[i]);
        }
        return ans;
    }
}