using System;
using System.Windows.Input;

namespace ilSFVLanguage
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _executeMethod;
        private readonly Func<bool> _canExecuteMethod;
        private bool? _canExecute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action execute)
            : this(execute, null)
        {
            _canExecute = true;
        }

        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _executeMethod = execute;
            _canExecuteMethod = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            bool canExecute = (_canExecuteMethod == null ? true : _canExecuteMethod());
            if (canExecute != _canExecute)
            {
                _canExecute = canExecute;
                var handler = CanExecuteChanged;
                if (handler != null)
                {
                    UIThreadHelper.InvokeIfRequired(() => handler(this, EventArgs.Empty));
                }
            }

            return canExecute;
        }

        public void Execute(object parameter)
        {
            _executeMethod();
        }
    }
}
