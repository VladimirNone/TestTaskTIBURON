
namespace TestTaskTIBURON.Core.Entities
{
    public class Answer : Entity
    {
        public string Text { get; set; }

        public string QuestionId { get; set; }
        public Question Question { get; set; }

        public List<Result> Results { get; set; }
    }
}
