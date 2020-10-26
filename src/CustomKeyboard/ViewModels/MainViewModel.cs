using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CustomKeyboard.ViewModels
{
    public class MainViewModel : ViewModelBase 
    {
        private bool booleanBinding;
        public bool BooleanBinding
        {
            get
            {
                return booleanBinding;
            }

            set
            {
                if (booleanBinding != value)
                {
                    booleanBinding = value;
                    NotifyPropertyChanged("BooleanBinding");
                }
            }
            
        }
        public ICommand KeyBoardSwitchCommand { get; private set; }

        public MainViewModel()
        {
            booleanBinding = false;

            KeyBoardSwitchCommand = new Command(async () => await SwitchKeyBoacd());

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async Task SwitchKeyBoacd()
        {
            booleanBinding = booleanBinding ? false : true; 
        }
    }
}
