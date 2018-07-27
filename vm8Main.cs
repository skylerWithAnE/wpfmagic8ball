using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    class vm8Main : vmBase
    {
        private string _UserInput = string.Empty;
        public string UserInput
        {
            get => _UserInput;
            set
            {
                if (_UserInput != value)
                {
                    _UserInput = value;
                    OnPropertyChanged("UserInput");
                }
            }
        }

        private List<string> _Answers = new List<string>() {"Yes", "No", "Maybe", "Someday"};

        private string _Answer = "Ask Question";
        public string Answer
        {
            get => _Answer;
            set
            {
                if (_Answer != value)
                {
                    _Answer = value;
                    OnPropertyChanged("Answer");
                }
            }
        }

        private ICommand _AskCommand;
        
        public ICommand AskCommand
        {
            get
            {
                if(_AskCommand == null)
                {
                    _AskCommand = new RelayCommand(/*OnQuestionAsked);*/
                    (o) =>
                    {
                        var r = new Random();
                        var i = r.Next(_Answers.Count);
                        Answer = _Answers[i];
                    });
                }
                return _AskCommand;
            }
        }

        //private void OnQuestionAsked(object o = null)
        //{
        //    var r = new Random();
        //    var i = r.Next(_Answers.Count);
        //    Answer = _Answers[i];
        //}
        
    }
}
