// ----------------- Solution 1 -----------------

//this is the first solution i came up with which i know is not 
//right solution


public class Solution {
    public int Reverse(int x) {
        //if x== 0 then return 0;
        if(x==0) return 0;
        
        //convert int to list 
        List<char> lst = new(x.ToString());
        int left = 0,right = lst.Count-1;

        //if first sign is -ve means we'll start with second value
        if(lst[left]=='-') left++;
        while(lst[left]=='0') {
            left=1;
        }
        
        //right side could have many 0's like 10900000
        //we have to remove all the 0's from end until we find first non-zero int
        while(lst[right]=='0'){
            lst.RemoveAt(right);
            right--;
        }

        //then reverse the list
        while(left<right){
            (lst[left],lst[right]) = (lst[right],lst[left]);
            left++;
            right--;
        }
        
        //convert list to string
        StringBuilder sb = new();
        foreach(char c in lst){
            sb.Append(c);
        }
        
        //take max and min
        int maxVal = int.MaxValue;
        int minVal = int.MinValue;

        //convert current int to int64 cause
        Int64 v = Convert.ToInt64(sb.ToString());
        if(v>maxVal || v<minVal) return 0;  
        return Convert.ToInt32(sb.ToString());
    }
}


// ----------------- Solution 2 -----------------
//here simply reversing the int and returning it

public class Solution {
    public int Reverse(int x) {
        // store rev interger
        int rev = 0;
        //until out input is not 0
        while(x!=0){
            // this is the main logic how this works is 
            // each time we are checking if the 
            // rev > int.MaxValue/10 or rev > int.MinValue/10 
            // but why this works ????
            // rev = rev*10 + digit%10; here in this line of code we are multiplying with 10 so before that we are 
            // checking if the divide by 10 is greater than the limit if so then we can just return the 0 
            if(rev>Int32.MaxValue/10 || rev<Int32.MinValue/10) return 0;
            
            int digit = x%10;
            x = x/10;
            rev = rev*10 + digit%10;

        }
        return rev;
    }
}