using System;
using System.Windows.Input;
using Anexinet.Views.Exercises;
using Xamarin.Forms;

namespace Anexinet.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand NumberOneCommand { get; set; }
        public ICommand NumberTwoCommand { get; set; }
        public ICommand NumberThreeCommand { get; set; }
        public ICommand NumberFourCommand { get; set; }
        public ICommand NumberFiveCommand { get; set; }
        public ICommand NumberSixCommand { get; set; }
        public ICommand NumberSevenCommand { get; set; }

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
            NumberOneCommand = new Command(ExecuteNumberOneCommand);
            NumberTwoCommand = new Command(ExecuteNumberTwoCommand);
            NumberThreeCommand = new Command(ExecuteNumberThreeCommand);
            NumberFourCommand = new Command(ExecuteNumberFourCommand);
            NumberFiveCommand = new Command(ExecuteNumberFiveCommand);
            NumberSixCommand = new Command(ExecuteNumberSixCommand);
            NumberSevenCommand = new Command(ExecuteNumberSevenCommand);
        }

        private void ExecuteNumberOneCommand(object obj)
        {
            Navigation.PushAsync(new ExerciseOnePage());
        }

        private void ExecuteNumberTwoCommand(object obj)
        {
            Navigation.PushAsync(new ExerciseTwoPage());
        }

        private void ExecuteNumberThreeCommand(object obj)
        {
            Navigation.PushAsync(new ExerciseThreePage());
        }

        private void ExecuteNumberFourCommand(object obj)
        {
            Navigation.PushAsync(new ExerciseFourPage());
        }

        private void ExecuteNumberFiveCommand(object obj)
        {
            Navigation.PushAsync(new ExerciseFivePage());
        }

        private void ExecuteNumberSixCommand(object obj)
        {
            Navigation.PushAsync(new ExerciseSixPage());
        }

        private void ExecuteNumberSevenCommand(object obj)
        {
            Navigation.PushAsync(new ExerciseSevenPage());
        }
    }
}
