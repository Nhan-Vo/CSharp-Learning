public class Tictactoe
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';

    public static void Main(string[] args)
    {
        InitializeBoard();
        Console.WriteLine("Welcome to Tic Tac Toe!");
        while (true)
        {
            PrintBoard();
            Console.WriteLine($"Player {currentPlayer}, enter your move (row and column: 1 1): ");
            string input = Console.ReadLine();
            var parts = input.Split();
            // check input: two numbers, in range 1–3, empty cell
            if (parts.Length != 2 || !int.TryParse(parts[0], out int row) || !int.TryParse(parts[1], out int col) || row < 1 || row > 3 || col < 1 || col > 3 || board[row - 1, col - 1] != ' ')
            {
                Console.WriteLine("Invalid move! Try again.");
                continue;
            }

            board[row - 1, col - 1] = currentPlayer;

            if (CheckWin(currentPlayer))
            {
                PrintBoard();
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }
            if (IsBoardFull())
            {
                PrintBoard();
                Console.WriteLine("It's a draw!");
                break;
            }
            //switching player
            if (currentPlayer == 'X')
            {
                currentPlayer = 'O';
            }
            else
            {
                currentPlayer = 'X';
            }
                
        }
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                board[i, j] = ' ';
    }

    static void PrintBoard()
    {
        Console.WriteLine("  1 2 3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i + 1} ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("  -----");
        }
    }

    static bool CheckWin(char player)
    {
        // Row and column
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
                (board[0, i] == player && board[1, i] == player && board[2, i] == player))
                return true;
        }
        // Diagonal
        if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
            (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
            return true;

        return false;
    }

    static bool IsBoardFull()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (board[i, j] == ' ')
                    return false;
        return true;
    }
}