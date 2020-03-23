using System;
using System.Collections.Generic;
using Anexinet.ViewModel.Exercises;
using Xamarin.Forms;

namespace Anexinet.Views.Exercises
{
    public partial class ExerciseTwoPage : ContentPage
    {
        public ExerciseTwoPage()
        {
            InitializeComponent();
            BindingContext = new ExerciseTwoViewModel(Navigation);
        }
    }
}
