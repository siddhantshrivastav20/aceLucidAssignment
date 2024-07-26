using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

public class PrintDate
{
    static void Main()
    {
        string text = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
        List<string> validDates = FindValidDates(text);

        foreach (string date in validDates)
        {
            Console.WriteLine(date);
        }
    }

    static List<string> FindValidDates(string text)
    {
        List<string> validDates = new List<string>();

        
        string pattern = @"\b(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01])(19|20)\d{2}\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            string dateStr = match.Value;
            if (DateTime.TryParseExact(dateStr, "MMddyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                validDates.Add(dateStr);
            }
        }

        return validDates;
    }
}