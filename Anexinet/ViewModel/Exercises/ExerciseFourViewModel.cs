using System;
using System.Collections.Generic;
using System.Text;
using Anexinet.Helpers;
using Xamarin.Forms;

namespace Anexinet.ViewModel.Exercises
{
    public class ExerciseFourViewModel : BaseViewModel
    {
        private string _number;
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                SetProperty(ref _number, value);
                OnPropertyChanged(nameof(Result));
            }
        }

        public string Result
        {
            get
            {
                if(int.TryParse(Number, out int NumberValue))
                {
                    if(NumberValue > 35)
                    {
                        return "That is a lot of numbers!";
                    }

                    string n = "1";
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.AppendLine(n);
                    for (int i = 0; i < NumberValue; i++)
                    {
                        n = LookAndSay(n);
                        stringBuilder.AppendLine(n);
                    }
                    return stringBuilder.ToString();
                }

                return Strings.InvalidString;
            }
        }

        public ExerciseFourViewModel(INavigation navigation) : base(navigation)
        {

        }

        string LookAndSay(string x)
        {
            string result = "";
            string t = x.ToString();
            int numberCount = 0;
            char number = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (number == t[i])
                {
                    numberCount++;
                }
                else
                {
                    result += numberCount.ToString() + number;
                    number = t[i];
                    numberCount = 1;
                }
            }
            result += numberCount.ToString() + number;

            return result;
        }
    }
}
