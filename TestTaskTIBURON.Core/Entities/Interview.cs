using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestTaskTIBURON.Core.Entities
{
    [Index(nameof(SurveyId))]
    public class Interview : Entity
    {
        public DateTime WasStater { get; set; }
        public string UserId { get; set; }

        [ForeignKey(nameof(Survey))]
        public int? SurveyId { get; set; }
        [JsonIgnore]
        public Survey? Survey { get; set; }

        [JsonIgnore]
        public List<Result>? ResultsOfSurvey { get; set; }
    }
}
