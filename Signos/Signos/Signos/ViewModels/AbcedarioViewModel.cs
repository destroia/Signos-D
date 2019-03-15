using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using Signos.Views;
using Signos.Models;
using System.Threading.Tasks;

namespace Signos.ViewModels
{
    
     public class AbcedarioViewModel : BaseViewModel
    {
        #region Metodos
        async void  Siguiente(string Abc)
        {
            NextView.Abcedario = Abc;
            await Application.Current.MainPage.Navigation.PushAsync(new ImageAbcView());
            
        }

        private  void A()
        {
            Siguiente("A");
        }
        private void B()
        {
            Siguiente("B");
        }
        private void C()
        {
            Siguiente("C");
        }
        private void D()
        {
            Siguiente("D");
        }
        private void E()
        {
            Siguiente("E");
        }
        private void F()
        {
            Siguiente("F");
        }
        private void G()
        {
            Siguiente("G");
        }
        private void H()
        {
            Siguiente("H");
        }
        private void I()
        {
            Siguiente("I");
        }
        private void J()
        {
            Siguiente("J");
        }
        private void K()
        {
            Siguiente("K");
        }
        private void L()
        {
            Siguiente("L");
        }
        private void M()
        {
            Siguiente("M");
        }
        private void N()
        {
            Siguiente("N");
        }
        private void NN()
        {
            Siguiente("NN");
        }
        private void O()
        {
            Siguiente("O");
        }
        private void P()
        {
            Siguiente("P");
        }
        private void Q()
        {
            Siguiente("Q");
        }
        private void R()
        {
            Siguiente("R");
        }
        private void S()
        {
            Siguiente("S");
        }
        private void T()
        {
            Siguiente("T");
        }
        private void U()
        {
            Siguiente("U");
        }
        private void V()
        {
            Siguiente("V");
        }
        private void W()
        {
            Siguiente("W");
        }
        private void X()
        {
            Siguiente("X");
        }
        private void Y()
        {
            Siguiente("Y");
        }
        private void Z()
        {
            Siguiente("Z");
        }
        #endregion
        #region Commads
        public ICommand ACmd
        {
            get
            {
                return new RelayCommand(A);
            }
        }
        public ICommand BCmd
        {
            get
            {
                return new RelayCommand(B);
            }
        }
        public ICommand CCmd
        {
            get
            {
                return new RelayCommand(C);
            }
        }
        public ICommand DCmd
        {
            get
            {
                return new RelayCommand(D);
            }
        }
        public ICommand ECmd
        {
            get
            {
                return new RelayCommand(E);
            }
        }
        public ICommand FCmd
        {
            get
            {
                return new RelayCommand(F);
            }
        }
        public ICommand GCmd
        {
            get
            {
                return new RelayCommand(G);
            }
        }
        public ICommand HCmd
        {
            get
            {
                return new RelayCommand(H);
            }
        }
        public ICommand ICmd
        {
            get
            {
                return new RelayCommand(I);
            }
        }
        public ICommand JCmd
        {
            get
            {
                return new RelayCommand(J);
            }
        }
        public ICommand KCmd
        {
            get
            {
                return new RelayCommand(K);
            }
        }
        public ICommand LCmd
        {
            get
            {
                return new RelayCommand(L);
            }
        }
        public ICommand MCmd
        {
            get
            {
                return new RelayCommand(M);
            }
        }
        public ICommand NCmd
        {
            get
            {
                return new RelayCommand(N);
            }
        }
        public ICommand NNCmd
        {
            get
            {
                return new RelayCommand(NN);
            }
        }
        public ICommand OCmd
        {
            get
            {
                return new RelayCommand(O);
            }
        }
        public ICommand PCmd
        {
            get
            {
                return new RelayCommand(P);
            }
        }
        public ICommand QCmd
        {
            get
            {
                return new RelayCommand(Q);
            }
        }
        public ICommand RCmd
        {
            get
            {
                return new RelayCommand(R);
            }
        }
        public ICommand SCmd
        {
            get
            {
                return new RelayCommand(S);
            }
        }
        public ICommand TCmd
        {
            get
            {
                return new RelayCommand(T);
            }
        }
        public ICommand UCmd
        {
            get
            {
                return new RelayCommand(U);
            }
        }
        public ICommand VCmd
        {
            get
            {
                return new RelayCommand(V);
            }
        }
        public ICommand WCmd
        {
            get
            {
                return new RelayCommand(W);
            }
        }
        public ICommand XCmd
        {
            get
            {
                return new RelayCommand(X);
            }
        }
        public ICommand YCmd
        {
            get
            {
                return new RelayCommand(Y);
            }
        }
        public ICommand ZCmd
        {
            get
            {
                return new RelayCommand(Z);
            }
        }

       
    }
    #endregion

}
