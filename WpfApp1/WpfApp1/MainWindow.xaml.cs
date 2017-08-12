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

namespace WpfApp1
{

    /// <summary>
    /// How threads update the UI
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Calc_ProgressUpdate(object sender, EventArgs e)
        {
            label1.Refresh(new Action(() => { label1.Content = (e as YourEventArgs).Status; }));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalcClass calc = new CalcClass();
            calc.ProgressUpdate += Calc_ProgressUpdate;
            //Thread test = new Thread(new ThreadStart(LoopingMethod));
            Task test = new Task(calc.testMethod);
            test.Start();           
        }
    }
}
