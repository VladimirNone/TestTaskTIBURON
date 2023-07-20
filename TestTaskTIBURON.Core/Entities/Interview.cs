using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskTIBURON.Core.Entities
{
    [Index(nameof(SurveyId))]
    public class Interview : Entity
    {
        public DateTime WasStater { get; set; }
        public string UserId { get; set; }

        [ForeignKey(nameof(Survey))]
        public int? SurveyId { get; set; }
        public Survey? Survey { get; set; }

        public List<Result>? ResultsOfSurvey { get; set; }
    }
}
