using System;
using System.Collections.Generic;
namespace csASPNETSudoku3_1
{


    public class Board:IBoard
    {
        public Square[] Sudoku = new Square[81];
        public Board(string s)
        {
            for (var i = 0; i < Sudoku.Length; i++)
                Sudoku[i] = new Square(1 * s[i]);
        }

        public bool CheckPossible(Board board)
        {
            bool isSolveable = true;

            while (HasEmptyPlaces(ConvertBoard(board)) && isSolveable)
            {
                isSolveable = false;
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {

                        if (board.Sudoku[row * 9 + col].Value == 0)
                        {
                            List<int> possible = new List<int>();
                            for (int option = 1; option <= 9; option++)
                            {

                                if (Works3(ConvertBoard(board), option, row, col))
                                {
                                    board.Sudoku[row * 9 + col].Value = option;
                                    if (this.CheckPossible(board))
                                    {
                                        possible.Add(option);
                                    }
                                    board.Sudoku[row * 9 + col].Value = 0;

                                }
                            }
                            if (possible.Count == 0) return false;
                            if (possible.Count == 1)
                            {
                                isSolveable = true;
                                board.Sudoku[row * 9 + col].Value = possible[0];
                                return true;
                            }
                            if (possible.Count > 1)
                            {
                                board.Sudoku[row * 9 + col].Value = 0;
                                return true;
                            }
                        }
                    }

                }
            }
            return true;
        }
        public bool HasEmptyPlaces(int[][] puzzle)
        {
            for (int r = 0; r < puzzle.Length; r++)
            {
                for (int c = 0; c < puzzle[r].Length; c++)
                {
                    if (puzzle[r][c] == 0) return true;
                }
            }
            return false;
        }
        public bool Works3(int[][] puzzle, int option, int row, int col)
        {
            if (IsInCol3(puzzle, col, option)) return false;
            if (IsInRow3(puzzle, row, option)) return false;
            if (IsInBox3(puzzle, row, col, option)) return false;

            return true;

        }
        public bool IsInCol3(int[][] puzzle, int col, int option)
        {

            for (int r = 0; r < puzzle.Length; r++)
            {
                if (puzzle[r][col] == option)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsInRow3(int[][] puzzle, int row, int option)
        {
            for (int c = 0; c < puzzle.Length; c++)
            {
                if (puzzle[row][c] == option)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsInBox3(int[][] puzzle, int row, int col, int option)
        {
            int startRow = row / 3 * 3;
            int startCol = col / 3 * 3;
            int endRow = startRow + 2;
            int endCol = startCol + 2;
            for (int r = startRow; r <= endRow; r++)
                for (int c = startCol; c <= endCol; c++)
                    if (puzzle[r][c] == option && c != col && r != row)
                        return true;
            return false;
        }
        public int[][] ConvertBoard(Board board)
        {
            int[][] answer = Array.Empty<int[]>();
            for (int i = 0; i < board.Sudoku.Length; i++)
            {
                int row = i / 9;
                int col = i % 9;
                answer[row][col] = board.Sudoku[i].Value;
            }
            return answer;
        }
        
    }
}