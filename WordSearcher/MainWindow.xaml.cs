﻿using System;
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

namespace WordSearcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// DO NOT MODIFY THIS FILE
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// DO NOT MODIFY THIS FILE
        /// </summary>
        /// <param name="vm"></param>
        public MainWindow(ITextViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
