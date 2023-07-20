namespace TestTaskTIBURON.Core.Entities
{
    public class Result : Entity
    {
        public DateTime WasCommited { get; set; }

        public string QuestionId { get; set; }
        public Question Question { get; set; }

        public string AnswerId { get; set; }
        public Answer Answer { get; set; }

        public string InterviewId { get; set; }
        public Interview Interview { get; set; }
    }
}
