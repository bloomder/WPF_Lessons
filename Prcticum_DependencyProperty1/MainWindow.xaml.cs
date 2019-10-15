using System.Windows;

namespace Prcticum_DependencyProperty1
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
        public string TextBlock_Text
        {
            set
            {
                TextBlock1.Text = value;
            }
        }
    }
}
