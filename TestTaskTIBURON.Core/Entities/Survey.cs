using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskTIBURON.Core.Entities
{
    public class Survey : Entity
    {
        public string SurveyName { get; set; }
        public int CountOfQuestion { get; set; }
        public string? Description { get; set; }

        public List<Question> Questions { get; set; }
        public List<Interview> Interviews { get; set; }
    }
}
