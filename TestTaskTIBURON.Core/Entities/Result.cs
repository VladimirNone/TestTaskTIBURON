using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestTaskTIBURON.Core.Entities
{
    [Index(nameof(QuestionId), nameof(AnswerId), nameof(InterviewId))]
    public class Result : Entity
    {
        public DateTime WasCommited { get; set; }

        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        [JsonIgnore]
        public Question Question { get; set; }

        [ForeignKey(nameof(Answer))]
        public int AnswerId { get; set; }
        [JsonIgnore]
        public Answer Answer { get; set; }

        [ForeignKey(nameof(Interview))]
        public int InterviewId { get; set; }
        [JsonIgnore]
        public Interview Interview { get; set; }
    }
}
