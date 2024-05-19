public class Solution {
    public bool CheckValid(int[][] matrix) {
        HashSet<int> set = null;
        int row = matrix.Length;
        int col = matrix[0].Length;
        
        //for row
        for(int i=0;i<row;i++){
            set = new();
            for(int j=0;j<col;j++){
                int ele = matrix[i][j];
                //if the any same value exists in the same row then we return false
                //else we'll add that value to set
                if(set.Contains(ele)) return false;
                set.Add(ele);
            }
        }
        //for col
        //above same logic for col 
        //moving in each col if any value exists in col then we'll return false
        for(int i=0;i<col;i++){
            set = new();
            for(int j=0;j<row;j++){
                int ele = matrix[j][i];
                if(set.Contains(ele)) return false;
                set.Add(ele);
            }
        }
        return true;
    }
}