using System;
using System.Collections.Generic;
using Anexinet.ViewModel.Exercises;
using Xamarin.Forms;

namespace Anexinet.Views.Exercises
{
    public partial class ExerciseThreePage : ContentPage
    {
        public ExerciseThreePage()
        {
            InitializeComponent();
            BindingContext = new ExerciseThreeViewModel(Navigation);

            TheText.FontFamily = Device.RuntimePlatform == Device.Android ? "monospace" : "Courier";
        }
    }
}
