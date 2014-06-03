using System;
namespace TicTacToe
{
    public class Board
    {
        /// <summary>
        /// Holds the states of the board i.e. O, X or N
        /// </summary>
        State[,] _states;

        /// <summary>
        /// Gets or sets the _states of the Board
        /// </summary>
        /// Public property to access the private memeber _states
        public State[,] States
        {
            get { return _states; }
            set { _states = value; }
        }

        /// <summary>
        /// Initializes the Board and States to N := Nothing
        /// </summary>
        /// Initializes a 2D-Array of Board and assigns all the states to N := Nothing
        public Board()
        {
            // initialize 2D-Array
            States = new State[Globals.ROWS, Globals.COLS];

            // initialize all elements of Board with N := Nothing
            for (int i = 0; i < Globals.ROWS; ++i)
                for (int j = 0; j < Globals.COLS; ++j)
                    States[i, j] = State.N;
        }

        /// <summary>
        /// Copies given Board into current Board
        /// </summary>
        /// <param name="board">Board of values</param>
        /// Initializes a 2D-Array of Board and assigns states corresponding to given Board
        public Board(Board board)
        {
            // initialize 2D-Array
            States = new State[Globals.ROWS, Globals.COLS];

            // initialize states of the Board with states of given Board
            for (int i = 0; i < Globals.ROWS; ++i)
                for (int j = 0; j < Globals.COLS; ++j)
                    States[i, j] = board[i, j];
        }

        /// <summary>
        /// Access the Board states by its classname, eg: Board[1, 2] will give _states[1, 2]
        /// </summary>
        /// <param name="i">Row of the Board</param>
        /// <param name="j">Column of the Board</param>
        /// <returns>State of Board at [i, j]</returns>
        public State this[int i, int j]
        {
            get { return States[i, j]; }
            set
            {
                States[i, j] = value;
            }
        }

        /// <summary>
        /// Checks the Board whether it is finished or not
        /// </summary>
        /// <returns>Returns the Status of the Board, i.e. Success, Draw or Incomplete</returns>
        public Status getBoardStatus()
        {
            int i, j;

            // Check row wise
            for (i = 0; i < Globals.ROWS; ++i)
            {
                // Loop only Columns - Consequtive cells
                // as the adjacent CONS number of cells will be checked anyhow
                for (j = 0; j < Globals.COLS - Globals.CONS + 1; ++j)
                {
                    // Check adjacent cells only if current cell is not N := Nothing
                    if (States[i, j] != State.N)
                    {
                        // Check consecutive 4 X or O from the given position
                        if (CheckRow(i,j,4,State.O)) return Status.Failure;
                        else if(CheckRow(i,j,4, State.X)) return Status.Success;
                    }
                }
            }

            // Check column wise
            // Loop only Rows - Consequtive cells
            // as the adjacent CONS number of cells will be checked anyhow
            for (i = 0; i < Globals.ROWS - Globals.CONS + 1; ++i)
            {
                for (j = 0; j < Globals.COLS; ++j)
                {
                    // Check adjacent cells only if current cell is not N := Nothing
                    if (States[i, j] != State.N)
                    {
                        // Check consecutive 4 X or O from the given position
                        if (CheckCol(i, j, 4, State.O)) return Status.Failure;
                        else if (CheckCol(i, j, 4, State.X)) return Status.Success;
                    }
                }
            }

            // Check \ diagonal wise
            // Loop only Rows - Consequtive cells
            // as the adjacent CONS number of cells will be checked anyhow
            for (i = 0; i < Globals.ROWS - Globals.CONS + 1; ++i)
            {
                // Loop only Cols - Consequtive cells
                // as the adjacent CONS number of cells will be checked anyhow
                for (j = 0; j < Globals.COLS - Globals.CONS + 1; ++j)
                {
                    // Check adjacent cells only if current cell is not N := Nothing
                    if (States[i, j] != State.N)
                    {
                        // Check consecutive 4 X or O from the given position
                        if (CheckD135(i, j, 4, State.O)) return Status.Failure;
                        else if (CheckD135(i, j, 4, State.X)) return Status.Success;
                    }
                }
            }

            // Check / diagonal wise
            // Loop only Rows - Consequtive cells
            // as the adjacent CONS number of cells will be checked anyhow
            for (i = Globals.CONS - 1; i < Globals.ROWS; ++i)
            {
                // Loop only Cols - Consequtive cells
                // as the adjacent CONS number of cells will be checked anyhow
                for (j = 0; j < Globals.COLS - Globals.CONS + 1; ++j)
                {
                    // Check adjacent cells only if current cell is not N := Nothing
                    if (States[i, j] != State.N)
                    {
                        // Check consecutive 4 X or O from the given position
                        if (CheckD45(i, j, 4, State.O)) return Status.Failure;
                        else if (CheckD45(i, j, 4, State.X)) return Status.Success;
                    }
                }
            }

            // If all directions failed, then it board may be incomplete
            // So, check for incompleteness
            for (i = 0; i < Globals.ROWS; ++i)
            {
                for (j = 0; j < Globals.COLS; ++j)
                {
                    // if even a single cell is N := Nothing, return Incomplete Board
                    if (States[i, j] == State.N) return Status.Incomplete;
                }
            }

            // A complete Board with no success for either players? Then of course the Board is Draw
            return Status.Draw;
        }

