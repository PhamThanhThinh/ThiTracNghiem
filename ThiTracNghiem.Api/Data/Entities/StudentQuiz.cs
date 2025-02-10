using System.ComponentModel.DataAnnotations.Schema;

namespace ThiTracNghiem.Api.Data.Entities
{
  // bảng này quyết định 1 học sinh sẽ làm bao nhiêu bài thi trắc nghiệm
  public class StudentQuiz
  {
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Guid QuizId {  get; set; }

    // học sinh đó bắt đầu thời gian thi vào thời điểm nào
    public DateTime StartedOn { get; set; }

    // học sinh đó hoàn thành bài thi vào thời gian nào
    public DateTime CompletedOn { get; set; }

    // điểm số bài thi trắc nghiệm (thang điểm 100 vì kiểu dữ liệu là kiểu int: A A+ ...)
    public int Score { get; set; }
    
    [ForeignKey(nameof(StudentId))]
    public User Student { get; set; }

    [ForeignKey(nameof(QuizId))]
    public Quiz Quiz { get; set; }
  }
}
