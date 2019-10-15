using System.Windows;

namespace WPF_Dependency
{
    class MyFirstControl : FrameworkElement
    {
        public static DependencyProperty DataProperty;
        static MyFirstControl()
        {
            DataProperty = DependencyProperty.Register("Data", typeof(int), typeof(MyFirstControl));
        }
        public int Data
        {
            get
            {
                return (int)GetValue(DataProperty);
            }
            set
            {
                SetValue(DataProperty, value);
            }
        }
    }
}
