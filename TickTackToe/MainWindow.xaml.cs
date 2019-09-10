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
using BoardPaperGames;

namespace TickTackToeGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int move_num = 1;
        private BoardPaperGames.TickTackToe ttt = new BoardPaperGames.TickTackToe();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (move_num % 2 == 0)
            {
                ((Button)sender).Content= "Zero";
                //ttt.SetZero(row, column);
            }
            else
            {
                ((Button)sender).Content = "Cross";
                //ttt.SetCross(row, column);
            }
            //ttt.CheckWin(row, column);
        }
    }
}
