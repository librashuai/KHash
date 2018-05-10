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

namespace KHash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.LeftMenu.Visibility = Visibility.Hidden;
            SwitchContent(new FileHashView());
        }

        private void WindowMove(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            this.LeftMenu.Visibility = this.LeftMenu.IsVisible?Visibility.Hidden:Visibility.Visible;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SwitchContent(UserControl content)
        {
            this.ContentContainer.Children.Clear();
            this.ContentContainer.Children.Add(content);

            this.LeftMenu.Visibility = Visibility.Hidden;
        }

        private void FileMenu_Click(object sender, RoutedEventArgs e)
        {
            SwitchContent(new FileHashView());
        }

        private void StringMenu_Click(object sender, RoutedEventArgs e)
        {
            SwitchContent(new StringHashView());
        }
    }
}
