using TestTaskTIBURON.Core.Entities;

namespace TestTaskTIBURON.DB.Interfaces.Repositories
{
    public interface IQuestionRepository : IGeneralRepository<Question>
    {
        Task<Question?> GetQuestionWithAnswers(int id);
        Task<int> AddAnswersToQuestion(int interviewId, int questionId, List<int> answersId);
    }
}
