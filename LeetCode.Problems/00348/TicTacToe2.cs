public class TicTacToe2 {

    private int[] rows;
    private int[] cols;
    private int diag;
    private int antiDiag;
    private int size;

    public TicTacToe2(int n) {
        rows = new int[n];
        cols = new int[n];
        diag = 0;
        antiDiag = 0;
        size = n;
    }
    
    public int Move(int row, int col, int player) {
        int toAdd = (player == 1) ? 1 : -1;

        rows[row] += toAdd;
        cols[col] += toAdd;
        if (row == col)
            diag += toAdd;
        if (col == (size - row - 1))
            antiDiag += toAdd;

        if (Math.Abs(rows[row]) == size ||
            Math.Abs(cols[col]) == size ||
            Math.Abs(diag) == size ||
            Math.Abs(antiDiag) == size)
            return player;

        return 0;
    }

    
}