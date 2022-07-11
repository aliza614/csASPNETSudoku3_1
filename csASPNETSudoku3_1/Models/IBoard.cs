namespace csASPNETMVCSudokuWoDocker.Models
{
    public interface IBoard
    {

        bool CheckPossible(Board board);
        
        bool HasEmptyPlaces(int[][] puzzle);
        
        bool Works3(int[][] puzzle, int option, int row, int col);
        
        bool IsInCol3(int[][] puzzle, int col, int option);
        
        bool IsInRow3(int[][] puzzle, int row, int option);
        
        bool IsInBox3(int[][] puzzle, int row, int col, int option);
        int[][] ConvertBoard(Board board);

       

    }
}

