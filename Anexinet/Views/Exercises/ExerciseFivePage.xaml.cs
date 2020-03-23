using System;
using System.Collections.Generic;
using Anexinet.ViewModel.Exercises;
using Xamarin.Forms;

namespace Anexinet.Views.Exercises
{
    public partial class ExerciseFivePage : ContentPage
    {
        public ExerciseFivePage()
        {
            InitializeComponent();
            BindingContext = new ExerciseFiveViewModel(Navigation);
        }
    }
}
