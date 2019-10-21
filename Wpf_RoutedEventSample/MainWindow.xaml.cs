using System.Windows;
using System.Windows.Controls;

namespace Wpf_RoutedEventSample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExtraButton_MyButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as Button).Name);
        }
    }
}
