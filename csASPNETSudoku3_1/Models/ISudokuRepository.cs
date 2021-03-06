using System.Collections.Generic;
namespace csASPNETSudoku3_1{
    public interface ISudokuRepository
    {
        IEnumerable<Sudoku> GetAllSudoku();
        Sudoku GetSudoku(int id);
        public void UpdateSudoku(Sudoku sudoku);
        void UpdateSudoku(string values, int id);
    }
}
