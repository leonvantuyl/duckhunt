using Hunter_DesignPatternsGame.Controller;
using Hunter_DesignPatternsGame.Model;
using Hunter_DesignPatterns.View;
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

namespace Hunter_DesignPatterns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainController controller;
        public MainWindow()
        {
            InitializeComponent();
            GamePanel gamePanel = new GamePanel();            
            grid.Children.Add(gamePanel);

            Game model = new Game();
             controller = new MainController(gamePanel, model);
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            controller.startGame();
            grid.Children.Remove(StartGameButton);
        }
    }
}
