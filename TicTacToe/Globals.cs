namespace TicTacToe
{
    /// <summary>
    /// Type for the each cell of the Board
    /// </summary>
    public enum State { O = 1, X = 2, N = 3 }

    /// <summary>
    /// Type to indicate the status of the Board
    /// </summary>
    public enum Status { Incomplete = 2, Success = 1, Draw = 0, Failure = -1}

    /// <summary>
    /// Class that contains all the values global for the Application
    /// </summary>
    internal class Globals
    {
        // Number of rows in the Board
        public const int ROWS = 4;

        // Number of columns in the Board
        public const int COLS = 5;

        // Number of consequtive cells to win
        public const int CONS = 4;

        // Maximum limit for Beta of Alpha-Beta Search Tree i.e. +Inf
        public const int MAXINT = 1000;

        // Minimum limit for Alpha of Alpha-Beta Search Tree i.e. -Inf
        public const int MININT = -1000;
    }
}
