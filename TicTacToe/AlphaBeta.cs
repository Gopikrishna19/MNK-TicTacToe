using System;

namespace TicTacToe
{
    /// <summary>
    /// Implements the Alpha-Beta Pruning Search Algorithm
    /// </summary>
    public class AlphaBeta
    {
        /// <summary>
        /// Initializes the Minimax Search i.e. the Alpha Beta Search Algorithm
        /// </summary>
        /// <param name="state">The current state of the tree i.e the root node of the minimax tree</param>
        /// <returns>The next possible best move</returns>
        public static GameTreeNode MinMax(GameTreeNode state)
        {
            // Gets the maximum value for the root node
            int bestValue = MaxValue(state, Globals.MININT, Globals.MAXINT);

            // Find the node with maximum value in the list of childs of the root node
            foreach (GameTreeNode action in state.Nodes)
            {
                if (action.Value == bestValue)
                {
                    return action;
                }
            }

            // By default return the first child of the root
            return (GameTreeNode)state.Nodes[0];
        }

        /// <summary>
        /// Performs the maximum search at the given depth i.e. Maximizes the chance for X
        /// </summary>
        /// <param name="state">The current state</param>
        /// <param name="alpha">The alpha value for the state</param>
        /// <param name="beta">The beta value for the state</param>
        /// <returns>Estimated value for the give state</returns>
        private static int MaxValue(GameTreeNode state, int alpha, int beta)
        {
            // if Terminal-test(state) then return utitly(state)
            if (state.Nodes.Count == 0) return utility(state);

            // v = -Inf
            state.Value = Globals.MININT;

            // Foreach action in state.Actions do
            foreach (GameTreeNode action in state.Nodes)
            {
                // v <- Max(v, MinValue(Result(s, a), alpha, beta))
                state.Value = Math.Max(state.Value, MinValue(action, alpha, beta));

                // Pruning steps
                if (state.Value >= beta)
                    return state.Value;
                alpha = Math.Max(alpha, state.Value);
            }

            // Return state value
            return state.Value;
        }

        private static int MinValue(GameTreeNode state, int alpha, int beta)
        {
            // if Terminal-test(state) then return utitly(state)
            if (state.Nodes.Count == 0) return utility(state);

            // v = +Inf;
            state.Value = Globals.MAXINT;

            // Foreach action in state.Actions do
            foreach (GameTreeNode child in state.Nodes)
            {
                // v <- Max(v, MinValue(Result(s, a), alpha, beta))
                state.Value = Math.Min(state.Value, MaxValue(child, alpha, beta));

                // Pruning steps
                if (state.Value <= alpha)
                    return state.Value;
                beta = Math.Min(beta, state.Value);
            }

            // Return state value
            return state.Value;
        }

        /// <summary>
        /// The utility function calculates the value of the give node in the tree
        /// </summary>
        /// <param name="state">The node to be evaluated</param>        
        /// <returns>Either +200 for X, -200 for O or appropriate evaluated value</returns>
        private static int utility(GameTreeNode state)
        {
            switch (state.NodeBoard.getBoardStatus())
            {
                    // Success for X, return +200
                case Status.Success:
                    return 200;
                    // Success for O i.e. Failure for X, return -200
                case Status.Failure:
                    return -200;
                    // Incomplete do Eval for the state
                case Status.Incomplete:
                    return state.evaluate();
            }
            // Draw return 0
            return 0;
        }
    }
}
