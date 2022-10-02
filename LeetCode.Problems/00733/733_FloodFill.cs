namespace LeetCode.Problems;

public class FloodFill{

    public int[][] FloodFillImage(int[][] image, int sr, int sc, int color) {


        Stack<KeyValuePair<int,int>> stack = new Stack<KeyValuePair<int, int>>();
        Stack<KeyValuePair<int,int>> visited = new Stack<KeyValuePair<int, int>>();
        int oldcolor = image[sr][sc];
        stack.Push(new KeyValuePair<int, int>(sr, sc));

        while (stack.Count !=0){
            var tmp = stack.Pop();
            int r = tmp.Key;
            int c = tmp.Value;

            if(image[r][c] == oldcolor){
                visited.Push(tmp);
                image[r][c] = color;
            
            
                KeyValuePair<int,int> pair = new KeyValuePair<int, int>();
                if(r >= 1){
                    pair = new KeyValuePair<int, int>(r-1, c);
                    if(!visited.Contains(pair))
                        stack.Push(pair);
                }

                if(r+1 < image.Length){
                    pair = new KeyValuePair<int, int>(r+1, c);
                    if(!visited.Contains(pair))
                        stack.Push(pair);
                }

                if(c >= 1){
                    pair = new KeyValuePair<int, int>(r, c-1);
                    if(!visited.Contains(pair))
                        stack.Push(pair);
                }

                if(c+1 < image[0].Length){
                    pair = new KeyValuePair<int, int>(r, c+1);
                    if(!visited.Contains(pair))
                        stack.Push(pair);
                }
            }
        }

        return image;

    }

}