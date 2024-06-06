/*
hand = [1,2,3,6,2,3,4,7,8], groupSize = 3
first we are cheking that if the list is divisible by groupsize or not
if no the we just simple return false;

then we are storing the frequency of each num in cardCount dict
countDict:
1-1
2-2
3-2
4-1
6-1
7-1
8-1

Now sort the array 
[1,2,2,3,3,4,6,7,8]

from here  we are looping through the card and for each 
num in card we are looking that can we make sequence from it.
so from that num we'll do for loop which go from 0 to groupSize 
and each time we are checking that if the currentNum exists in the dict if
so that means that we can make sequence if that does not exists the we can 
just simply return false
*/

public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length%groupSize != 0) return false;
        
        Dictionary<int, int> cardCount = new Dictionary<int, int>();
        foreach (int card in hand) {
            if (cardCount.ContainsKey(card)) {
                cardCount[card]++;
            } else {
                cardCount[card] = 1;
            }
        }
        Array.Sort(hand);
        foreach(int card in hand){
            if(cardCount[card]==0) continue;
            for(int i=0;i<groupSize;i++){
                int currentCard = card+i;
                if(!cardCount.ContainsKey(currentCard) || cardCount[currentCard]==0){
                    return false;
                }
                cardCount[currentCard]--;
            }
        }
        return true;
    }
}