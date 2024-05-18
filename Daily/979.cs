public class Solution {
    //taking global varible cause need to update this 
    //as answer in DFS method
    public int moves = 0;
    public int DistributeCoins(TreeNode root) {
        DFS(root);
        return moves;
    }
    private int DFS(TreeNode current){
        //base case if the current node value is 0 
        //then return the 0
        if(current == null) return 0;

        /*taking recursion call on left and right node 
        until we are at the last node
        you might be wondering why are are going to last node
        when our last node could be null and another have all the
        coins which we want to distribute
        so lets think about math we can not travel in tree in the manner we wanted 
         like from any node to any other node 
         we have travel from top 
         so that's why we are going to bottom and then moving upward 
        and we are returning (current.val - 1) 
        
        WHY??
        
        cause we are we need to give each node 1 coins even if that node value 0 value it
        it will return val - 1 that will add that value to move but before we 
        add that to move we are taking abs value cause it could be -1 
        this the math behind that it's just works in the return statement we can see that we are returning 
        return current.val - 1 + leftCoins + rightCoins;
        in the parent node we are returning left + right and we'll take 1 for our current node cause 
        we need to distribute 1 to each node in a way we are and then sum of all this will go 
        to it's parent and so on.
        */ 
        int leftCoins = DFS(current.left);
        int rightCoins = DFS(current.right);

        moves += Math.Abs(leftCoins) + Math.Abs(rightCoins);
        return current.val - 1 + leftCoins + rightCoins;

    }
}