using System;
using System.Text.RegularExpressions;

namespace V_CONSOLE
{
    public enum TokenType
    {
        NONE,
        ID,
        NUM,
        COM
    }

    public class Token
    {
        public string val;
        public TokenType tType;

        public Token(string _txt)
        {
            val = _txt;

            tType = CheckType(val);
        }

        static TokenType CheckType(string s)
        {
            // Identifier: starts with letter or _ then letters/digits/_
            if (Regex.IsMatch(s, @"^[a-zA-Z_]\w*$"))
                return TokenType.ID;

            // Number: integer
            if (Regex.IsMatch(s, @"^\d+$"))
                return TokenType.NUM;

            // Semicolon
            if (s == ";")
                return TokenType.COM;

            return TokenType.NONE;
        }
    }
}
