﻿// <auto-generated />
namespace BattleChess.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for MovePattern objects
    /// </summary>
    public interface IMovePattern
    {
        /// <summary>
        /// Generates a collection of possible moves, based on the current field.
        /// </summary>
        /// <param name="currentField">
        /// The starting point of the possible moves.
        /// </param>
        /// <returns>
        /// A collection of IMove objects
        /// </returns>
        ICollection<IMove> GeneratePossibleMoves(IField currentField);
    }
}
