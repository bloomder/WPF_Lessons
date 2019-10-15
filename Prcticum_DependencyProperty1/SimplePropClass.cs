using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prcticum_DependencyProperty1
{
    class SimplePropClass : FrameworkElement
    {
        static FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata(
            new PropertyChangedCallback(ChangedCallbackMethod),
            new CoerceValueCallback(CoerceValueCallbackMethod));

        public static DependencyProperty MyDataProperty =
            DependencyProperty.Register(
                "MyData",
                typeof(int),
                typeof(SimplePropClass),
                metadata,
                new ValidateValueCallback(ValidateValueCallbackMeyhod));

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

        private static bool ValidateValueCallbackMeyhod(object value)
        {
            if ((int)value < 0) return false;
            return true;
        }

        private static object CoerceValueCallbackMethod(DependencyObject d, object baseValue)
        {
            if ((int)baseValue <= 100) return baseValue;
            return 100;
        }

        private static void ChangedCallbackMethod(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}
