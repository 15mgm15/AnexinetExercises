using System;
using System.Collections.Generic;
using Anexinet.ViewModel.Exercises;
using Xamarin.Forms;

namespace Anexinet.Views.Exercises
{
    public partial class ExerciseOnePage : ContentPage
    {
        public ExerciseOnePage()
        {
            InitializeComponent();
            BindingContext = new ExerciseOneViewModel(Navigation);
        }
    }
}
