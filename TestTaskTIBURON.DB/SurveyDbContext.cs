using Microsoft.EntityFrameworkCore;
using TestTaskTIBURON.Core.Entities;

namespace TestTaskTIBURON.DB
{
    public class SurveyDbContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Survey> Surveys { get; set; }

        public SurveyDbContext(DbContextOptions<SurveyDbContext> options)
            : base(options)
        {
            if (Database.EnsureCreated())
            {
                //Создание тестовых данных
                var answersForQuestion1 = new List<Answer>()
                {
                    new Answer() { Text = "Больше 10" },
                    new Answer() { Text = "Меньше 10" },
                };
                var answersForQuestion2 = new List<Answer>()
                {
                    new Answer() { Text = "Марьино" },
                    new Answer() { Text = "Бутово" },
                };
                
                var questions = new List<Question>()
                {
                    new Question(){ 
                        Text = "Сколько книг вы прочитали?", 
                        Answers = answersForQuestion1 },
                    new Question(){ 
                        Text = "В каком районе Москвы Вы проживаете?", 
                        Answers = answersForQuestion2 },
                };
                
                var firstSurvey = new Survey() { 
                    Questions = questions, 
                    CountOfQuestion = questions.Count, 
                    Description = "Информация о Вас", 
                    SurveyName = "Анкетирование жителей Москвы" };
                
                var firstInterview = new Interview() { 
                    Survey = firstSurvey, 
                    UserId = "userId", 
                    WasStater = DateTime.Now.ToUniversalTime() };

                var results = new List<Result>()
                {
                    new Result(){ 
                        WasCommited = DateTime.Now.AddMinutes(2).ToUniversalTime(), 
                        Interview = firstInterview, Question = questions[0], 
                        Answer = answersForQuestion1[0] },
                    new Result(){ 
                        WasCommited = DateTime.Now.AddMinutes(4).ToUniversalTime(), 
                        Interview = firstInterview, Question = questions[1], 
                        Answer = answersForQuestion2[0] },
                };

                firstInterview.ResultsOfSurvey = results;

                Interviews.Add(firstInterview);
                SaveChanges();
            }
        }

    }
}
