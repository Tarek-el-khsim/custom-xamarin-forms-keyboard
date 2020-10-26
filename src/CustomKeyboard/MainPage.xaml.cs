using CustomKeyboard.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.KeyboardHelper;

namespace CustomKeyboard
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        bool bAlphaNumKeyBoard = false;
        //bAlphaNumKeyBoard = viewModel.BooleanBinding;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            this.Appearing += MainPage_Appearing;
            this.Disappearing += MainPage_Disappearing;
            var viewModel = BindingContext as MainViewModel;



            // Here we implement the action of the Enter button on our custom keyboard
            this.entry1.EnterCommand = new Command(() => this.entry2.Focus());
            this.entry2.EnterCommand = new Command(() => this.entry1.Focus());
            this.entry2.AbcCommand = new Command(() => this.entry2.Focus()); //viewModel.KeyBoardSwitchCommand;
            //this.entry3. = new Command(() => entry2.Keyboard);





        }

        private void MainPage_Disappearing(object sender, EventArgs e)
        {
            SoftKeyboard.Current.VisibilityChanged -= Current_VisibilityChanged;
        }

        private void Current_VisibilityChanged(SoftKeyboardEventArgs e)
        {
            if (e.IsVisible)
            {
                // do your things
                


            }
            else
            {
                // do your things
            }
        }

        private void MainPage_Appearing(object sender, EventArgs e)
        {
            SoftKeyboard.Current.VisibilityChanged += Current_VisibilityChanged;
        }
    }
}