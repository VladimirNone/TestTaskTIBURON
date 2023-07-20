namespace TestTaskTIBURON.Core.Entities
{
    public class Interview : Entity
    {
        public DateTime WasStater { get; set; }
        public string UserId { get; set; }

        public string SurveyId { get; set; }
        public Survey Survey { get; set; }

        public List<Result> ResultsOfSurvey { get; set; }
    }
}
