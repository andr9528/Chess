﻿using System.Collections.Generic;
using Chess.Lib.Core;
using Chess.Lib.Enum;

namespace Chess.Lib.Concrete
{
    public class Player : IPlayer
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public bool IsInstantiated { get; set; }
        public PlayerColour Colour { get; set; }
        public List<IPiece> Pieces { get; set; }
        public PlayerFacing Facing { get; set; }
        public string Name { get; set; }
        public int GameId { get; set; }
    }
}