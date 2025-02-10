using System.ComponentModel.DataAnnotations;
using ThiTracNghiem.Shared;

namespace ThiTracNghiem.Api.Data.Entities
{
  public class User
  {
    [Key]
    public int Id { get; set; }
    
    [MaxLength(30)]
    public string Name { get; set; }
    
    [MaxLength(50)]
    public string Email { get; set; }
    
    [Length(9, 15)]
    public string Phone { get; set; }

    [MaxLength(50)]
    public string PasswordHash { get; set; }
    //public string Role { get; set; } = "Admin";
    //public string Role { get; set; } = "Student";

    [MaxLength(20)]
    public string Role { get; set; } = nameof(UserRole.Student);

    // tài khoản có được kích hoạt chưa? có được thông qua bởi admin
    public bool IsApproved { get; set; } // true: tk được kích hoạt, false: tk chưa được kích hoạt
  }
}
