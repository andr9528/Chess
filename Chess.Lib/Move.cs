﻿using Chess.Lib.Core;

namespace Chess.Lib.Concrete
{
    public class Move : IMove
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public bool IsInstantiated { get; set; }
        public ICoordinate From { get; set; }
        public ICoordinate To { get; set; }
        public int Turn { get; set; }
        public int PieceId { get; set; }
    }
}