using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfApp1
{
    /// <summary>
    /// DependencyProperty
    /// </summary>
    public class MyButton : ButtonBase
    {
        // The dependency property
        public static readonly DependencyProperty IsDefaultProperty;

        static MyButton()
        {
            // Register the property
            MyButton.IsDefaultProperty = DependencyProperty.Register("IsDefault",
              typeof(bool), typeof(MyButton),
              new FrameworkPropertyMetadata(false,
              new PropertyChangedCallback(OnIsDefaultChanged)));
        }

        // A .NET property wrapper (optional)
        public bool IsDefault
        {
            get { return (bool)GetValue(IsDefaultProperty); }
            set { SetValue(IsDefaultProperty, value); }
        }

        // A property changed callback (optional)
        private static void OnIsDefaultChanged(
          DependencyObject o, DependencyPropertyChangedEventArgs e)
        { }
    }
}
