using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestTaskTIBURON.Core.Entities
{
    [Index(nameof(SurveyName))]
    public class Survey : Entity
    {
        public string SurveyName { get; set; }
        public int CountOfQuestion { get; set; }
        public string? Description { get; set; }

        [JsonIgnore]
        public List<Question> Questions { get; set; }
        [JsonIgnore]
        public List<Interview> Interviews { get; set; }
    }
}
