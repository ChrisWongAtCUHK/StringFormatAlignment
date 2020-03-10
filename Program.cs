using System;
using System.Collections.Generic;

namespace StringFormatAlignment
{
    class Program
    {
        static string FixedWidth(object value, int width, bool leftAlign)
        {
            var s = value == null ? string.Empty : value.ToString();
            return leftAlign ? s.PadRight(width) : s.PadLeft(width);
        }

        class Entry
        {
            public string Name;
            public int Score;
        }

        static void Main(string[] args)
        {
            var data = new List<Entry>
            {
                new Entry { Name = "Jeffrey", Score = 32767 },
                new Entry { Name = "Fox", Score = 255},
                new Entry { Name = "Darkthread", Score = 9999}
            };
            data.ForEach(o =>
            {
                Console.WriteLine(
                    $"{FixedWidth(o.Name, 16, true)} {FixedWidth(o.Score.ToString("N0"), 6, false)}");
            });
        }
    }
}
