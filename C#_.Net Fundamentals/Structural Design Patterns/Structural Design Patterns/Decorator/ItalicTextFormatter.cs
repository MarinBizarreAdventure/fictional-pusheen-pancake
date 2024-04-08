using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Decorator
{
    public class ItalicTextFormatter : BaseTextFormatter
    {
        public ItalicTextFormatter(ITextFormat textFormat) : base(textFormat) { }
        public override string Apply(string text)
        {
            return "<i>" + _textFormat.Apply(text) + "</i>";
        }

        public override string Remove(string text)
        {
            return _textFormat.Remove(text).Replace("<i>", "").Replace("</i>", "");
        }
    }
}
