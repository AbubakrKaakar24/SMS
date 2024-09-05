namespace Entities
{
    internal class SurveyResponseDetail
    {
        public int SurveyResponseDetailID { get; set; }
        public int SurveyResponseID { get; set; }
        public int SurveyInstanceQuestionID { get; set; }
        public int? AnswerOptionID { get; set; }
        public string FreeTextAnswer { get; set; }
        public SurveyResponse SurveyResponse { get; set; }
        public SurveyInstanceQuestion SurveyInstanceQuestion { get; set; }
        public AnswerOption AnswerOption { get; set; }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
