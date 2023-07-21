using Microsoft.AspNetCore.Mvc;
using TestTaskTIBURON.Core.Entities;
using TestTaskTIBURON.DB.Interfaces;
using TestTaskTIBURON.DB.Interfaces.Repositories;
using TestTaskTIBURON.DTOs;

namespace TestTaskTIBURON.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class SurveyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SurveyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //Получение данных вопроса для отображения на фронте (текста вопроса и вариантов ответа)
        [HttpGet("getQuestion/{id:int}")]
        public async Task<IActionResult> GetQuestion(int id)
        {
            var questionRepo = (IQuestionRepository)_unitOfWork.GetRepository<Question>(true);

            var questionData = await questionRepo.GetQuestionWithAnswers(id);

            return Ok(new { question = questionData, answers = questionData.Answers });
        }

        //Сохранение результатов ответа на вопрос по кнопке “Далее”. Принимает выбранные радиобаттоны, возвращает айди следующего вопроса.
        [HttpPost("postAnswers")]
        public async Task<IActionResult> PostAnswers(RecordAnswersPost answersData)
        {
            var questionRepo = (IQuestionRepository)_unitOfWork.GetRepository<Question>(true);
            try
            {
                var nextQuestionId = await questionRepo.AddAnswersToQuestion(answersData.interviewId, answersData.questionId, answersData.answersId.ToList());
                await _unitOfWork.Commit();

                return Ok(nextQuestionId);
            }
            catch(Exception ex)
            {
                _unitOfWork.Rollback();
            }

            return BadRequest();
        }
    }
}
