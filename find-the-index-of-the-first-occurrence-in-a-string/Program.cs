namespace find_the_index_of_the_first_occurrence_in_a_string
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            return haystack.IndexOf(needle);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

           
            (string haystack, string needle)[] testCases = {
            ("hello", "ll"),
            ("aaaaa", "bba"),
            ("", ""),
            ("abc", "c"),
            ("mississippi", "issip")
        };

            foreach (var (haystack, needle) in testCases)
            {
                int result = solution.StrStr(haystack, needle);
                Console.WriteLine($"haystack: \"{haystack}\", needle: \"{needle}\" -> result: {result}");
            }
        }
    }
}
