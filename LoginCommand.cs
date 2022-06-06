/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInfoSystem
{
    internal class LoginCommand : ICommand
    {
        private LoginVM _ViewModel;

        public event EventHandler CanExecuteChanged
        {
            add {  }
            remove {  }
        }

        public LoginCommand(LoginVM viewModel)
        {
            _ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            // return _ViewModel.IsLoginEnabled();
            return true;
        }

        public void Execute(object parameter)
        {
            _ViewModel.Login();
        }
    }
}

*/
