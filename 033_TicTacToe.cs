List<int> board = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // 0 = empty, 1 = X, 2 = O
int currentPlayer = 1; // Start with player X
void PrintBoard()
{
    for (int i = 0; i < 9; i++)
    {
        if (board[i] == 0) Console.Write(".");
        else if (board[i] == 1) Console.Write("X");
        else Console.Write("O");

        if ((i + 1) % 3 == 0) Console.WriteLine();
    }
}
while (true)
{
    PrintBoard();
    Console.Write($"Player {(currentPlayer == 1 ? "X" : "O")}, enter your move (0-8): ");
    int move;
    if (int.TryParse(Console.ReadLine(), out move) && move >= 0 && move < 9 && board[move] == 0)
    {
        board[move] = currentPlayer;

        // Check for win
        if ((board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer) ||
            (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer) ||
            (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer) ||
            (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer) ||
            (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer) ||
            (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer) ||
            (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer) ||
            (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer))
        {
            PrintBoard();
            Console.WriteLine($"Player {(currentPlayer == 1 ? "X" : "O")} wins!");
            break;
        }

        // Check for draw
        if (!board.Contains(0))
        {
            PrintBoard();
            Console.WriteLine("It's a draw!");
            break;
        }

        // Switch player
        currentPlayer = (currentPlayer == 1) ? 2 : 1;
    }
    else
    {
        Console.WriteLine("Invalid move. Try again.");
    }
}