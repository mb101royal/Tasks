using exception_task.Exceptions;
using exception_task.Validators;

namespace exception_task.Models
{
	internal class User
	{
		string _name;
		byte _age;
		string _phoneNumber;
		string _password;
		public string Name
		{
			get => _name;
			set
			{
				if (value.Length <= 2 || value.Length > 30) throw new InvalidNameException(UserValidator.invalidNameExceptionMessage);
				else _name = value;
			}
		}
		public byte Age
		{
			get => _age;
			set
			{
				if (value <= 0) throw new InvalidAgeException(UserValidator.invalidAgeExceptionMessage);
				else _age = value;
			}
		}
		public string PhoneNumber
		{
			get => _phoneNumber;
			set
			{
				if (!UserValidator.IsValidMobileNumber(value)) throw new InvalidPhoneFormat(UserValidator.invalidPhoneFormatMessage);
				else _phoneNumber = value;
			}
		}
		public string Password
		{
			get => _password;
			set
			{
				if (value.Length < 8 || !UserValidator.PasswordCheck(value))
					throw new PasswordException(UserValidator.passwordExceptionMessage);
				else _password = value;
			}
		}

		public override string ToString()
		{
			return $"Name => {Name}, Age => {Age}, Phone number => {PhoneNumber}, Password => {Password}";
		}
	}
}
