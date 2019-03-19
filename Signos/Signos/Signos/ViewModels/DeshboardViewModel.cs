using GalaSoft.MvvmLight.Command;
using Signos.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Signos.ViewModels
{
    public class DeshboardViewModel : BaseViewModel
    {
        object AdcDeshboard;
        public ICommand AbcCmd
        {
            get{
                return new RelayCommand(Abc);
            }
        }

        public object AdcDeshboard1 { get => AdcDeshboard; set { AdcDeshboard = value; OnPropertyChanged(); } }

        private async void Abc()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AbcedarioView(),true);
        }
    }
}
