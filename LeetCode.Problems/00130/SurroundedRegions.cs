namespace LeetCode.Problems;

public class SurroundedRegions{

    public void Solve(char[][] board) {
        
        if (board == null || board.Length == 0 || board[0].Length == 0) {
            return;
        }
        
        int m = board.Length;
        int n = board[0].Length;
        
        // mark connected 'O's on the boundary as 'B'
        for (int i = 0; i < m; i++) {
            dfs(board, i, 0);
            dfs(board, i, n-1);
        }
        for (int j = 0; j < n; j++) {
            dfs(board, 0, j);
            dfs(board, m-1, j);
        }
        
        // flip all 'O's that are not marked as 'B' to 'X'
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] == 'O') {
                    board[i][j] = 'X';
                } else if (board[i][j] == 'B') {
                    board[i][j] = 'O';
                }
            }
        }
    }

    private void dfs(char[][] board, int i, int j){

        int m = board.Length;
        int n = board[0].Length;
        if (i < 0 || i >= m || j < 0 || j >= n || board[i][j] != 'O') {
            return;
        }
        board[i][j] = 'B';
        dfs(board, i+1, j);
        dfs(board, i-1, j);
        dfs(board, i, j+1);
        dfs(board, i, j-1);

    }

}