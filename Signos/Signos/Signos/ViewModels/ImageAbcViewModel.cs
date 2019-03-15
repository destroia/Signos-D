using Signos.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Signos.ViewModels
{
    public class ImageAbcViewModel :BaseViewModel
    {
        string image;
        char letra;
        public ImageAbcViewModel()
        {
            string abc = NextView.Abcedario;
            if (abc == "NN")
            {
                abc = "Ñ";
            }
            Image = abc + ".jpg";
            Letra = Convert.ToChar(abc);
        }

        public string Image { get => image; set { image = value; OnPropertyChanged(); } }

        public char Letra { get => letra; set { letra = value; OnPropertyChanged(); } }
    }
}
