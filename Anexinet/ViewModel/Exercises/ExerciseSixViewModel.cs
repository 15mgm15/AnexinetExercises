using System;
using Anexinet.Helpers;
using Xamarin.Forms;

namespace Anexinet.ViewModel.Exercises
{
    public class ExerciseSixViewModel : BaseViewModel
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
                if (int.TryParse(Number, out int NumberValue))
                {
                    if ((NumberValue < 0) || (NumberValue > 3999))
                    {
                        return Strings.InvalidNumber;
                    }
                    else
                    {
                        return ConvertToRoman(NumberValue);
                    }
                }

                return Strings.InvalidNumber;
            }
        }

        public ExerciseSixViewModel(INavigation navigation) : base(navigation)
        {
        }

        private string ConvertToRoman(int numberValue)
        {
            if (numberValue < 1) return string.Empty;
            if (numberValue >= 1000) return "M"     + ConvertToRoman(numberValue - 1000);
            if (numberValue >= 900) return  "CM"    + ConvertToRoman(numberValue - 900);
            if (numberValue >= 500) return  "D"     + ConvertToRoman(numberValue - 500);
            if (numberValue >= 400) return  "CD"    + ConvertToRoman(numberValue - 400);
            if (numberValue >= 100) return  "C"     + ConvertToRoman(numberValue - 100);
            if (numberValue >= 90) return   "XC"    + ConvertToRoman(numberValue - 90);
            if (numberValue >= 50) return   "L"     + ConvertToRoman(numberValue - 50);
            if (numberValue >= 40) return   "XL"    + ConvertToRoman(numberValue - 40);
            if (numberValue >= 10) return   "X"     + ConvertToRoman(numberValue - 10);
            if (numberValue >= 9) return    "IX"    + ConvertToRoman(numberValue - 9);
            if (numberValue >= 5) return    "V"     + ConvertToRoman(numberValue - 5);
            if (numberValue >= 4) return    "IV"    + ConvertToRoman(numberValue - 4);
            if (numberValue >= 1) return    "I"     + ConvertToRoman(numberValue - 1);
            return Strings.InvalidNumber;
        }
    }
}
