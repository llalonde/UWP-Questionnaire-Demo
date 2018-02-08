using QuestionnaireDemo.Helpers;
using QuestionnaireDemo.Models;
using System.Collections.ObjectModel;
using System.Linq;

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

                if (Questions.Count == 1)
                {
                    switch (CurrentQuestion.Answer)
                    {
                        case "C#":
                            AddCSharpQuestions();
                            break;
                        case "Java":
                            AddJavaQuestions();
                            break;
                        default:
                            AddCPlusPlusQuestions();
                            break;
                    }
                }
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
            Questions.Add(new Question { QuestionText = "Favourite programming language", AnswerType = AnswerType.RadioButton, GroupName = "A", QuestionLabel1 = "C#", QuestionLabel2 = "C++", QuestionLabel3 = "Java" });

            CurrentQuestion = Questions.First();
        }

        private void AddCSharpQuestions()
        {
            Questions.Add(new Question { QuestionText = "Which popular NuGet packages do you use?", QuestionLabel1 = "Azure", QuestionLabel2 = "Newtonsoft.JSON", QuestionLabel3 = "Other libraries", AnswerType = AnswerType.CheckBox });
            Questions.Add(new Question { QuestionText = "Which source control do you use?", QuestionLabel1 = "VSTS", QuestionLabel2 = "Git", QuestionLabel3 = "Subversion", AnswerType = AnswerType.CheckBox });
            Questions.Add(new Question { QuestionText = "Favourite ice cream", AnswerType = AnswerType.RadioButton, GroupName = "B", QuestionLabel1 = "Chocolate", QuestionLabel2 = "Vanilla", QuestionLabel3 = "Strawberry" });
            Questions.Add(new Question { QuestionText = "Favourite tv show", AnswerType = AnswerType.RadioButton, GroupName = "C", QuestionLabel1 = "Game of Thrones", QuestionLabel2 = "Walking Dead", QuestionLabel3 = "Flintstones" });

        }

        private void AddJavaQuestions()
        {
            Questions.Add(new Question { QuestionText = "I use Gradle for building things", AnswerType = AnswerType.CheckBox });
        }

        private void AddCPlusPlusQuestions()
        {
            Questions.Add(new Question { QuestionText = "I have mastered the use of pointers", AnswerType = AnswerType.CheckBox });
        }
    }
}
