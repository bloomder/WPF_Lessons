using System.Windows;
using System.Windows.Controls;

namespace WPF_Practicum_RoutedEvents
{ 
    public class ExtraButton : Button
    {
        static RoutedEvent MyButtonClickEvent;
        static ExtraButton()
        {
        MyButtonClickEvent = EventManager.RegisterRoutedEvent("MyButtonClick",
            RoutingStrategy.Tunnel,
            typeof(RoutedEventHandler),
            typeof(ExtraButton));
        }
        public event RoutedEventHandler MyButtonClick
        {
            add { AddHandler(MyButtonClickEvent, value); }
            remove { RemoveHandler(MyButtonClickEvent, value); }
        }
        protected override void OnClick()
        {
            base.OnClick();
            RoutedEventArgs args = new RoutedEventArgs(ExtraButton.MyButtonClickEvent, this);
            RaiseEvent(args);
        }
    }
}
