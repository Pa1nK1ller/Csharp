using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork5
{
    static class Massage
    {
        public static void WordLettersMoreThan(string str, int letNum)
        {
            str = Regex.Replace(str, @"[\.!,:;?-]", "");
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            string[] words = str.Split(new char[] { ' ' });
            foreach (string el in words) if (el.Length > letNum) Console.WriteLine(el);
        }
        public static void DeleteWordsEndingChar(string str, char ch)
        {
            string strToArr = Regex.Replace(str, @"[\.!,:;?-]", "");
            strToArr = Regex.Replace(strToArr, @"[\s]{2,}", " ");
            string[] words = strToArr.Split(new char[] { ' ' });

            foreach (string el in words)
            {
                if (el.Length > 1 && el[^1] == ch)
                {
                    str = str.Remove(str.IndexOf(el), el.Length);
                    Console.WriteLine($"Удалено: {el}");
                }
            }
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            Console.WriteLine($"Оставшаяся строка: {str}");
        }
        public static void LongestWord(string str)
        {
            str = Regex.Replace(str, @"[\.!,:;?-]", "");
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            string[] words = str.Split(new char[] { ' ' });

            int lgstWordIndex = 0;
            if (words.Length != 0)
            {
                int len = words[0].Length;
                for (int i = 1; i < words.Length; i++)
                {
                    if (len < words[i].Length)
                    {
                        lgstWordIndex = i;
                        len = words[i].Length;
                    }
                }
            }
            Console.WriteLine($"Самое длинное слово: {words[lgstWordIndex]}");
        }
        public static void StrBuilderLgstWord(string str)
        {
            str = Regex.Replace(str, @"[\.!,:;?-]", "");
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            string[] words = str.Split(new char[] { ' ' });
            StringBuilder strBld = new();
            if (words.Length != 0)
            {
                int len = words[0].Length;
                for (int i = 1; i < words.Length; i++)
                {
                    if (len < words[i].Length)
                    {
                        len = words[i].Length;
                    }
                }

                strBld = strBld.Append("|");
                foreach (string word in words)
                {
                    if (word.Length == len) strBld = strBld.Append($"{word}|");
                }
            }
            System.Console.WriteLine($"Составленная фраза: {strBld}");
        }
        public static Dictionary<string, int> FrequencyDictionary(string str)
        {
            str = Regex.Replace(str, @"[\.!,:;?-]", "");
            str = Regex.Replace(str, @"[\s]{2,}", " ");
            string[] words = str.Split(new char[] { ' ' });

            SortedDictionary<string, int> dict = new();
            for (int i = 0; i < words.Length; i++)
            {
                if (!dict.ContainsKey(words[i])) dict.Add(words[i], 1);
                else
                {
                    dict.TryGetValue(words[i], out int v);
                    dict.Remove(words[i]);
                    dict.Add(words[i], ++v);
                }
            }

            Dictionary<string, int> dict2 = new();
            foreach (var el in dict.Keys)
            {
                dict.TryGetValue(el, out int v);
                dict2.Add(el, v);
            }
            return dict2;
        }
    }
}
