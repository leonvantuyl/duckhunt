﻿using Hunter_DesignPatternsGame;
using Hunter_DesignPatternsGame.Model;
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

namespace Hunter_DesignPatterns.View
{
    /// <summary>
    /// Interaction logic for UnitView.xaml
    /// </summary>
    public partial class UnitView : UserControl
    {
        
        public UnitView(Point pos)
        {            
            InitializeComponent();
            unitContainer.Width = pos.X;
        }        

        internal void render(float dt)
        {            
            //something something
        }        
    }
}
