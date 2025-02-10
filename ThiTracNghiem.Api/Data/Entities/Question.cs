using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThiTracNghiem.Api.Data.Entities
{
  public class Question
  {
    [Key]
    public int Id { get; set; }

    // trường lưu nội dung của câu hỏi trong bài trắc nghiệm
    [MaxLength(250)]
    public string Text { get; set; }

    public Guid QuizId { get; set; }

    [ForeignKey(nameof(QuizId))]
    public virtual Quiz Quiz { get; set; }

    public virtual ICollection<Option> Options { get; set; } = [];
  }
}
