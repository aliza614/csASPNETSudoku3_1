namespace csASPNETSudoku3_1
{
    public class Sudoku
    {
        public int IdSudoku;
        public string Sudoku_problem;
        public string Sudoku_solution;
        public string Sudoku_with_input;


        /*public Sudoku(int idSudoku, string sudoku_problem, string sudoku_solution, string sudoku_with_input)
        {
            IdSudoku = idSudoku;
            Sudoku_problem = sudoku_problem;
            Sudoku_solution = sudoku_solution;
            Sudoku_with_input = sudoku_with_input;
        }*/

        override
        public string ToString()
        {
            return IdSudoku+" problem:"+Sudoku_problem+" solution:"+Sudoku_solution+" progress"+Sudoku_with_input;
    }
        /*
        public string GetInputs()
        {
            for
            this.Sudoku_with_input
        }
        */
    }
}
