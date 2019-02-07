using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AuVSIX.Extensions
{
    public static class StringFormattingExtensions
    {
        public static string PascalCaseToSnake(this string source)
        {
            var arr = SplitPascalCase(source);
            return string.Join("-", arr).ToLower();
        }

        static string[] SplitPascalCase(string source)
        {
            return Regex.Split(source, @"(?<!^)(?=[A-Z])");
        }
    }
}
