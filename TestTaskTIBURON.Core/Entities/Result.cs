using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskTIBURON.Core.Entities
{
    public class Result : Entity
    {
        public DateTime WasCommited { get; set; }

        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        [ForeignKey(nameof(Answer))]
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }

        [ForeignKey(nameof(Interview))]
        public int InterviewId { get; set; }
        public Interview Interview { get; set; }
    }
}
