using QuestionnaireDemo.ViewModels;

namespace QuestionnaireDemo.Models
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string QuestionLabel1 { get; set; }
        public string QuestionLabel2 { get; set; }
        public string QuestionLabel3 { get; set; }
        public string GroupName { get; set; }
        public AnswerType AnswerType {get; set;}
        public string Answer { get; set; }
    }

    public enum AnswerType
    {
        Text,
        CheckBox,
        RadioButton
    }
}
