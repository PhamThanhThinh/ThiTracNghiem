using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThiTracNghiem.Api.Data.Entities
{
  // đáp án của bài kiểm tra
  public class Option
  {
    [Key]
    public int Id { get; set; }

    [MaxLength(200)]
    // chứa nội dung của câu trả lời
    public string Text { get; set; }
    public bool IsCorrect {  get; set; } // true -> câu trả lời đúng, false -> câu trả lời sai

    public int QuestionId { get; set; }
    [ForeignKey(nameof(QuestionId))]
    public virtual Question Question { get; set; }

  }
}
