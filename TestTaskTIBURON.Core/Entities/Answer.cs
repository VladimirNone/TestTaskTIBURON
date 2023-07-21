
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestTaskTIBURON.Core.Entities
{
    [Index(nameof(QuestionId))]
    public class Answer : Entity
    {
        public string Text { get; set; }

        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        [JsonIgnore]
        public Question Question { get; set; }

        [JsonIgnore]
        public List<Result> Results { get; set; }
    }
}
