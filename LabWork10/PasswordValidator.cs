namespace LabWork10
{
    public static class PasswordValidator
    {
        public static bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            if (password.Length < 8) 
                return false;

            bool hasDigit = false;
            bool hasLatinLetter = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                else if ( (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    hasLatinLetter = true;
                }

                if (hasDigit && hasLatinLetter)
                {
                    return true;
                }
            }

            return hasDigit && hasLatinLetter;
        }
    }
}
