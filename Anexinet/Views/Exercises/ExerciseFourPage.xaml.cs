using System;
using System.Collections.Generic;
using Anexinet.ViewModel.Exercises;
using Xamarin.Forms;

namespace Anexinet.Views.Exercises
{
    public partial class ExerciseFourPage : ContentPage
    {
        public ExerciseFourPage()
        {
            InitializeComponent();
            BindingContext = new ExerciseFourViewModel(Navigation);
        }
    }
}
