namespace Erpmi.Core.Dtos
{
    public class TopicDto
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string Name { get; set; }
        public string Description { get; internal set; }
        public int NumberOfQuestionsToBeAttempted { get; internal set; }
    }
}
