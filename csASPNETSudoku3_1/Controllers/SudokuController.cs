﻿using System;
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
        public IActionResult UpdateSudoku(int id)
        {
            Sudoku _sudoku = _repository.GetSudoku(id);
            if (_sudoku == null) return View("SudokuNotFound");
            return View(_sudoku);
        }

        public IActionResult UpdateSudokuToDatabase(string values, int id)
        {
            
            _repository.UpdateSudoku(values, id);
            return RedirectToAction("UpdateSudoku", new {id=id});
        }
        /*public IActionResult CheckPossible()
        {
            return View();
        }*/

    }
}
