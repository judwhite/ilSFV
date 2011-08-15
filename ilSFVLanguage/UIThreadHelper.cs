using System;
using System.Windows;

namespace ilSFVLanguage
{
    public static class UIThreadHelper
    {
        public static void Invoke(Action action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            if (Application.Current.Dispatcher.CheckAccess())
                action();
            else
                Application.Current.Dispatcher.BeginInvoke(action);
        }

        public static bool InvokeIfRequired(Action action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            if (!Application.Current.Dispatcher.CheckAccess())
            {
                Application.Current.Dispatcher.BeginInvoke(action);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
