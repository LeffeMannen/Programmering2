using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Slutprojekt
{
    public class Game
    {
        public static int PClickX = 0;
        public static int PClickY = 0;

        public static int Black = 1;
        public static int White = 2;
        public static bool MyTurn = true;
        public static bool Clickable = false;

        //-----Piece Variables
        public static class Piece
        {
            public static class White
            {
                public static int[] Pawn = { 1, 2, 3, 4, 5, 6, 7, 8 };
                public static int[] Rook = { 9, 10 };
                public static int[] Knight = { 11, 12 };
                public static int[] Bishop = { 13, 14 };
                public static int Queen = 15;
                public static int King = 16;
            }
            public static class Black
            {
                public static int[] Pawn = { 17, 18, 19, 20, 21, 22, 23, 24 };
                public static int[] Rook = { 25, 26 };
                public static int[] Knight = { 27, 28 };
                public static int[] Bishop = { 29, 30 };
                public static int Queen = 31;
                public static int King = 32;
            }
        }

        //Base
        public static class Base
        {
            public static int[] ID = new int[65];
            public static int[] X = new int[65];
            public static int[] Y = new int[65];
        }

        public static int GetBaseID(int x, int y)
        {
            return ((x - 1) * 8) + y;
        }


        //Move
        public static bool IsMovable(int px, int py, int nx, int ny)
        {

            int ptype = GetType(px, py);
            int ntype = GetType(nx, ny);

            int pmodel = GetModel(px, py);
            int nmodel = GetModel(nx, ny);

            double Distance = GetDistance(px, py, nx, ny);
            int way = GetWay(px, py, nx, ny);

            if (GetTypeName(px, py) == "Pawn")
            {
                if (pmodel == White)
                {
                    if (Distance == 1 && way == Way.Up && ntype == 0)
                        return true;
                    if (Distance == 2 && way == Way.Up && ntype == 0 && py == 2)
                        return true;
                    if (Distance == 1)
                    {
                        if (way == Way.UpLeft || way == Way.UpRight)
                            if (ntype > 0 && pmodel != nmodel) return true;
                    }
                }
                if (pmodel == Black)
                {
                    if (Distance == 1 && way == Way.Down && ntype == 0)
                        return true;
                    if (Distance == 2 && way == Way.Down && ntype == 0 && py == 7)
                        return true;
                    if (Distance == 1)
                    {
                        if (way == Way.DownLeft || way == Way.DownRight)
                            if (ntype > 0 && pmodel != nmodel) return true;
                    }
                }
            }
            return false;
        }

        public static int GetWay(int px, int py, int nx, int ny)
        {
            int ix = (int)(double)Math.Sqrt(Math.Pow(px - nx, 2));
            int iy = (int)(double)Math.Sqrt(Math.Pow(py - ny, 2));

            if (px == nx)
            {
                if (ny > py) return Way.Up;
                if (ny < py) return Way.Down;
            }
            else if (py == ny)
            {
                if (nx > px) return Way.Right;
                if (nx < px) return Way.Left;
            }
            else if (ix == iy)
            {
                if (ny > py && nx > px) return Way.UpRight;
                if (ny > py && nx < px) return Way.UpLeft;
                if (ny < py && nx > px) return Way.DownRight;
                if (ny < py && nx < px) return Way.UpRight;

            }
            return 0;
        }

        public static double GetDistance(int px, int py, int nx, int ny)
        {
            return (double)(Math.Sqrt(Math.Pow(px - nx, 2) + Math.Pow(py - ny, 2)));
        }


        public static string GetTypeName(int x, int y)
        {
            int type = Base.ID[GetBaseID(x, y)];

            if (Piece.White.Pawn.Contains(type) && Piece.Black.Pawn.Contains(type)) return "Pawn";
            if (Piece.White.Knight.Contains(type) && Piece.Black.Knight.Contains(type)) return "Knight";
            if (Piece.White.Bishop.Contains(type) && Piece.Black.Bishop.Contains(type)) return "Bishop";
            if (Piece.White.Rook.Contains(type) && Piece.Black.Rook.Contains(type)) return "Rook";
            if (type == Piece.White.Queen || type == Piece.Black.Queen) return "Queen";
            if (type == Piece.White.King || type == Piece.Black.King) return "King";
            return "";
        }


        public static bool SetBase(int px, int py, int x, int y)
        {
            int type = GetType(px, py);
            int ntype = GetType(x, y);
            if (ntype > 0)
            {

            }
            Base.ID[GetBaseID(x, y)] = type;
            SetImage(MainWindow.ChessImages[GetBaseID(x, y)], type);
            SetImage(MainWindow.ChessImages[GetBaseID(px, py)], 0);
            return true;
        }

        public static void SetImage(Image img, int type)
        {
            img.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (System.Threading.ThreadStart)delegate ()
            {
                if (type < 1) img.Visibility = Visibility.Hidden;
                else img.Source = new BitmapImage(new Uri("pieces/" + MainWindow.ImageName[type], UriKind.Relative));
            });
        }


        public static int GetModel(int x, int y)
        {
            int model = Base.ID[GetBaseID(x, y)];
            if (model > 0 && model < 17) return White;
            if (model > 16) return Black;
            return -1;
        }


        public static int GetType(int x, int y)
        {
            if (x < 1 || x > 8) return 0;
            if (y < 1 || y > 8) return 0;
            return Base.ID[GetBaseID(x, y)];
        }


        //------Select On ChessPiece
        public static void SelectBase(int x, int y)
        {
            MainWindow.ClickX = x;
            MainWindow.ClickY = y;
            System.Threading.Thread T = new System.Threading.Thread(Select);
            T.Start();
        }
        public static void Select()
        {
            if (MyTurn)
            {
                if (Clickable)
                {
                    if (IsMovable(PClickX, PClickY, MainWindow.ClickX, MainWindow.ClickY))
                    {
                        SetBase(PClickX, PClickY, MainWindow.ClickX, MainWindow.ClickY);
                        Clickable = false;
                    }
                }
                else
                {
                    PClickX = MainWindow.ClickX;
                    PClickY = MainWindow.ClickY;
                    Clickable = true;
                }
            }
        }

    }
}
