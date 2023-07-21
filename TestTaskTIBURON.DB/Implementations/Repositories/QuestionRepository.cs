using Microsoft.EntityFrameworkCore;
using TestTaskTIBURON.Core.Entities;
using TestTaskTIBURON.DB.Interfaces.Repositories;

namespace TestTaskTIBURON.DB.Implementations.Repositories
{
    public class QuestionRepository : GeneralRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(SurveyDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Question?> GetQuestionWithAnswers(int id)
        {
            return await DbSet.AsNoTracking().Include(h=>h.Answers).SingleOrDefaultAsync(h=>h.Id == id);
        }

        public async Task<int> AddAnswersToQuestion(int interviewId, int questionId, List<int> answersId)
        {
            var question = await DbSet.Include(h => h.Survey).SingleOrDefaultAsync(h => h.Id == questionId);
            if(question == null)
            {
                return -1;
            }

            var results = new List<Result>();
            foreach (var ansId in answersId)
            {
                results.Add(new Result() { AnswerId = ansId, InterviewId = interviewId, QuestionId = questionId, WasCommited = DateTime.Now.ToUniversalTime() });
            }

            await DbContext.Results.AddRangeAsync(results);

            if(question.Survey.CountOfQuestion == question.Order)
            {
                return -1;
            }
            else
            {
                return (await DbSet.AsNoTracking().SingleOrDefaultAsync(h => h.SurveyId == question.SurveyId && h.Order == question.Order + 1)).Id;
            }
        }
    }
}
