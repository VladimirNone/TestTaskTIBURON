
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestTaskTIBURON.Core.Entities
{
    [Index(nameof(SurveyId))]
    public class Question : Entity
    {
        public string Text { get; set; }
        public int Order { get; set; }

        [ForeignKey(nameof(Survey))]
        public int SurveyId { get; set; }
        [JsonIgnore]
        public Survey Survey { get; set; }

        [JsonIgnore]
        public List<Answer> Answers { get; set; }
        [JsonIgnore]
        public List<Result> Results { get; set; }
    }
}
