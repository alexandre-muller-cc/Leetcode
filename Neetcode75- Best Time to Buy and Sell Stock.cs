public class Solution {
    public int MaxProfit(int[] prices) {

        int p1 = 0;
        int p2 = 1;
        int maxprofit = 0;

        while(p2<prices.Length){
            if(prices[p1]>=prices[p2]){
                p1=p2;
                p2++;
            }
            else{
                
                maxprofit = Math.Max(prices[p2]-prices[p1],maxprofit);
                p2++;
            }
        }
        return maxprofit;
    }
}
