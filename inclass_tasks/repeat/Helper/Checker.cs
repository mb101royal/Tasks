namespace repeat.Helper
{
    public static class Checker
    {
        public static bool ProperName(this string name)
        {
            bool result = false;

            if (name != null && name.Length >= 3 && CustomIsDigit(name)) return result = true;

            return result;
        }
        public static bool ProperSurname(this string surname)
        {
            bool result = false;

            if (surname != null && surname.Length >= 5 && CustomIsDigit(surname)) return result = true;

            return result;
        }
    }
}
