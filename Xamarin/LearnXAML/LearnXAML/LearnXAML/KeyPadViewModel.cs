using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LearnXAML
{
    class KeyPadViewModel : INotifyPropertyChanged
    {
        string inputString = "";
        string displayText = "";
        char[] specialChars = { '*', '#' };

        public event PropertyChangedEventHandler PropertyChanged;

        public KeyPadViewModel()
        {
            AddCharCommand = new Command<string>((key) =>
            {
                InputString += key;
            });

            DeleteCharCommand = new Command(() =>
            {
                InputString = InputString.Substring(0, InputString.Length - 1);
            }, 
            () =>
            {
                return InputString.Length > 0;
            });
        }

        public string InputString
        {
            protected set
            {
                if (inputString != value)
                {
                    inputString = value;
                    OnPropertyChanged("InputString");
                    DisplayText = FormatText(inputString);

                    ((Command)DeleteCharCommand).ChangeCanExecute();
                }
            }
            get
            {
                return inputString;
            }
        }

        public ICommand AddCharCommand { protected set; get; }
        public ICommand DeleteCharCommand {protected set; get;}

        private string FormatText(string str)
        {
            bool hasNonNumbers = str.IndexOfAny(specialChars) != -1;
            string formatted = str;

            if(hasNonNumbers || str.Length < 4 || str.Length > 10)
            {

            }else if(str.Length < 8){
                formatted = String.Format("{0}-{1}", str.Substring(0, 3), str.Substring(3));
            }
            else
            {
                formatted = String.Format("({0}) {1}-{2}", str.Substring(0, 3), str.Substring(3, 3), str.Substring(6));
            }
            return formatted;
        }

        public string DisplayText
        {
            protected set
            {
                if(displayText != value)
                {
                    displayText = value;
                    OnPropertyChanged("DisplayText");
                }

            }
            get
            {
                return displayText;
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
