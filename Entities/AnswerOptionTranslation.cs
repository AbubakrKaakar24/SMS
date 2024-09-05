namespace Entities
{
    public class AnswerOptionTranslation
    {
        public int AnswerOptionTranslationID { get; set; }
        public int AnswerOptionID { get; set; }
        public int LanguageID { get; set; }
        public string OptionText { get; set; }
        public AnswerOption AnswerOption { get; set; }
        public Language Language { get; set; }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
