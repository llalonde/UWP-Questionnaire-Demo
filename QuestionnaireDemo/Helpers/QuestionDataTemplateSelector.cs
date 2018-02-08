using QuestionnaireDemo.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace QuestionnaireDemo.Helpers
{
    public class QuestionDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TextBoxTemplate { get; set; }
        public DataTemplate CheckBoxTemplate { get; set; }
        public DataTemplate RadioButtonTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is Question)
            {
                Question question = item as Question;
                if (question.AnswerType == AnswerType.CheckBox)
                {
                    return CheckBoxTemplate;
                }
                else if (question.AnswerType == AnswerType.RadioButton)
                {
                    return RadioButtonTemplate;
                }
            }

            return TextBoxTemplate;
        }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            return base.SelectTemplateCore(item);
        }
    }
}
