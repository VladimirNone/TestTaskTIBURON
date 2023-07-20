
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskTIBURON.Core.Entities
{
    [Index(nameof(QuestionId))]
    public class Answer : Entity
    {
        public string Text { get; set; }

        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public List<Result> Results { get; set; }
    }
}
