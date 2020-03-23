using System;
using System.Collections.Generic;
using Anexinet.ViewModel.Exercises;
using Xamarin.Forms;

namespace Anexinet.Views.Exercises
{
    public partial class ExerciseSixPage : ContentPage
    {
        public ExerciseSixPage()
        {
            InitializeComponent();
            BindingContext = new ExerciseSixViewModel(Navigation);
        }
    }
}
