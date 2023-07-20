
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskTIBURON.Core.Entities
{
    [Index(nameof(SurveyId))]
    public class Question : Entity
    {
        public string Text { get; set; }

        [ForeignKey(nameof(Survey))]
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public List<Answer> Answers { get; set; }
        public List<Result> Results { get; set; }
    }
}
