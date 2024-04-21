using System.ComponentModel.DataAnnotations;

namespace Dev_Card_MvC.Models
{
	public class Contact
	{
		[Required(ErrorMessage ="این فیلد اجبازی است")]
		[MinLength(3,ErrorMessage ="حداقل طول نام ۳ کرکتر می باشد")]
		[MaxLength(100, ErrorMessage = "حداکثر طول نام ۱۰۰ کرکتر می باشد")]
		public string Name { get; set; }
		[Required(ErrorMessage = "این فیلد اجبازی است")]
		[EmailAddress(ErrorMessage="فرمت وارد شده برای این ایمیل صحیح نیست")]
		public string Email { get; set; }
		[Required(ErrorMessage = "این فیلد اجبازی است")]
		public string Message { get; set; }
		[Required(ErrorMessage = "این فیلد اجبازی است")]
		public string Service { get; set; }
	}
}
