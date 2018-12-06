using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commands
{
    public class CloseCommand : ICommand
    {
        public CloseCommand(MainWindow wnd)
        {
            this.Wnd = wnd;
        }

        public MainWindow Wnd { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.Wnd.Close();
        }
    }
}
