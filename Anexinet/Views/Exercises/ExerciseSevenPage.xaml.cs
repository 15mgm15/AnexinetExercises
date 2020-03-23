using System;
using System.Collections.Generic;
using Anexinet.ViewModel.Exercises;
using Xamarin.Forms;

namespace Anexinet.Views.Exercises
{
    public partial class ExerciseSevenPage : ContentPage
    {
        public ExerciseSevenPage()
        {
            InitializeComponent();
            BindingContext = new ExerciseSevenViewModel(Navigation);
        }
    }
}
