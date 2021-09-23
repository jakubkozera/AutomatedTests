namespace Exercise
{
    public static class StringHelper
    {
        public static string ReverseWords(string str)
        {
            // "ala ma kota" => "kota ma ala"
            // "to jest test" -> "test jest to"

            var splitWords = str.Split(' ');
            var reversedWords = splitWords.Reverse();
            var result = string.Join(' ', reversedWords);
            return result;
        }

        public static bool IsPalindrome(string str)
        {
            // "ola" -> false
            // "ala" -> true
            // "Ala" -> false

            return str.SequenceEqual(str.Reverse());
        }

    }
}
