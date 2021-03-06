﻿using System;
using System.Collections.Generic;

namespace StringFormatAlignment
{
    class Program
    {
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
                Console.WriteLine($"{o.Name, -16} {o.Score, 6:N0}");
            });
        }
    }
}
