using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using SchoolKeep.ViewModels;

namespace SchoolKeep
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            ((MainWindowViewModel)DataContext).FilePath = @"C:\Users\holde\OneDrive\Documents\INFOTC4400";
            ((MainWindowViewModel)DataContext).HomeworkList = new ObservableCollection<HomeworkAssignmentViewModel>();
            ((MainWindowViewModel)DataContext).SelectedFolder = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            FileSystemInfoViewModel item = (FileSystemInfoViewModel)e.NewValue;
            if (item !=  null)
            {
                var data = ((TreeView)e.OriginalSource).DataContext;
                ((MainWindowViewModel)data).SelectedFolder = item.ToString();
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}