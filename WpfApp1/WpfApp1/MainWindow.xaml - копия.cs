using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    public static class ExtensionMethods
    {
        private static Action EmptyDelegate = delegate () { };

        public static void Refresh(this UIElement uiElement, Action action)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, action);
        }
    }
   

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoopingMethod()
        {
            for (int i = 0; i < 10; i++)
            {                
                label1.Refresh(new Action(() => { label1.Content = i.ToString(); }));
                Thread.Sleep(500);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Thread test = new Thread(new ThreadStart(LoopingMethod));
            Task test = new Task(LoopingMethod);
            test.Start();
            
        }
    }
}
