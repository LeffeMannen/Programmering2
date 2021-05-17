using System;
using System.Collections.Generic;
using System.Text;

namespace Slutprojekt
{
    class Game
    {
        public void MyBoard(string chessPiece)
        {


            var currentCol = 1;

            var currentRow = 1;
            char color;
            char enemy;
            switch (chessPiece)
            {
                case "Black Knight":
                    color = 'B';
                    enemy = 'W';
                    KnightMovements(color, enemy, currentRow, currentCol);
                    break;
                case "White Knight":
                    color = 'W';
                    enemy = 'B';
                    KnightMovements(color, enemy, currentRow, currentCol);
                    break;

                case "Black King":
                    color = 'B';
                    enemy = 'W';
                    KingMovements(color, enemy, currentRow, currentCol);
                    break;
                case "White King":
                    color = 'W';
                    enemy = 'B';
                    KingMovements(color, enemy, currentRow, currentCol);
                    break;

                case "Black Rook":
                    color = 'B';
                    enemy = 'W';
                    RookMovements(color, enemy, currentRow, currentCol);
                    break;
                case "White Rook":
                    color = 'W';
                    enemy = 'B';
                    RookMovements(color, enemy, currentRow, currentCol);
                    break;

                case "Black Bishop":
                    color = 'B';
                    enemy = 'W';
                    BishopMovements(color, enemy, currentRow, currentCol);
                    break;
                case "White Bishop":
                    color = 'W';
                    enemy = 'B';
                    BishopMovements(color, enemy, currentRow, currentCol);
                    break;

                case "Black Queen":
                    color = 'B';
                    enemy = 'W';
                    QueenMovements(color, enemy, currentRow, currentCol);
                    break;
                case "White Queen":
                    color = 'W';
                    enemy = 'B';
                    BishopMovements(color, enemy, currentRow, currentCol);
                    break;
                default:
                    break;
            }
        }
        public static void KnightMovements(char rookColor, char enemy, int currentRow, int currentCol)
        {
        }
        public static void RookMovements(char rookColor, char enemy, int currentRow, int currentCol)
        {
        }
        public static void KingMovements(char rookColor, char enemy, int currentRow, int currentCol)
        {
        }
        public static void BishopMovements(char rookColor, char enemy, int currentRow, int currentCol)
        {
        }
        public static void QueenMovements(char rookColor, char enemy, int currentRow, int currentCol)
        {
        }
    }
}
