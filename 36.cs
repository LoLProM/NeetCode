public class Solution
{
    public static bool IsValidSudoku(char[][] sudokuBoard)
    {
        var rows = new Dictionary<int, HashSet<char>>();
        var columns = new Dictionary<int, HashSet<char>>();
        var box = new Dictionary<(int row, int col), HashSet<char>>();

        for (int i = 0; i < 9; i++)
        {
            if (!rows.ContainsKey(i))
            {
                rows[i] = new HashSet<char>();
            }
            if (!columns.ContainsKey(i))
            {
                columns[i] = new HashSet<char>();
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (!box.ContainsKey((i / 3, j / 3)))
                {
                    box[(i / 3, j / 3)] = new HashSet<char>();
                }
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (sudokuBoard[i][j] == '.') continue;

                if (IsValid(sudokuBoard, rows, columns, box, i, j))
                {
                    rows[i].Add(sudokuBoard[i][j]);
                    columns[j].Add(sudokuBoard[i][j]);
                    box[(i / 3, j / 3)].Add(sudokuBoard[i][j]);
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }

    private static bool IsValid(char[][] sudokuBoard, Dictionary<int, HashSet<char>> rows, Dictionary<int, HashSet<char>> columns, Dictionary<(int row, int col), HashSet<char>> box, int i, int j)
    {
        return !rows[i].Contains(sudokuBoard[i][j]) && !columns[j].Contains(sudokuBoard[i][j]) && !box[(i / 3, j / 3)].Contains(sudokuBoard[i][j]);
    }
}