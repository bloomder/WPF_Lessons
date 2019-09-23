using System;
using System.Windows;

namespace TextBox
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

        private void txt_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (txtSelection == null) return;
            txtSelection.Text = String.Format(
                "Выбрано с позиции {0}; количество символов -- {1}; текст -- \"{2}\"",
                txt.SelectionStart,
                txt.SelectionLength,
                txt.SelectedText);
        }
    }
}
