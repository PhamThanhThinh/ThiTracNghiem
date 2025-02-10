using System.ComponentModel.DataAnnotations;

namespace ThiTracNghiem.Api.Data.Entities
{
  public class Category
  {

    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    // trường lưu tên môn học
    public string Name { get; set; }
  }
}