        /// <summary>
        /// Prints the current board; used for debugging the nodes
        /// </summary>
        public void printBoard()
        {
            for (int i = 0; i < Globals.ROWS; ++i)
            {
                for (int j = 0; j < Globals.COLS; ++j)
                {
                    Console.Write(this[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Gets the number of Ns := empty cells in the board
        /// </summary>
        /// <returns>Number of cells in the Board with N marked i.e. empty cells</returns>
        public int numberOfEmptyStates()
        {
            int count = 0;
            for (int i = 0; i < Globals.ROWS; ++i)
                for (int j = 0; j < Globals.COLS; ++j)
                    if (this[i, j] == State.N)
                        count += 1;
            return count;
        }

        /// <summary>
        /// Evaluates the current board
        /// </summary>
        /// <returns>The evaluated value for the given board</returns>
        public int evaluateBoard()
        {
            int X1 = 0, X2 = 0, X3 = 0, O1 = 0, O2 = 0, O3 = 0;
            int i, j;

            // check for rowwise chances for X and O
            for (i = 0; i < Globals.ROWS; ++i)
            {
                for (j = 0; j < Globals.COLS - Globals.CONS + 1; ++j)
                {
                    // Count 1 consecutive X := X1
                    if (CheckRow(i, j, 1, State.X)) X1 += 1;
                    // Count 2 consecutive X := X2
                    else if (CheckRow(i, j, 2, State.X)) X2 += 1;
                    // Count 3 consecutive X := X3
                    else if (CheckRow(i, j, 3, State.X)) X3 += 1;

                    // Count 1 consecutive O := O1
                    if (CheckRow(i, j, 1, State.O)) O1 += 1;
                    // Count 2 consecutive O := O2
                    else if (CheckRow(i, j, 2, State.O)) O2 += 1;
                    // Count 3 consecutive O := O3
                    else if (CheckRow(i, j, 3, State.O)) O3 += 1;
                }
            }

            // check for columnwise chances for X and O
            for (i = 0; i < Globals.ROWS - Globals.CONS + 1; ++i)
            {
                for (j = 0; j < Globals.COLS; ++j)
                {
                    // Count 1 consecutive X := X1
                    if (CheckCol(i, j, 1, State.X)) X1 += 1;
                    // Count 2 consecutive X := X2
                    else if (CheckCol(i, j, 2, State.X)) X2 += 1;
                    // Count 3 consecutive X := X3
                    else if (CheckCol(i, j, 3, State.X)) X3 += 1;

                    // Count 1 consecutive O := O1
                    if (CheckCol(i, j, 1, State.O)) O1 += 1;
                    // Count 2 consecutive O := O2
                    else if (CheckCol(i, j, 2, State.O)) O2 += 1;
                    // Count 3 consecutive O := O3
                    else if (CheckCol(i, j, 3, State.O)) O3 += 1;
                }
            }

            // check for \ diagonalwise chances for X and O
            for (i = 0; i < Globals.ROWS - Globals.CONS + 1; ++i)
            {
                for (j = 0; j < Globals.COLS - Globals.CONS + 1; ++j)
                {
                    // Count 1 consecutive X := X1
                    if (CheckD135(i, j, 1, State.X)) X1 += 1;
                    // Count 2 consecutive X := X2
                    else if (CheckD135(i, j, 2, State.X)) X2 += 1;
                    // Count 3 consecutive X := X3
                    else if (CheckD135(i, j, 3, State.X)) X3 += 1;

                    // Count 1 consecutive O := O1
                    if (CheckD135(i, j, 1, State.O)) O1 += 1;
                    // Count 2 consecutive O := O2
                    else if (CheckD135(i, j, 2, State.O)) O2 += 1;
                    // Count 3 consecutive O := O3
                    else if (CheckD135(i, j, 3, State.O)) O3 += 1;
                }
            }

            // check for / diagonalwise chances for X and O
            for (i = Globals.CONS - 1; i < Globals.ROWS; ++i)
            {
                for (j = 0; j < Globals.COLS - Globals.CONS + 1; ++j)
                {
                    // Count 1 consecutive X := X1
                    if (CheckD45(i, j, 1, State.X)) X1 += 1;
                    // Count 2 consecutive X := X2
                    else if (CheckD45(i, j, 2, State.X)) X2 += 1;
                    // Count 3 consecutive X := X3
                    else if (CheckD45(i, j, 3, State.X)) X3 += 1;

                    // Count 1 consecutive O := O1
                    if (CheckD45(i, j, 1, State.O)) O1 += 1;
                    // Count 2 consecutive O := O2
                    else if (CheckD45(i, j, 2, State.O)) O2 += 1;
                    // Count 3 consecutive O := O3
                    else if (CheckD45(i, j, 3, State.O)) O3 += 1;
                }
            }

            // Extended from X1 - 3O2 + 3X2 - O1 through Pascal's triangle
            // to X1 - 5O2 + 10X3 - 10O3 + 5X2 - O1 for 4x4 matrix
            return X1 + 5 * X2 + 10 * X3 - (O3 * 10 + O2 * 5 + O1);
        }

        ///
        /// The following four functions check for the consecutiveness of every row, column and on diagonals for the given
        /// count and returns whether the consecutiveness is availabe on the board or not
        /// It also check for win status when count is 4 (consecutive := 4)
        /// 

        /// <summary>
        /// Check for number of consecutive X or O rowwise
        /// </summary>
        /// <param name="i">In ith row</param>
        /// <param name="j">In jth column</param>
        /// <param name="consecutive">Number of consecutives to check for</param>
        /// <param name="player">For X or for O</param>
        /// <returns>If the give number of consecutives present</returns>
        private bool CheckRow(int i, int j, int consecutive, State player)
        {
            switch (consecutive)
            {
                case 1:
                    if ((this[i, j + 0] == player && this[i, j + 1] == State.N && this[i, j + 2] == State.N && this[i, j + 3] == State.N) ||
                        (this[i, j + 0] == State.N && this[i, j + 1] == player && this[i, j + 2] == State.N && this[i, j + 3] == State.N) ||
                        (this[i, j + 0] == State.N && this[i, j + 1] == State.N && this[i, j + 2] == player && this[i, j + 3] == State.N) ||
                        (this[i, j + 0] == State.N && this[i, j + 1] == State.N && this[i, j + 2] == State.N && this[i, j + 3] == player))
                        return true;
                    break;
                case 2:
                    if ((this[i, j + 0] == player && this[i, j + 1] == player && this[i, j + 2] == State.N && this[i, j + 3] == State.N) ||
                        (this[i, j + 0] == player && this[i, j + 1] == State.N && this[i, j + 2] == player && this[i, j + 3] == State.N) ||
                        (this[i, j + 0] == player && this[i, j + 1] == State.N && this[i, j + 2] == State.N && this[i, j + 3] == player) ||
                        (this[i, j + 0] == State.N && this[i, j + 1] == player && this[i, j + 2] == player && this[i, j + 3] == State.N) ||
                        (this[i, j + 0] == State.N && this[i, j + 1] == player && this[i, j + 2] == State.N && this[i, j + 3] == player) ||
                        (this[i, j + 0] == State.N && this[i, j + 1] == State.N && this[i, j + 2] == player && this[i, j + 3] == player))
                        return true;
                    break;
                case 3:
                    if ((this[i, j + 0] == player && this[i, j + 1] == player && this[i, j + 2] == player && this[i, j + 3] == State.N) ||
                        (this[i, j + 0] == player && this[i, j + 1] == player && this[i, j + 2] == State.N && this[i, j + 3] == player) ||
                        (this[i, j + 0] == player && this[i, j + 1] == State.N && this[i, j + 2] == player && this[i, j + 3] == player) ||
                        (this[i, j + 0] == State.N && this[i, j + 1] == player && this[i, j + 2] == player && this[i, j + 3] == player))
                        return true;
                    break;
                case 4:
                    if (this[i, j + 0] == player && this[i, j + 1] == player && this[i, j + 2] == player && this[i, j + 3] == player)
                        return true;
                    break;
            }
            return false;
        }

        /// <summary>
        /// Check for number of consecutive X or O columnwise
        /// </summary>
        /// <param name="i">In ith row</param>
        /// <param name="j">In jth column</param>
        /// <param name="consecutive">Number of consecutives to check for</param>
        /// <param name="player">For X or for O</param>
        /// <returns>If the give number of consecutives present</returns>
        private bool CheckCol(int i, int j, int consecutive, State player)
        {
            switch (consecutive)
            {
                case 1:
                    if ((this[i + 0, j] == player && this[i + 1, j] == State.N && this[i + 2, j] == State.N && this[i + 3, j] == State.N) ||
                        (this[i + 0, j] == State.N && this[i + 1, j] == player && this[i + 2, j] == State.N && this[i + 3, j] == State.N) ||
                        (this[i + 0, j] == State.N && this[i + 1, j] == State.N && this[i + 2, j] == player && this[i + 3, j] == State.N) ||
                        (this[i + 0, j] == State.N && this[i + 1, j] == State.N && this[i + 2, j] == State.N && this[i + 3, j] == player))
                        return true;
                    break;
                case 2:
                    if ((this[i + 0, j] == player && this[i + 1, j] == player && this[i + 2, j] == State.N && this[i + 3, j] == State.N) ||
                        (this[i + 0, j] == player && this[i + 1, j] == State.N && this[i + 2, j] == player && this[i + 3, j] == State.N) ||
                        (this[i + 0, j] == player && this[i + 1, j] == State.N && this[i + 2, j] == State.N && this[i + 3, j] == player) ||
                        (this[i + 0, j] == State.N && this[i + 1, j] == player && this[i + 2, j] == player && this[i + 3, j] == State.N) ||
                        (this[i + 0, j] == State.N && this[i + 1, j] == player && this[i + 2, j] == State.N && this[i + 3, j] == player) ||
                        (this[i + 0, j] == State.N && this[i + 1, j] == State.N && this[i + 2, j] == player && this[i + 3, j] == player))
                        return true;
                    break;
                case 3:
                    if ((this[i + 0, j] == player && this[i + 1, j] == player && this[i + 2, j] == player && this[i + 3, j] == State.N) ||
                        (this[i + 0, j] == player && this[i + 1, j] == player && this[i + 2, j] == State.N && this[i + 3, j] == player) ||
                        (this[i + 0, j] == player && this[i + 1, j] == State.N && this[i + 2, j] == player && this[i + 3, j] == player) ||
                        (this[i + 0, j] == State.N && this[i + 1, j] == player && this[i + 2, j] == player && this[i + 3, j] == player))
                        return true;
                    break;
                case 4:
                    if (this[i + 0, j] == player && this[i + 1, j] == player && this[i + 2, j] == player && this[i + 3, j] == player)
                        return true;
                    break;
            }
            return false;
        }

        /// <summary>
        /// Check for number of consecutive X or O \ diagonalwise
        /// </summary>
        /// <param name="i">In ith row</param>
        /// <param name="j">In jth column</param>
        /// <param name="consecutive">Number of consecutives to check for</param>
        /// <param name="player">For X or for O</param>
        /// <returns>If the give number of consecutives present</returns>
        private bool CheckD135(int i, int j, int consecutive, State player)
        {
            switch (consecutive)
            {
                case 1:
                    if ((this[i + 0, j + 0] == player && this[i + 1, j + 1] == State.N && this[i + 2, j + 2] == State.N && this[i + 3, j + 3] == State.N) ||
                        (this[i + 0, j + 0] == State.N && this[i + 1, j + 1] == player && this[i + 2, j + 2] == State.N && this[i + 3, j + 3] == State.N) ||
                        (this[i + 0, j + 0] == State.N && this[i + 1, j + 1] == State.N && this[i + 2, j + 2] == player && this[i + 3, j + 3] == State.N) ||
                        (this[i + 0, j + 0] == State.N && this[i + 1, j + 1] == State.N && this[i + 2, j + 2] == State.N && this[i + 3, j + 3] == player))
                        return true;
                    break;
                case 2:
                    if ((this[i + 0, j + 0] == player && this[i + 1, j + 1] == player && this[i + 2, j + 2] == State.N && this[i + 3, j + 3] == State.N) ||
                        (this[i + 0, j + 0] == player && this[i + 1, j + 1] == State.N && this[i + 2, j + 2] == player && this[i + 3, j + 3] == State.N) ||
                        (this[i + 0, j + 0] == player && this[i + 1, j + 1] == State.N && this[i + 2, j + 2] == State.N && this[i + 3, j + 3] == player) ||
                        (this[i + 0, j + 0] == State.N && this[i + 1, j + 1] == player && this[i + 2, j + 2] == player && this[i + 3, j + 3] == State.N) ||
                        (this[i + 0, j + 0] == State.N && this[i + 1, j + 1] == player && this[i + 2, j + 2] == State.N && this[i + 3, j + 3] == player) ||
                        (this[i + 0, j + 0] == State.N && this[i + 1, j + 1] == State.N && this[i + 2, j + 2] == player && this[i + 3, j + 3] == player))
                        return true;
                    break;
                case 3:
                    if ((this[i + 0, j + 0] == player && this[i + 1, j + 1] == player && this[i + 2, j + 2] == player && this[i + 3, j + 3] == State.N) ||
                        (this[i + 0, j + 0] == player && this[i + 1, j + 1] == player && this[i + 2, j + 2] == State.N && this[i + 3, j + 3] == player) ||
                        (this[i + 0, j + 0] == player && this[i + 1, j + 1] == State.N && this[i + 2, j + 2] == player && this[i + 3, j + 3] == player) ||
                        (this[i + 0, j + 0] == State.N && this[i + 1, j + 1] == player && this[i + 2, j + 2] == player && this[i + 3, j + 3] == player))
                        return true;
                    break;
                case 4:
                    if (this[i + 0, j + 0] == player && this[i + 1, j + 1] == player && this[i + 2, j + 2] == player && this[i + 3, j + 3] == player)
                        return true;
                    break;
            }
            return false;
        }

        /// <summary>
        /// Check for number of consecutive X or O / diagonalwise
        /// </summary>
        /// <param name="i">In ith row</param>
        /// <param name="j">In jth column</param>
        /// <param name="consecutive">Number of consecutives to check for</param>
        /// <param name="player">For X or for O</param>
        /// <returns>If the give number of consecutives present</returns>
        private bool CheckD45(int i, int j, int consecutive, State player)
        {
            switch (consecutive)
            {
                case 1:
                    if ((this[i - 0, j + 0] == player && this[i - 1, j + 1] == State.N && this[i - 2, j + 2] == State.N && this[i - 3, j + 3] == State.N) ||
                        (this[i - 0, j + 0] == State.N && this[i - 1, j + 1] == player && this[i - 2, j + 2] == State.N && this[i - 3, j + 3] == State.N) ||
                        (this[i - 0, j + 0] == State.N && this[i - 1, j + 1] == State.N && this[i - 2, j + 2] == player && this[i - 3, j + 3] == State.N) ||
                        (this[i - 0, j + 0] == State.N && this[i - 1, j + 1] == State.N && this[i - 2, j + 2] == State.N && this[i - 3, j + 3] == player))
                        return true;
                    break;
                case 2:
                    if ((this[i - 0, j + 0] == player && this[i - 1, j + 1] == player && this[i - 2, j + 2] == State.N && this[i - 3, j + 3] == State.N) ||
                        (this[i - 0, j + 0] == player && this[i - 1, j + 1] == State.N && this[i - 2, j + 2] == player && this[i - 3, j + 3] == State.N) ||
                        (this[i - 0, j + 0] == player && this[i - 1, j + 1] == State.N && this[i - 2, j + 2] == State.N && this[i - 3, j + 3] == player) ||
                        (this[i - 0, j + 0] == State.N && this[i - 1, j + 1] == player && this[i - 2, j + 2] == player && this[i - 3, j + 3] == State.N) ||
                        (this[i - 0, j + 0] == State.N && this[i - 1, j + 1] == player && this[i - 2, j + 2] == State.N && this[i - 3, j + 3] == player) ||
                        (this[i - 0, j + 0] == State.N && this[i - 1, j + 1] == State.N && this[i - 2, j + 2] == player && this[i - 3, j + 3] == player))
                        return true;
                    break;
                case 3:
                    if ((this[i - 0, j + 0] == player && this[i - 1, j + 1] == player && this[i - 2, j + 2] == player && this[i - 3, j + 3] == State.N) ||
                        (this[i - 0, j + 0] == player && this[i - 1, j + 1] == player && this[i - 2, j + 2] == State.N && this[i - 3, j + 3] == player) ||
                        (this[i - 0, j + 0] == player && this[i - 1, j + 1] == State.N && this[i - 2, j + 2] == player && this[i - 3, j + 3] == player) ||
                        (this[i - 0, j + 0] == State.N && this[i - 1, j + 1] == player && this[i - 2, j + 2] == player && this[i - 3, j + 3] == player))
                        return true;
                    break;
                case 4:
                    if (this[i - 0, j + 0] == player && this[i - 1, j + 1] == player && this[i - 2, j + 2] == player && this[i - 3, j + 3] == player)
                        return true;
                    break;
            }
            return false;
        }
    }
}