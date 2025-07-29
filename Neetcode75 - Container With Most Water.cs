public class Solution {
    public int MaxArea(int[] heights) {


        int p1 = 0;
        int p2 = heights.Length-1;
        int y=0;
        int valueMax = 0;

        while(p2>p1){
            int diff =p2-p1; //Get the x range
            y = Math.Min(heights[p1],heights[p2]); //Return the smallest value
            if(diff*y>valueMax){
                valueMax = diff*y;
            }
            if(heights[p2]>heights[p1] || heights[p2]==heights[p1] ){
                p1++;
            }
            else{
                p2--;
            }
        }
        return valueMax;
        
    }
}
