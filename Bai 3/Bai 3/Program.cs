
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

internal class TextProcessor
{
    public static string KhoangTrang(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        return Regex.Replace(text, @"\s+", " ").Trim();
    }

    /// <summary>
    /// Viết hoa ký tự đầu của mỗi câu trong văn bản.
    /// </summary>
    public static string VietHoa(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";

        char[] chu = text.ToLower().ToCharArray();
        bool capitalizeNext = true;

        for (int i = 0; i < chu.Length; i++)
        {
            if (char.IsLetter(chu[i]) && capitalizeNext)
            {
                chu[i] = char.ToUpper(chu[i]);
                capitalizeNext = false;
            }
            else if (chu[i] == '.' || chu[i] == '?' || chu[i] == '!')
            {
                capitalizeNext = true;
            }
        }
        return new string(chu);
    }


    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Vui lòng nhập vào một đoạn văn bản:");
        string inputText = Console.ReadLine();

        string normalizedText = KhoangTrang(inputText);
        normalizedText = VietHoa(normalizedText);

        var TanSuat = new Dictionary<string, int>();
        char[] Kytudacbiet = { '.', ',', '?', '!', ';', ':' };
        string[] words = normalizedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            string cleanedWord = word.TrimEnd(Kytudacbiet).ToLower();

            if (!string.IsNullOrEmpty(cleanedWord))
            {
                if (TanSuat.ContainsKey(cleanedWord))
                {
                    TanSuat[cleanedWord]++;
                }
                else
                {
                    TanSuat.Add(cleanedWord, 1);
                }
            }
        }


        Console.WriteLine("\nVăn bản chuẩn hóa: ");
        Console.WriteLine(normalizedText);

        Console.WriteLine("\nThống kê tần suất từ: ");
        Console.WriteLine($"- Tổng số từ: {words.Length}");
        Console.WriteLine($"- Số lượng từ khác nhau: {TanSuat.Count}");

        // Sắp xếp các từ theo tần suất giảm dần để hiển thị
        var sortedFrequencies = TanSuat.OrderByDescending(pair => pair.Value);

        Console.WriteLine("+----------------------+------------+");
        Console.WriteLine("|          TỪ          |  TẦN SUẤT  |");
        Console.WriteLine("+----------------------+------------+");

        foreach (var pair in sortedFrequencies)
        {
            Console.WriteLine($"| {pair.Key} | {pair.Value} |");
        }
        Console.WriteLine("+----------------------+------------+");

        Console.ReadKey();
    }

}