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

namespace KHash
{
    /// <summary>
    /// Interaction logic for FileHashView.xaml
    /// </summary>
    public partial class FileHashView : UserControl
    {
        FileHashViewModel mViewModel;

        public FileHashView()
        {
            InitializeComponent();

            mViewModel = new FileHashViewModel();
            this.DataContext = mViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
