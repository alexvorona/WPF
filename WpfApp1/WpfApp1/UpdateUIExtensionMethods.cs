using System;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// How threads update the UI
    /// </summary>
    public static class UpdateUIExtensionMethods
    {
        private static Action EmptyDelegate = delegate () { };

        public static void Refresh(this UIElement uiElement, Action action)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, action);
        }
    }
}
