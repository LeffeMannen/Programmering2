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
            int WPawn1 = Game.Piece.White.Pawn[0];

            Game.Base.ID[Game.GetBaseID(x, y)] = WPawn1;
            Game.SetImage(MainWindow.ChessImages[Game.GetBaseID(x, y)], WPawn1);

        }

        #region Click On Chess Button
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
        #endregion

        #region Black Out
        private void Black1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black16_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region White Out
        private void White1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void White16_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}