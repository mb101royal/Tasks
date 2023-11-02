using System.Text.RegularExpressions;

namespace exception_task.Validators
{
	internal static class UserValidator
	{
		public static string invalidNameExceptionMessage = "Length of the Name must be greater than 2 and less than 30.";
		public static string invalidAgeExceptionMessage = "Age cannot be less than 1.";
		public static string invalidPhoneFormatMessage = "Phone format isn't correct.";
		public static string passwordExceptionMessage =
			"Password must have at least 1 digit and 1 character in uppercase, and length should be at least 8.";

		public static bool PasswordCheck(string password)
		{
			Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");

			bool result = validateGuidRegex.IsMatch(password);

			return result;
		}
		public static bool IsValidMobileNumber(string inputMobileNumber)
		{
			string strRegex = @"(^\+[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^\+[0-9]{3}-[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}$)";

			Regex re = new Regex(strRegex);

			bool result = re.IsMatch(inputMobileNumber);

			return result;
		}
	}
}
