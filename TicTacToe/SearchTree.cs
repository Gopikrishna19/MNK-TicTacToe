using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TicTacToe
{
    /// <summary>
    /// The game tree of the game to caluclate the next move for X
    /// </summary>
    public class SearchTree
    {
        /// <summary>
        /// To store the immediate move's result
        /// </summary>
        public GameTreeNode immResult;

        /// <summary>
        /// The actual Game Tree
        /// This is the root node the SearchTree
        /// </summary>
        private GameTreeNode GameTree;

        /// <summary>
        /// Constructor: Initializes the variables
        /// </summary>
        public SearchTree()
        {
            immResult = new GameTreeNode();
            GameTree = new GameTreeNode();
        }

        /// <summary>
        /// Create the first root node expands the root node
        /// </summary>
        /// <param name="gtn">The root game node</param>
        /// <returns>Returns true if immediate move is possible, otherwise false</returns>
        public bool insertNode(GameTreeNode gtn)
        {
            // Clear the previous nodes, if any
            GameTree.Nodes.Clear();

            // Add the root node to tree
            GameTree.Nodes.Add(gtn);

            // Immediate move is explained below
            // If immediate move is available return true
            if (immediateResult(new GameTreeNode(gtn.NodeBoard, gtn.Row, gtn.Column)))
                return true;

            // Else start expanding the nodes from the root to the given depth
            ExpandNode(gtn, getDepth(gtn.NodeBoard.numberOfEmptyStates()));

            // And return false for not immediate moves
            return false;
        }


        /// <summary>
        /// Immediate move allows the CPU to mark down the Board with a winning move without expanding and working
        /// on Alpha Beta Search tree. This move facilitates quicker performance and more accuracy and more winning
        /// chance for X
        /// </summary>
        /// <param name="gtn">Node for which the immediate move is to be calculated</param>
        /// <returns></returns>
        private bool immediateResult(GameTreeNode gtn)
        {
            // Mark down the node for X's move
            gtn.NextTurn = State.X;

            // Generate list of immediate moves
            gtn.Nodes.AddRange(generateSubTree(gtn));
            foreach (TreeNode child in gtn.Nodes)
            {
                // If the immediate move results in success, return true
                if (((GameTreeNode)child).NodeBoard.getBoardStatus() == Status.Success)
                {
                    immResult = (GameTreeNode)child;
                    return true;
                }
            }

            // Return false otherwise
            return false;
        }

        int getDepth(int n)
        {
            //
            // n :=  number of possible moves, i.e number of empty states on the Board
            // For any n, the depth can be caluculated as follows (for the current game)
            //
            //          |  0                       , x < 0
            //          |                  x
            //          |  /   log(5) / 8 \
            //  depth = |  \ e            /  + L   , 0 <= x <= 8
            //          |
            //          |  5                       , x > 8
            //
            //
            // where L := Difficulty Level
            // and x goes from -3, -2, ... 0 ... 8 and stays 8 afterwards
            // So, the depth for 19 moves is 4, for 18 is 4, and for 15 moves, it is 5 and so on till, 
            // for 9 availbale moves, the depth is 9.
            // And stays at 9 for available moves less than 9
            // It is done so to avoid memoryOverFlow Exception.
            //
            // exponentially, the depth from 4 to 9 is calculated using the above formula.
            //
            // Thus, the CUT-OFF or DEPTH-LIMIT is calculated.
            //

            int x = Globals.ROWS * Globals.COLS - n - 3;                                // 4x5 - 20 - 3 = -3
            int depth = (int)Math.Floor(Math.Pow(Math.Exp(Math.Log(5) / 8), x)) + Properties.Settings.Default.Difficulty;
            if (depth > 9) depth = 9;
            return depth;
        }

        /// <summary>
        /// Recursively expand nodex till the depth is met
        /// </summary>
        /// <param name="tn">TreeNode to expand</param>
        /// <param name="depth">Depth till which to expand</param>
        public void ExpandNode(TreeNode tn, int depth)
        {
            // If depth is reached return
            if (depth <= 0) return;

            GameTreeNode gtn = (GameTreeNode)tn;
            // Expand the node only if the Board of the node is Incomplete, otherwise no need to expand
            if (gtn.NodeBoard.getBoardStatus() == Status.Incomplete)
            {
                // Clear previous nodes, if any
                gtn.Nodes.Clear();
                
                // Generate the child nodes for the given node
                gtn.Nodes.AddRange(generateSubTree(gtn));
            }

            foreach (TreeNode child in gtn.Nodes)
            {
                // Expand node for each of the child nodes in the current node
                ExpandNode(child, depth - 1);
            }
        }

        /// <summary>
        /// Generates child nodes for the given node
        /// </summary>
        /// <param name="selectedNode">Node for which the child nodes are to be generated</param>
        /// <returns>Returns the list of generated child nodes</returns>
        private GameTreeNode[] generateSubTree(GameTreeNode selectedNode)
        {
            List<GameTreeNode> gtns = new List<GameTreeNode>();

            // Get the current board
            Board currentBoard = new Board(selectedNode.NodeBoard);

            // For each possible moves available on the board, generate a child node
            // and add it to the list of child nodes
            for (int i = 0; i < Globals.ROWS; ++i)
                for (int j = 0; j < Globals.COLS; ++j)
                    if (currentBoard[i, j] == State.N)
                    {
                        Board temp = new Board(currentBoard);
                        // Create a possible move upon the current board
                        temp[i, j] = selectedNode.NextTurn;

                        // Generate a child node with the possible board and mark down the 
                        // position at which the new move is made
                        GameTreeNode childNode = new GameTreeNode(temp, i, j);
                        childNode.NextTurn = (State)((int)selectedNode.NextTurn % 2 + 1);

                        // Enlist the child node
                        gtns.Add(childNode);
                    }

            // Return the list of nodes
            return gtns.ToArray();
        }

        /// <summary>
        /// Gets the next best move for the root node, by performing an Alpha-Beta Search
        /// </summary>
        /// <returns>Returns the node with next best move</returns>
        public GameTreeNode getNextBestMove()
        {
            return AlphaBeta.MinMax((GameTreeNode)GameTree.Nodes[0]);
        }
    }
}