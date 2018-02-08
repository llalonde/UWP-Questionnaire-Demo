using QuestionnaireDemo.ViewModels;

namespace QuestionnaireDemo.Models
{
    public class Question
    {
        public string QuestionText { get; set; }

        public AnswerType AnswerType { get; set; }
        public string Answer { get; set; }

        //Group name for Radio Button questions
        public string GroupName { get; set; }

        //Hack for handling data template with multiple radio buttons or check boxes
        public string QuestionLabel1 { get; set; }
        public string QuestionLabel2 { get; set; }
        public string QuestionLabel3 { get; set; }

        //Hack for handling data template with check box answers
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
    }

    public enum AnswerType
    {
        Text,
        CheckBox,
        RadioButton
    }
}
