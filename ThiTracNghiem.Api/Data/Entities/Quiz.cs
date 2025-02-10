using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThiTracNghiem.Api.Data.Entities
{
  public class Quiz
  {
    [Key]
    public Guid Id { get; set; }

    // trường lưu tên của bài thi trắc nghiệm
    [MaxLength(100)]
    public string Name { get; set; }
    // trường lưu số câu hỏi (đếm có bao nhiêu câu hỏi trong bài thi trắc nghiệm)
    public int TotalQuestions { get; set; }
    // trường thời gian làm bài
    public int TimeInMinutes { get; set; }
    
    public bool IsActive { get; set; } // false bài thi chưa được kích hoạt, true bài thi đã được kích hoạt và sẵn sàng cho thí sinh thi


    public int CategoryId { get; set; }

    //[ForeignKey(nameof(Quiz.CategoryId))]
    [ForeignKey(nameof(CategoryId))]
    public virtual Category Category { get; set; }


    public ICollection<Question> Questions { get; set; } = [];

  }
}
