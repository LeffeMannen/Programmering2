using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Slutprojekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public static int ClickX = 0;
        public static int ClickY = 0;

        public static Image[] ChessImages = new Image[65];
        public static string[] ImageName = new string[65];

        public MainWindow()
        {
            InitializeComponent();


            //Chess images
            {

                for (int i = 1; i < 9; i++) ImageName[i] = "Chess_PawnW.png";

                ImageName[9] = "Chess_RookW.png";
                ImageName[10] = "Chess_RookW.png";
                ImageName[11] = "Chess_KnightW.png";
                ImageName[12] = "Chess_KnightW.png";
                ImageName[13] = "Chess_BishopW.png";
                ImageName[14] = "Chess_BishopW.png";
                ImageName[15] = "Chess_QueenW.png";
                ImageName[16] = "Chess_KingW.png";


                for (int i = 17; i < 25; i++) ImageName[i] = "Chess_PawnB.png";

                ImageName[25] = "Chess_RookB.png";
                ImageName[26] = "Chess_RookB.png";
                ImageName[27] = "Chess_KnightB.png";
                ImageName[28] = "Chess_KnightB.png";
                ImageName[29] = "Chess_BishopB.png";
                ImageName[30] = "Chess_BishopB.png";
                ImageName[31] = "Chess_QueenB.png";
                ImageName[32] = "Chess_KingB.png";


                ChessImages[2] = Ix1y1;
                ChessImages[3] = Ix1y2;
                ChessImages[4] = Ix1y3;
                ChessImages[5] = Ix1y4;
                ChessImages[6] = Ix1y5;
                ChessImages[7] = Ix1y6;
                ChessImages[8] = Ix1y7;
                ChessImages[9] = Ix1y8;

                ChessImages[10] = Ix2y1;
                ChessImages[11] = Ix2y2;
                ChessImages[12] = Ix2y3;
                ChessImages[13] = Ix2y4;
                ChessImages[14] = Ix2y5;
                ChessImages[15] = Ix2y6;
                ChessImages[16] = Ix2y7;
                ChessImages[17] = Ix2y8;

                ChessImages[18] = Ix3y1;
                ChessImages[19] = Ix3y2;
                ChessImages[20] = Ix3y3;
                ChessImages[1] = Ix3y4;
                ChessImages[1] = Ix3y5;
                ChessImages[1] = Ix3y6;
                ChessImages[1] = Ix3y7;
                ChessImages[1] = Ix3y8;

                ChessImages[1] = Ix4y1;
                ChessImages[1] = Ix4y2;
                ChessImages[1] = Ix4y3;
                ChessImages[1] = Ix4y4;
                ChessImages[1] = Ix4y5;
                ChessImages[1] = Ix4y6;
                ChessImages[1] = Ix4y7;
                ChessImages[1] = Ix4y8;

                ChessImages[1] = Ix5y1;
                ChessImages[1] = Ix5y2;
                ChessImages[1] = Ix5y3;
                ChessImages[1] = Ix5y4;
                ChessImages[1] = Ix5y5;
                ChessImages[1] = Ix5y6;
                ChessImages[1] = Ix5y7;
                ChessImages[1] = Ix5y8;

                ChessImages[1] = Ix6y1;
                ChessImages[1] = Ix6y2;
                ChessImages[1] = Ix6y3;
                ChessImages[1] = Ix6y4;
                ChessImages[1] = Ix6y5;
                ChessImages[1] = Ix6y6;
                ChessImages[1] = Ix6y7;
                ChessImages[1] = Ix6y8;

                ChessImages[1] = Ix7y1;
                ChessImages[1] = Ix7y2;
                ChessImages[1] = Ix7y3;
                ChessImages[1] = Ix7y4;
                ChessImages[1] = Ix7y5;
                ChessImages[1] = Ix7y6;
                ChessImages[1] = Ix7y7;
                ChessImages[1] = Ix7y8;

                ChessImages[1] = Ix8y1;
                ChessImages[1] = Ix8y2;
                ChessImages[1] = Ix8y3;
                ChessImages[1] = Ix8y4;
                ChessImages[1] = Ix8y5;
                ChessImages[1] = Ix8y6;
                ChessImages[1] = Ix8y7;
                ChessImages[1] = Ix8y8;
            }
            StartGame();
        }

        public static void StartGame()
        {
            int x = 0;
            int y = 0;

            x = 1;
            y = 2;
            int type = Game.Piece.White.Pawn[0];

            Game.Base.ID[Game.GetBaseID(x, y)] = type;
            Game.SetImage(MainWindow.ChessImages[Game.GetBaseID(x, y)], type);
        }


        private void x1y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 1);
        }
        private void x1y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 2);
        }
        private void x1y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 3);
        }
        private void x1y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 4);
        }
        private void x1y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 5);
        }
        private void x1y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 6);
        }
        private void x1y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 7);
        }
        private void x1y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 8);
        }
        private void x2y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 1);
        }
        private void x2y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 2);
        }
        private void x2y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 3);
        }
        private void x2y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 4);
        }
        private void x2y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 5);
        }
        private void x2y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 6);
        }
        private void x2y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 7);
        }
        private void x2y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 8);
        }
        private void x3y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 1);
        }
        private void x3y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 2);
        }
        private void x3y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 3);
        }
        private void x3y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 4);
        }
        private void x3y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 5);
        }
        private void x3y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 6);
        }
        private void x3y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 7);
        }
        private void x3y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 8);
        }
        private void x4y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 1);
        }
        private void x4y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 2);
        }
        private void x4y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 3);
        }
        private void x4y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 4);
        }
        private void x4y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 5);
        }
        private void x4y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 6);
        }
        private void x4y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 7);
        }
        private void x4y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 8);
        }
        private void x5y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 1);
        }
        private void x5y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 2);
        }
        private void x5y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 3);
        }
        private void x5y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 4);
        }
        private void x5y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 5);
        }
        private void x5y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 6);
        }
        private void x5y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 7);
        }
        private void x5y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 8);
        }
        private void x6y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 1);
        }
        private void x6y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 2);
        }
        private void x6y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 3);
        }
        private void x6y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 4);
        }
        private void x6y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 5);
        }
        private void x6y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 6);
        }
        private void x6y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 7);
        }
        private void x6y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 8);
        }
        private void x7y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 1);
        }
        private void x7y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 2);
        }
        private void x7y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 3);
        }
        private void x7y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 4);
        }
        private void x7y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 5);
        }
        private void x7y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 6);
        }
        private void x7y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 7);
        }
        private void x7y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 8);
        }
        private void x8y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 1);
        }
        private void x8y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 2);
        }
        private void x8y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 3);
        }
        private void x8y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 4);
        }
        private void x8y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 5);
        }
        private void x8y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 6);
        }
        private void x8y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 7);
        }
        private void x8y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 8);
        }
    }
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

        public static class Way
        {
            public static int Up = 1;
            public static int Down = 2;
            public static int Right = 3;
            public static int Left = 4;
            public static int UpRight = 5;
            public static int UpLeft = 6;
            public static int DownRight = 7;
            public static int DownLeft = 8;
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