namespace LeetCode.Problems;

public class FloodFill{

    public int[][] FloodFillImage(int[][] image, int sr, int sc, int color) {

        int[][] imageFill = new int[image.Length][];  

        imageFill = image;

        if(image[sr][sc] == color){
            return image;
        }else{
            dfs(image, sr, sc, image[sr][sc], color);
        }

        return image;

    }

    private void dfs(int[][]image, int r, int c, int color, int newcolor){

        if(image[r][c] == color){
            image[r][c] = newcolor;

            if (r >= 1)
                dfs(image, r-1,c,color,newcolor);

            if (r+1 < image.Length)
                dfs(image, r+1,c, color,newcolor);

            if (c+1 < image[0].Length)
                dfs(image, r, c+1, color,newcolor);

            if (c >= 1)
                dfs(image, r, c-1, color, newcolor);
        }
    }

}