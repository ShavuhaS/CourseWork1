using System.Globalization;
using System.Text;

namespace FunctionParser
{
    public class Tokenizer
    {
        private static readonly Dictionary<char, TokenType> charToToken = new Dictionary<char, TokenType>()
        {
            {'+', TokenType.Add},
            {'-', TokenType.Subtract},
            {'*', TokenType.Multiply},
            {'/', TokenType.Divide},
            {'(', TokenType.OpenParenthesis},
            {')', TokenType.CloseParenthesis},
            {',', TokenType.Comma},
            {'\0', TokenType.END},
        };

        private StringReader reader;
        private char currChar;
        public TokenType currToken { get; private set; }
        public double currNumber { get; private set; }
        public string currIdentifier { get; private set; }

        public Tokenizer(string str)
        {
            this.reader = new StringReader(str);
            NextChar();
            NextToken();
        }

        public void NextChar()
        {
            int ch = reader.Read();
            currChar = (ch == -1) ? '\0' : (char) ch;
        }

        public void NextToken()
        {
            while (char.IsWhiteSpace(currChar)) NextChar();

            if (charToToken.ContainsKey(currChar))
            {
                currToken = charToToken[currChar];
                if (currChar !=  '\0') NextChar();
                return;
            }

            if (char.IsLetter(currChar))
            {
                StringBuilder builder = new StringBuilder();
                while (char.IsLetter(currChar))
                {
                    builder.Append(currChar);
                    NextChar();
                }
                this.currIdentifier = builder.ToString();
                this.currToken = TokenType.Identifier;
                return;
            }

            if (char.IsDigit(currChar) || currChar == '.')
            {
                StringBuilder builder = new StringBuilder();
                bool hasPoint = false;
                while (char.IsDigit(currChar) || (currChar == '.' && !hasPoint))
                {
                    builder.Append(currChar);
                    if (currChar == '.') hasPoint = true;
                    NextChar();
                }
                this.currNumber = double.Parse(builder.ToString(), CultureInfo.InvariantCulture);
                this.currToken = TokenType.Number;
                return;
            }
        }
    }
}
