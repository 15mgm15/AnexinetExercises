using System;
using Xamarin.Forms;

namespace Anexinet.ViewModel.Exercises
{
    public class ExerciseOneViewModel : BaseViewModel
    {
        private DateTime _from;
        public DateTime From
        {
            get
            {
                return _from;
            }
            set
            {
                SetProperty(ref _from, value);
                OnPropertyChanged(nameof(MinimumTo));
                OnPropertyChanged(nameof(Result));
            }
        }

        private DateTime _to;
        public DateTime To
        {
            get
            {
                return _to;
            }
            set
            {
                SetProperty(ref _to, value);
                OnPropertyChanged(nameof(Result));
            }
        }

        public DateTime MinimumTo
        {
            get
            {
                return From.AddDays(1);
            }
        }

        public string Result
        {
            get
            {
                long difference = To.Ticks - From.Ticks;
                double minutes = TimeSpan.FromTicks(difference).TotalMinutes;
                return minutes.ToString();
            }
        }

        public ExerciseOneViewModel(INavigation navigation) : base(navigation)
        {
            From = DateTime.Today;
            To = DateTime.Today.AddDays(1);
        }
    }
}
