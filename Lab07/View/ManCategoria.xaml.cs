﻿using Lab07.ViewModel;
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
using System.Windows.Shapes;

namespace Lab07.View
{
    /// <summary>
    /// Interaction logic for ManCategoria.xaml
    /// </summary>
    public partial class ManCategoria : Window
    {
        ManCategoriaViewModel viewModel;
        public ManCategoria()
        {
            InitializeComponent();
            viewModel = new ManCategoriaViewModel();
            this.DataContext = viewModel;
        }
    }
}
