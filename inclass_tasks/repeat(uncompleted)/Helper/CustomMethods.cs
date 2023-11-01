namespace repeat.Helper
{
    public class CustomMethods
    {
        public bool CustomIsDigit(string value)
        {
            bool result = false;

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}