using System;
using ConsoleChess.board;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            Screen.printBoard(board);
        }
    }
}