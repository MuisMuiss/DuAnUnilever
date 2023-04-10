using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DuAnUnilever.Models
{
    public class User
    {
        public int Id { get; set; }
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} từ 6-20 kí tự")]
        public string Username { get; set; }

        [DisplayName("Mật khẩu")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "{0} từ 6-100 kí tự")]
        public string Password { get; set; }
        
        [DisplayName("Full name")]
        public string FullName { get; set; }

        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "{0} không hợp lệ")]
        public string Email { get; set; }

        [DisplayName("Title")]
        public string Title { get; set; }

        [DisplayName("Area")]
        public string Area { get; set; }

        [DisplayName("Report to")]
        public string Report { get; set; }

        [DisplayName("Trạng thái")]
        [DefaultValue(true)]
        public bool Status { get; set; } = true;

    }
}
