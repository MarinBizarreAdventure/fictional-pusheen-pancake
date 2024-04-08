using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Decorator
{
    public class SimpleText : ITextFormat
    {
        string _text;

        public SimpleText(string text)
        {
            _text = text;
        }
        public string Apply(string text)
        {
            _text = text;
            return _text;
        }

        public string Apply()
        {
            return _text;
        }
        public string Remove(string text)
        {
            _text = text;
            return _text;
        }

        public string Remove()
        {
            return _text;
        }
    }
}
