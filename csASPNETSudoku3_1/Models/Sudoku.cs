namespace csASPNETSudoku3_1
{
    public class Sudoku
    {
        public int IdSudoku;
        public string Sudoku_problem;
        public string Sudoku_solution;
        public string Sudoku_with_input;

        override
        public string ToString()
        {
            return IdSudoku+" problem:"+Sudoku_problem+" solution:"+Sudoku_solution+" progress"+Sudoku_with_input;
    }
    }
}
