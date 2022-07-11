using Dapper;
using System.Data;
namespace csASPNETMVCSudokuWoDocker.Models
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
    }
}
