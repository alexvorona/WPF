using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class YourEventArgs : EventArgs
    {
        //Put any property that you want to pass back to UI here.
        public string Status;
        public YourEventArgs(string status)
        {
            Status = status;
        }
                

    }
    class CalcClass
    {
        public event EventHandler ProgressUpdate;       

        public void testMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                if (ProgressUpdate != null)
                    ProgressUpdate(this, new YourEventArgs(i.ToString()));                
                Thread.Sleep(500);
            }            
        }
    }
}
