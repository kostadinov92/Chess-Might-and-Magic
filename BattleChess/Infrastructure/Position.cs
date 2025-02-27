﻿// <auto-generated />

using System.Runtime.CompilerServices;

namespace BattleChess.Infrastructure
{
    using System;
    using Interfaces;
    using Utilities;

    /// <summary>
    /// Position on the Chess board.
    /// </summary>
    public class Position : IPosition
    {
        /// <summary>
        /// Position constructor that takes column and row as arguments
        /// </summary>
        /// <param name="column">The column of the new Position object</param>
        /// <param name="row">The row of the new Position object</param>
        public Position(char column, int row) 
        {
            this.Column = column;
            this.Row = row;
        }


        public char Column { get; private set; }

        public int Row { get; private set; }

        public bool Equals(IPosition other)
        {
            return this.ColumnIsSame(other.Column) && this.RowIsSame(other.Row);
        }

        /// <summary>
        /// Overrides Object.Equals
        /// </summary>
        /// <param name="obj">The object that this object is compared against</param>
        /// <returns>True if the the Column and Row properties of the two objects, have the same values</returns>
        public override bool Equals(object obj)
        {
            return TypeIsSame(obj) && Equals((IPosition) obj) || HasSameReference(obj);
        }

        private bool TypeIsSame(object obj)
        {
            return obj is IPosition;
        }

        private bool ColumnIsSame(char otherColumn)
        {
            return this.Column == otherColumn;
        }

        private bool RowIsSame(int otherRow)
        {
            return this.Row == otherRow;
        }

        private bool HasSameReference(object obj)
        {
            return this == obj;
        }
    }
}
