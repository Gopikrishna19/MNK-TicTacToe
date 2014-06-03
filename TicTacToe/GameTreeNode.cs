using System;
using System.Windows.Forms;
namespace TicTacToe
{
    /// <summary>
    /// Class for managing individual Node in the GameTree; extends the inbuilt TreeNode for enhanced facilities like
    /// automated Garbage Collection, childnode storage, nextnode links etc etc
    /// </summary>
    public class GameTreeNode : TreeNode
    {
        /// <summary>
        /// Node's alpha value
        /// </summary>
        private int _alpha;

        /// <summary>
        /// Node's beta value
        /// </summary>
        private int _beta;

        /// <summary>
        /// Node's actual value
        /// </summary>
        private int _value;

        /// <summary>
        /// The node's game board
        /// </summary>
        private Board _nodeBoard;

        /// <summary>
        /// Next player's symbol, stored for the child nodes
        /// </summary>
        private State _nextTurn;

        /// <summary>
        /// Currently marked Row
        /// </summary>
        private int _row;

        /// <summary>
        /// Currently marked Column
        /// </summary>
        private int _column;

        /// <summary>
        /// Gets the currently marked Row
        /// </summary>
        public int Row
        {
            get { return _row; }
        }

        /// <summary>
        /// Gets the currently marked Column
        /// </summary>
        public int Column
        {
            get { return _column; }
        }

        /// <summary>
        /// Gets or Sets the nodes Value
        /// </summary>
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Gets or Sets the node's next turn for the child nodes
        /// </summary>
        public State NextTurn
        {
            get { return _nextTurn; }
            set { _nextTurn = value; }
        }

        /// <summary>
        /// Gets or Sets the node's alpha value
        /// </summary>
        public int Alpha
        {
            get { return _alpha; }
            set { _alpha = value; }
        }

        /// <summary>
        /// Gets or Sets the node's beta value
        /// </summary>
        public int Beta
        {
            get { return _beta; }
            set { _beta = value; }
        }

        /// <summary>
        /// Constructor: Initializes the Node with empty Board and, 0 alpha and beta values
        /// </summary>
        public GameTreeNode()
        {
            _nodeBoard = new Board();
            Alpha = 0;
            Beta = 0;
        }

        /// <summary>
        /// Constructor: Initializes the Node with given Board, marked at row and col position
        /// </summary>
        /// <param name="board">Board to copy into new Node</param>
        /// <param name="row">Marked where in Row</param>
        /// <param name="col">Marked where in Column</param>
        public GameTreeNode(Board board, int row, int col)
        {
            // Call Board base to copy the given Board into current Node
            _nodeBoard = new Board(board);
            Alpha = 0;
            Beta = 0;
            _row = row;
            _column = col;
        }

        /// <summary>
        /// Gets or Sets the game Board of the current Node
        /// </summary>
        public Board NodeBoard
        {
            get { return _nodeBoard; }
            set { _nodeBoard = new Board(value); }
        }

        /// <summary>
        /// Prints the current Node: used for debugging
        /// </summary>
        public void printNode()
        {
            Console.Clear();
            Console.WriteLine("Alpha: " + Alpha.ToString() + " Beta: " + Beta.ToString());
            Console.WriteLine("Value: " + Value.ToString());
            NodeBoard.printBoard();
        }

        /// <summary>
        /// Calls the Board.Evaluate function
        /// </summary>
        /// <returns>The evaluated value for the Board in current Node</returns>
        public int evaluate()
        {
            Value = NodeBoard.evaluateBoard();
            return Value;
        }
    }
}
