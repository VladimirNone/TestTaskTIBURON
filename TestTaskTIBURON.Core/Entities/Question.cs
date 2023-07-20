
namespace TestTaskTIBURON.Core.Entities
{
    public class Question : Entity
    {
        public string Text { get; set; }

        public string SurveyId { get; set; }
        public Survey Survey { get; set; }

        public List<Answer> Answers { get; set; }
        public List<Result> Results { get; set; }
    }
}
