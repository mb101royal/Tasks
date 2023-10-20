namespace classes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			User myUser1 = new User("Ebulfez", "ne kod?"); // 

			myUser1.Login("Ebulfez", "ne od?"); // Sehv password yazib login edirik -> fail.

			myUser1.Login("Ebulfez", "ne kod?"); // Duzgun melumatlarla daxil oluruq.

			myUser1.Login("Ebulfez", "ne kod?"); // Hesaba login olmusuq ve yeniden olmaga calisdigimizi deyir.

			myUser1.Logout(); // Hesabdan cixis etdik.

			myUser1.Logout();
		}
	}
}