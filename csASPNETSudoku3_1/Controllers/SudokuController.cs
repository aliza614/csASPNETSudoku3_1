using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csASPNETSudoku3_1.Controllers
{
    public class SudokuController : Controller
    {
        private readonly ISudokuRepository _repository;
        public SudokuController(ISudokuRepository repository)
        {
            _repository = repository;
        }
        public IActionResult IndexSudoku()
        {
            var sudokus=_repository.GetAllSudoku();
            /*string str = "";
            foreach(var sudoku in sudokus)
            {
                str += sudoku.ToString()+"\n";
            }
            Console.WriteLine(str);
            var random=new Random();
            var sudoku1 = sudokus.ToArray()[random.Next(sudokus.Count())].Sudoku_problem;
            */
            return View(sudokus);
        }
        public IActionResult ViewSudoku(int id)
        {
            var sudoku=_repository.GetSudoku(id);
            return View(sudoku);
        }
        public IActionResult RedoSudoku(int id)
        {
            var sudoku = _repository.GetSudoku(id);
            return View(sudoku);
        }
        public IActionResult FinishedSudoku(string values, int id)
        {
            Sudoku _sudoku = _repository.GetSudoku(id);
            if (_sudoku == null) return View("SudokuNotFound");
            _sudoku.Sudoku_with_input = values;
            return View(_sudoku);
        }

        public IActionResult UpdateSudokuToDatabase(string values, int id)
        {
            
            
            Sudoku _sudoku = _repository.GetSudoku(id);
            _repository.UpdateSudoku(values, id);
            _sudoku.Sudoku_with_input=values;
            Console.WriteLine(values);
            Console.WriteLine(_sudoku.Sudoku_solution);
            //remove the next line for production
            //_sudoku.Sudoku_with_input = _sudoku.Sudoku_solution;
            if (_sudoku.Sudoku_with_input == _sudoku.Sudoku_solution)
                return RedirectToAction("FinishedSudoku", "Sudoku");//, new { _sudoku});
            else
            {

                return RedirectToAction("RedoSudoku", "Sudoku");
            }
        }
        /*public IActionResult CheckPossible()
        {
            return View();
        }*/

    }
}
