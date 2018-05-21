using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            mViewModel.CalcHash();
        }

        private void FilePath_PreviewDragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void FilePath_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }

        private void FilePath_Drop(object sender, DragEventArgs e)
        {
            DataObject dataObject = e.Data as DataObject;
            if(dataObject.ContainsFileDropList())
            {
                StringCollection fileNames = dataObject.GetFileDropList();

                if(fileNames.Count > 0)
                {
                    FilePath.Text = fileNames[0];
                    FilePath.Focus();
                }
            }
        }
    }
}
