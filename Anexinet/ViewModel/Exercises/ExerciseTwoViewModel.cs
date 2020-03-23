using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anexinet.Helpers;
using Xamarin.Forms;

namespace Anexinet.ViewModel.Exercises
{
    public class ExerciseTwoViewModel : BaseViewModel
    {
        private string _elements;
        public string Elements
        {
            get
            {
                return _elements;
            }
            set
            {
                SetProperty(ref _elements, value);
                OnPropertyChanged(nameof(Result));
            }
        }

        public string Result
        {
            get
            {
                if(!string.IsNullOrWhiteSpace(Elements))
                {
                    List<int> numbersList = Elements.Split(',')
                      .Where(i => int.TryParse(i, out int num))
                      .Select(int.Parse).ToList();

                    if(numbersList == null || (!numbersList?.Any() ?? false) )
                    {
                        return Strings.InvalidString;
                    }

                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < numbersList.Count; i+=2)
                    {
                        stringBuilder.AppendLine(numbersList[i].ToString());
                    }

                    return stringBuilder.ToString();
                }

                return Strings.InvalidString;
            }
        }

        public ExerciseTwoViewModel(INavigation navigation) : base(navigation)
        {
        }
    }
}
