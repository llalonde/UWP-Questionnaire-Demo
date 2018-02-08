using QuestionnaireDemo.Helpers;
using QuestionnaireDemo.Models;
using System.Collections.ObjectModel;

namespace QuestionnaireDemo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            RadioButtonSelectionCommand = new DelegateCommand(UpdateRadioButtonSelection);
            InitializeQuestions();
        }

        public ObservableCollection<Question> Questions { get; set; }

        private Question currentQuestion;
        public Question CurrentQuestion
        {
            get
            {
                return currentQuestion;
            }
            set
            {
                SetProperty(ref currentQuestion, value);
            }
        }
        
        private void UpdateRadioButtonSelection(object obj)
        {
            if (obj != null)
            {
                CurrentQuestion.Answer = obj.ToString();
            }
        }

        private DelegateCommand radioButtonSelectionCommand;
        public DelegateCommand RadioButtonSelectionCommand
        {
            get { return radioButtonSelectionCommand; }
            set { SetProperty(ref radioButtonSelectionCommand, value); }
        }

        private void InitializeQuestions()
        {
            Questions = new ObservableCollection<Question>();
            Questions.Add(new Question { QuestionText = "What is your name?", AnswerType = AnswerType.Text, Answer = "" });
            Questions.Add(new Question { QuestionText = "Subscribe to mailing list", AnswerType = AnswerType.CheckBox, Answer = "False" });
            Questions.Add(new Question { QuestionText = "Favourite programming language", AnswerType = AnswerType.RadioButton, GroupName="A", QuestionLabel1 = "C#", QuestionLabel2="C++", QuestionLabel3="Java" });
        }
    }
}
