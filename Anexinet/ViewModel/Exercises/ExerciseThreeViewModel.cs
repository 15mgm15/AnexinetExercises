using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anexinet.Helpers;
using Xamarin.Forms;

namespace Anexinet.ViewModel.Exercises
{
    public class ExerciseThreeViewModel : BaseViewModel
    {
        private const string _startStarWithSpace = "* ";
        private const string _endStarWithSpace = " *\n";

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
                return Print();
            }
        }

        public ExerciseThreeViewModel(INavigation navigation) : base(navigation)
        {
        }

        private string Print()
        {
            try
            {
                //TODO: Regex for words separated by comas

                if (!string.IsNullOrWhiteSpace(Elements))
                {
                    List<string> wordsList = Elements.Split(',').ToList();

                    if (wordsList == null || (!wordsList?.Any() ?? false))
                    {
                        return Strings.InvalidString;
                    }

                    StringBuilder stringBuilder = new StringBuilder();

                    // Get the longest word
                    string longestWord = wordsList.OrderByDescending(s => s.Length).First();
                    int longestWordLength = longestWord.Length;
                    int longestWordPlusStars = longestWordLength + 2;

                    // Print the start star line if it is the first iteration of the loop
                    // Note: The star line has the same width of the longest word plus four spaces on the edges
                    stringBuilder.AppendLine(GetStarLine(longestWord));

                    // -----

                    foreach (var item in wordsList)
                    {
                        if(string.IsNullOrWhiteSpace(item))
                        {
                            continue;
                        }

                        // Print the start with space "* "
                        stringBuilder.Append(_startStarWithSpace);
                        // Add the word to the string builder
                        stringBuilder.Append(item);
                        int itemPlusStars = item.Length + 2; ;
                        // Print the remaining spaces base on the longest word.
                        if (item.Length < longestWordLength)
                        {
                            StringBuilder blankSpaces = new StringBuilder();
                            for (int i = itemPlusStars; i < longestWordPlusStars; i++)
                            {
                                blankSpaces.Append(" ");
                            }
                            stringBuilder.Append(blankSpaces);
                        }
                        // And the star with the space at the end! " *"
                        stringBuilder.Append(_endStarWithSpace);
                    }

                    // -----

                    // Print the end star line if it is the last element of the list
                    stringBuilder.AppendLine(GetStarLine(longestWord));

                    return stringBuilder.ToString();
                }

                return Strings.InvalidString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "(*_*) Looks like my algorithm failed.";
        }

        private string GetStarLine(string longestWord)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("**");
            foreach (var character in longestWord)
            {
                stringBuilder.Append("*");
            }
            stringBuilder.Append("**");
            return stringBuilder.ToString();
        }
    }
}
