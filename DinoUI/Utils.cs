using System.Text.RegularExpressions;

namespace DinoUI
{
    public static class Extensions
    {
        public static string Center(this string str, int width = 0)
        {
            if (width == 0)
                width = Console.WindowWidth;
            int titlewidth = str.Split('\n')[0].Length;
            int padwidth = (width - titlewidth) / 2;
            var pad = new String(' ', padwidth);
            var isStringEven = titlewidth % 2 == 0;
            var isWidthEven = width % 2 == 0;
            string r = str.Insert(0, pad) + pad + (isStringEven == isWidthEven ? "" : " ");
            return r.Replace("\n", pad + "\n" + pad);
        }
        public static string[] SplitWithWord(this string str, int length)
        {
            string[] words = str.Split(' ');
            var parts = new Dictionary<int, string>();
            string part = string.Empty;
            int partCounter = 0;
            foreach (var word in words)
            {
                if (part.Length + word.Length < length)
                {
                    part += string.IsNullOrEmpty(part) ? word : " " + word;
                }
                else
                {
                    parts.Add(partCounter, part);
                    part = word;
                    partCounter++;
                }
            }
            parts.Add(partCounter, part);

            return parts.Values.ToArray();
        }

    }

    public class Utils
    {
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 0; i < Console.WindowWidth; i++)
                Console.Write(" ");
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public static string ConcatMultilineString(string a, string b)
        {
            string splitOn = "\r\n|\r|\n";
            string[] p = Regex.Split(a, splitOn);
            string[] q = Regex.Split(b, splitOn);

            return string.Join("\r\n", p.Zip(q, (u, v) => u + "   " + v));
        }
        public static string RenderButtons(ButtonInfo[] titles, int buttonwidth)
        {
            string[] boxes = new string[titles.Length];
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i] = new String('█', buttonwidth) + "\n█" + new String(' ', buttonwidth - 2) + "█\n█" + titles[i].Title.Center(buttonwidth - 2) + "█\n█" + new String(' ', buttonwidth - 2) + "█\n" + new String('█', buttonwidth);
            }

            string ret = boxes[0];

            for (int i = 1; i < boxes.Length; i++)
            {
                ret = ConcatMultilineString(ret, boxes[i]);
            }

            return ret;
        }
        public static string RenderButtons(string[] titles, int buttonwidth)
        {
            string[] boxes = new string[titles.Length];
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i] = new String('█', buttonwidth) + "\n█" + new String(' ', buttonwidth - 2) + "█\n█" + titles[i].Center(buttonwidth - 2) + "█\n█" + new String(' ', buttonwidth - 2) + "█\n" + new String('█', buttonwidth);
            }

            string ret = boxes[0];

            for (int i = 1; i < boxes.Length; i++)
            {
                ret = ConcatMultilineString(ret, boxes[i]);
            }

            return ret;
        }
        public static string RenderMinimalButtons(string[] titles)
        {
            string[] boxes = new string[titles.Length];
            for (int i = 0; i < boxes.Length; i++)
            {
                int buttonwidth = titles[i].Length + 2;
                boxes[i] = "█" + new String('▀', buttonwidth) + "█\n█" + titles[i].Center(buttonwidth) + "█\n█" + new String('▄', buttonwidth) + "█";
            }

            string ret = boxes[0];

            for (int i = 1; i < boxes.Length; i++)
            {
                ret = ConcatMultilineString(ret, boxes[i]);
            }

            return ret;
        }
        public static string RenderMinimalButtons(string[] titles, int length)
        {
            string[] boxes = new string[titles.Length];
            for (int i = 0; i < boxes.Length; i++)
            {
                int buttonwidth = length;
                boxes[i] = "█" + new String('▀', buttonwidth) + "█\n█" + titles[i].Center(buttonwidth) + "█\n█" + new String('▄', buttonwidth) + "█";
            }

            string ret = boxes[0];

            for (int i = 1; i < boxes.Length; i++)
            {
                ret = ConcatMultilineString(ret, boxes[i]);
            }

            return ret;
        }
    }
}
