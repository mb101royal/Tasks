namespace custom_contains
{
    internal static class Extension
    {
        public static bool CustomContains(this string userInput, string target)
        {
            userInput = userInput.Trim().ToLower();
            target = target.Trim().ToLower();
            bool result = false;
            
            for (int i = 0; i < userInput.Length;)
            {
                
                if (userInput.Substring(i,  target.Length) == target)
                {
                    result = true;
                    break;
                }
                if (i < userInput.Length - target.Length) i += 1;
                else break;
            }
            
            return result;
        }
    }
}