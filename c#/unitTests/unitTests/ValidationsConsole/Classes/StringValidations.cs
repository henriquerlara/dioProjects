namespace ValidationsConsole.Classes
{
    public class StringValidations
    {
        public int GetCharacterCount(string text)
        {
            return text.Length;
        }

        public bool ContainsSubstring(string text, string substring)
        {
            return text.Contains(substring);
        }

        public bool EndsWithSubstring(string text, string substring)
        {
            return text.EndsWith(substring);
        }
    }
}
