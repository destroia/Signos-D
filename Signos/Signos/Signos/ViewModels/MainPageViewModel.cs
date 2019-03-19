using GalaSoft.MvvmLight.Command;
using Signos.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Signos.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        public ICommand AbcCmd
        {
            get
            {
                return new RelayCommand(Abc);
            }
        }

        private void Abc()
        {
            App.Current.MainPage.Navigation.PushAsync(new AbcedarioView());
        }
    }
}
