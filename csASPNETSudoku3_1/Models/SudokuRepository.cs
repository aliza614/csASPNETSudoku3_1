using Dapper;
using System.Data;
using System.Collections.Generic;
namespace csASPNETSudoku3_1
{
    public class SudokuRepository : ISudokuRepository
    {
        private IDbConnection _conn;
        public SudokuRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Sudoku> GetAllSudoku()
        {
            return _conn.Query<Sudoku>("Select * from sudoku");
        }

        public Sudoku GetSudoku(int id)
        {

            return _conn.QuerySingle<Sudoku>("select * from sudoku where idsudoku=@idsudoku", new { idsudoku = id });
        }

        public void UpdateSudoku(Sudoku sudoku)
        {
            _conn.Execute("UPDATE Sudoku SET sudoku_with_input=@sudoku_with_input where IdSudoku=@idsudoku", new { sudoku_with_input = sudoku.Sudoku_with_input, idsudoku = sudoku.IdSudoku });
        }
    }
}
