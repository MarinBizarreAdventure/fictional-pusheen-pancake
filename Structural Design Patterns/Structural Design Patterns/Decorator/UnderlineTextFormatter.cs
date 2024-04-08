using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Decorator
{
    public class UnderlineTextFormatter : BaseTextFormatter
    {
        public UnderlineTextFormatter(ITextFormat textFormat) : base(textFormat) { }
        public override string Apply(string text)
        {
            return "<u>" + _textFormat.Apply(text) + "</u>";
        }

        public override string Remove(string text)
        {
            return _textFormat.Remove(text).Replace("<u>", "").Replace("</u>", "");
        }
    }
}
