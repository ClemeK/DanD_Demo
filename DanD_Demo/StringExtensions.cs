namespace DanD_Demo
{
    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        // *****************************************
        public static string CenterText(this string t, int width)
        {
            string line = "";
            int fill = (width - t.Length) / 2;

            for (int i = 0; i < fill; i++)
            {
                line += " ";
            }

            line += t;

            for (int i = line.Length; i < width; i++)
            {
                line += " ";
            }

            return line;
        }
    }
}