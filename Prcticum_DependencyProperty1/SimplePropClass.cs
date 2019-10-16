using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prcticum_DependencyProperty1
{
    public class SimplePropClass : FrameworkElement
    {
        public static DependencyProperty MyDataProperty =
            DependencyProperty.Register(
                "MyData",
                typeof(int),
                typeof(SimplePropClass));

        public int MyData
        {
            get
            {
                return (int)GetValue(MyDataProperty);
            }
            set
            {
                SetValue(MyDataProperty, value);
            }
        }
    }
}
