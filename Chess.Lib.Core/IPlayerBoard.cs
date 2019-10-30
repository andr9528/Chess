﻿using System.Collections.Generic;
using Chess.Lib.Enum;
using Chess.Repository.Core;

namespace Chess.Lib.Core
{
    public interface IPlayerBoard : IEntity
    {
        PlayerColour Colour { get; set; }
        List<IPiece> Pieces { get; set; }
        PlayerFacing Facing { get; set; }
        IBoard Board { get; set; }
        IPlayer Player { get; set; }
        int BoardId { get; set; }
        int PlayerId { get; set; }

    }
}