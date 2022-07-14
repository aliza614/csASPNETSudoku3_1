// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
  
function checkPossible(board) {
    let isSolveable = true;

    while (HasEmptyPlaces(board) && isSolveable) {
        isSolveable = false;
        for (let row = 0; row < 9; row++)
        {
            for (let col = 0; col < 9; col++)
            {
                if (board[row * 9 + col].Value == 0) {
                    var possible = new List();
                    for (let option = 1; option <= 9; option++) {
                        if (Works3(board, option, row, col)) {
                            board[row * 9 + col].Value = option;
                            if (this.CheckPossible(board)) {
                                possible.Add(option);
                            }
                            board[row * 9 + col].Value = 0;
                        }
                    }
                    
                    if (possible.Count === 0) {
                        return false;
                    }
                    if (possible.Count === 1) {
                        isSolveable = true;
                        board[row * 9 + col].Value = possible[0];
                        return true;
                    }
                    if (possible.Count > 1) {
                        board[row * 9 + col].Value = 0;
                        return true;
                    }
                }
            }

        }
    }
    return true;
}
function HasEmptyPlaces( puzzle)
{
    for (let r = 0; r < 9; r++)
    {
        for (let c = 0; c < 9; c++)
        {
            if (puzzle[9*r+c] === 0) return true;
        }
    }
    return false;
}
function Works3(puzzle, option, row, col)
{
    if (IsInCol3(puzzle, col, option)) return false;
    if (IsInRow3(puzzle, row, option)) return false;
    if (IsInBox3(puzzle, row, col, option)) return false;

    return true;

}
function IsInCol3(puzzle, col, option)
{

    for (let r = 0; r < 9; r++)
    {
        if (puzzle[9*r+col] === option) {
            return true;
        }
    }
    return false;
}
function IsInRow3(puzzle, row, option)
{
    for (let c = 0; c < 9; c++)
    {
        if (puzzle[9*row+c] === option) {
            return true;
        }
    }
    return false;
}
function IsInBox3(puzzle, row, col, option) {
    let startRow = row / 3 * 3;
    let startCol = col / 3 * 3;
    let endRow = startRow + 2;
    let endCol = startCol + 2;
    for (let r = startRow; r <= endRow; r++)
        for (let c = startCol; c <= endCol; c++)
            if (puzzle[9 * r + c] === option && c !== col && r !== row)
                return true;
    return false;
 }

/*
function ConvertBoard(board)
{
    let answer = Array.Empty < int[] > ();
    for (let i = 0; i < board.Sudoku.Length; i++)
    {
                int row = i / 9;
                int col = i % 9;
        answer[row][col] = board.Sudoku[i].Value;
    }
    return answer;
}
    * /  
    
    
}*/