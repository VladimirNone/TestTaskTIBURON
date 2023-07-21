namespace TestTaskTIBURON.DTOs
{
    public class RecordAnswersPost
    {
        public int interviewId { get; set; }
        public int questionId { get; set; }
        public List<int> answersId { get; set; }
    }
}
