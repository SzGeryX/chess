using System;
using System.Collections.Generic;
using System.Text;

namespace chess
{
    enum Colors : int
    {
        White = 0,
        Black
    }

    enum Pieces : int
    {
        Pawn = 0,
        Knight,
        Bishop,
        Rook,
        Queen,
        King
    }

    internal class Board
    {
        Dictionary<Colors, Dictionary<Pieces, Int64>> board;

        Dictionary<Pieces, Int64> defaultPiecePositions = new()
        {
            { Pieces.Pawn,   0x000000000000FF00 },
            { Pieces.Knight, 0x0000000000000042 },
            { Pieces.Bishop, 0x0000000000000024 },
            { Pieces.Rook,   0x0000000000000081 },
            { Pieces.Queen,  0x0000000000000008 },
            { Pieces.King,   0x0000000000000010 }
        };

        public Board()
        {
            board = new();

            foreach (Colors color in Enum.GetValues(typeof(Colors)))
            {
                foreach (Pieces piece in Enum.GetValues(typeof(Pieces)))
                {
                            
                }
            }
        }

        public static Int64 flipBitboard(Int64 bitboard)
        {
            return ((bitboard << 56))|
                   ((bitboard << 40) & 0x00ff000000000000) |
                   ((bitboard << 24) & 0x0000ff0000000000) |
                   ((bitboard << 8)  & 0x000000ff00000000) |
                   ((bitboard >> 8)  & 0x00000000ff000000) |
                   ((bitboard >> 24) & 0x0000000000ff0000) |
                   ((bitboard >> 40) & 0x000000000000ff00) |
                   ((bitboard >> 56));
        }
    }
}
