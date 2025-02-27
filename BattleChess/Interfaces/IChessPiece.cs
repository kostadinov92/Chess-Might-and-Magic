﻿// <auto-generated />

using Microsoft.Xna.Framework;


using BattleChess.Infrastructure;
using BattleChess.Utilities;

namespace BattleChess.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface defining basic chess piece actions
    /// </summary>
    public interface IChessPiece : IGameObject, IDrawableAttribute
    {        
        /// <summary>
        /// Returns a collection of the possible Moves for this piece
        /// </summary>
        ICollection<IMove> PossibleMoves { get; }

        /// <summary>
        /// Returns the current IField object of that piece
        /// </summary>
        IField Field { get; }

        /// <summary>
        /// Returns the IAttack object for this piece
        /// </summary>
        IAttack Attack { get; }

        /// <summary>
        /// Returns the IDefence object for this piece
        /// </summary>
        IDefense Defence { get; }

        IMovePattern MovePattern { get; }

        /// <summary>
        /// Returns True if Health is less or equal to 0
        /// </summary>
        bool IsDead { get; }

        /// <summary>
        /// Returns the current Health value
        /// </summary>
        int Health { get; }

        /// <summary>
        /// Returns the current Mana value
        /// </summary>
        int Mana { get; }

        /// <summary>
        /// The color of the current IChessPiece object
        /// </summary>
        ColorType Color { get; }

        /// <summary>
        /// Adds/Substracts health to the current Health value of the chess piece
        /// </summary>
        /// <param name="healthValue">
        /// If healthValue is less than 0, the amount is substracted from Health.
        /// If healthValue is more than 0, the amount is added to Health. 
        /// </param>
        void AddHealth(int healthValue);

        /// <summary>
        /// Adds/Substracts health to the current Health value of the chess piece
        /// </summary>
        /// <param name="manaValue">
        /// If manaValue is less than 0, the amount is substracted from Mana.
        /// If manaValue is more than 0, the amount is added to Mana.
        /// </param>
        void AddMana(int manaValue);

        /// <summary>
        /// When called, recalculates the possible moves for this piece and assigns them to the PossibleMoves property
        /// </summary>
        void GeneratePossibleMoves();
    }
}
