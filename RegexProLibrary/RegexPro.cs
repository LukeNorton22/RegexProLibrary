using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class RegexPro
{
    // Method to match a pattern and return matched values as a list of strings
    public static List<string> MatchPattern(string input, string pattern)
    {
        try
        {
            var matches = Regex.Matches(input, pattern);
            return matches.Cast<Match>().Select(m => m.Value).ToList();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid regex pattern: {ex.Message}");
            return new List<string>(); // Return empty list if invalid pattern
        }
    }

    // Method to validate if the input matches the pattern
    public static bool IsValid(string input, string pattern)
    {
        try
        {
            return Regex.IsMatch(input, pattern);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid regex pattern: {ex.Message}");
            return false;
        }
    }

    // Method to extract groups from the input based on pattern
    public static Dictionary<string, string> ExtractGroups(string input, string pattern)
    {
        var result = new Dictionary<string, string>();

        try
        {
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                for (int i = 1; i < match.Groups.Count; i++) // Groups[0] is the full match
                {
                    result[$"Group{i}"] = match.Groups[i].Value;
                }
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid regex pattern: {ex.Message}");
        }

        return result;
    }

    // Method to replace matched pattern with a replacement string
    public static string ReplacePattern(string input, string pattern, string replacement)
    {
        try
        {
            return Regex.Replace(input, pattern, replacement);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid regex pattern: {ex.Message}");
            return input; // Return original input if invalid pattern
        }
    }

    // Method to split input string based on the pattern
    public static List<string> SplitString(string input, string pattern)
    {
        try
        {
            return Regex.Split(input, pattern).ToList();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid regex pattern: {ex.Message}");
            return new List<string>(); // Return empty list if invalid pattern
        }
    }
}
