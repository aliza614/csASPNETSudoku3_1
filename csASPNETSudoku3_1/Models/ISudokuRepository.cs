
namespace csASPNETMVCSudokuWoDocker.Models{
    public interface ISudokuRepository
    {
        IEnumerable<Sudoku> GetAllSudoku();
    }
}
