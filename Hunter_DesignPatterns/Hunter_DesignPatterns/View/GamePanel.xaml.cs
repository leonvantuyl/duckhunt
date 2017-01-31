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
using Hunter_DesignPatternsGame.Controller;

namespace Hunter_DesignPatterns.View
{
    /// <summary>
    /// Interaction logic for GamePanel.xaml
    /// </summary>
    public partial class GamePanel : UserControl
    {
        private MainController controller;
        private List<UnitView> unitViews;
        public GamePanel()
        {
            unitViews = new List<UnitView>();
            InitializeComponent();
            addUnitView(new Point { X = 50, Y = 50 });
            addUnitView(new Point { X = 150, Y = 150 });
        }

        public void render(float dt)
        {
            foreach (UnitView unit in unitViews)
            {
                unit.render(dt);
            }
        }

        internal void addController(MainController controller)
        {
            this.controller = controller;
        }

        public void addUnitView(Point pos)
        {
            UnitView unitView = new UnitView(pos);
            unitViews.Add(unitView);
            gameCanvas.Children.Add(unitView);
        }

        private void gameCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(gameCanvas);        
            controller.addAction(point);
        }
    }
}
