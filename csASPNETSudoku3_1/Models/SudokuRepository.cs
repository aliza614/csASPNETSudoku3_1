using Dapper;
using System.Data;
using System;
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

            Sudoku sudoku= _conn.QuerySingle<Sudoku>("select * from sudoku where idsudoku=@idsudoku", new { idsudoku = id });
            if(sudoku.Sudoku_solution==null)
            {
                Board b = new Board(sudoku.Sudoku_problem);
                b.CheckPossible(b);
                Console.WriteLine(b.BoardConvertString());
                _conn.Execute("UPDATE `sudoku` SET `sudoku_solution` = @sudoku_sol WHERE idsudoku=@id; ", new { sudoku_sol = b.BoardConvertString() , id=sudoku.IdSudoku});
                sudoku.Sudoku_solution = b.ToString();
            }

            //reset the game
            sudoku.Sudoku_with_input = sudoku.Sudoku_problem;
            _conn.Execute("UPDATE sudoku SET sudoku_with_input =@sudoku_problem WHERE idsudoku=@id", new { sudoku_problem = sudoku.Sudoku_problem, id = sudoku.IdSudoku });
            return sudoku;
        }


        public void UpdateSudoku(Sudoku sudoku)
        {
            Console.WriteLine(sudoku.Sudoku_with_input);
            //for loop to update each char in sudoku_with_input
            
            _conn.Execute("UPDATE Sudoku SET sudoku_with_input=@sudoku_with_input where IdSudoku=@idsudoku", new { sudoku_with_input = sudoku.Sudoku_with_input, idsudoku = sudoku.IdSudoku });
        }
    }
}
