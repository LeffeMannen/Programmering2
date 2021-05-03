using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Slutprojekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserControl gamePlan;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void content_Loaded(object sender, RoutedEventArgs e)
        {
            gamePlan = new UserControl();


            Grid DynamicGrid = new Grid();

            for (int i = 0; i < 11; i++)
            {
                var row = new RowDefinition();
                row.Height = new GridLength(60);
                DynamicGrid.RowDefinitions.Add(row);

                var col = new ColumnDefinition();
                col.Width = new GridLength(60);
                DynamicGrid.ColumnDefinitions.Add(col);

            }

            for (int i = 4; i < 7; i++)
            {
                for (int j = 0; j < 12; j++)
                {

                    Ellipse rec = new Ellipse()
                    {
                        Fill = Brushes.White,
                        Stroke = Brushes.Black,
                        Width = 58,
                        Height = 58,
                    };
                    Grid.SetRow(rec, i);
                    Grid.SetColumn(rec, j);
                    DynamicGrid.Children.Add(rec);

                }
            }

            for (int i = 0; i < 12; i++)
            {
                for (int j = 4; j < 7; j++)
                {
                    Ellipse rec = new Ellipse()
                    {
                        Fill = Brushes.White,
                        Stroke = Brushes.Black,
                        Width = 58,
                        Height = 58,
                    };
                    Grid.SetRow(rec, i);
                    Grid.SetColumn(rec, j);
                    DynamicGrid.Children.Add(rec);

                }
            }





            gamePlan.Content = DynamicGrid;
            content.Children.Add(gamePlan);


        }
    }
}
