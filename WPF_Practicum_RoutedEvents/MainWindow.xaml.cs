using System.Windows;
using System.Windows.Controls;

namespace WPF_Practicum_RoutedEvents
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
        public void ExtraButton_MyButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as Button).Name);
        }
    }
}
