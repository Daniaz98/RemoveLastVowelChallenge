using System;
using System.Collections.Generic;
using System.Text;

public class Challenge
{
    public static void Main(string[] args)
    {
        var test = "Those who dare to fail miserably can achieve greatly.";
        var test2 = "Love is a serious mental disease.";
        var test3 = "If you want to live a happy life, tie it to a goal, not to people.";

        var rs = RemoveLastVowel(test);
        var rs2 = RemoveLastVowel(test2);
        var rs3 = RemoveLastVowel(test3);

        Console.WriteLine(rs);
        Console.WriteLine(rs2);
        Console.WriteLine(rs3);
    }

    public static string RemoveLastVowel(string text)
    {
        string[] words = text.Split();
        var result = new StringBuilder();

        foreach (var w in words)
        {
            string processed = RemoveLastVowelFromWord(w);
            result.Append(processed).Append(' ');
        }

        return result.ToString().TrimEnd();

    }

    private static string RemoveLastVowelFromWord(string word)
    {
        for (int i = word.Length - 1; i >= 0; i--)
        {
            if (char.IsLetter(word[i]) && IsVowel(word[i]))
            {
                return word.Remove(i, 1);
            }
        }

        return word;
    }

    private static bool IsVowel(char c)
    {
        return "aeiouAEIOU".Contains(c);
    }
}
