using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Decorator
{
    public class BoldTextFormatter : BaseTextFormatter
    {
        public BoldTextFormatter(ITextFormat textFormat) : base(textFormat){}

        public override string Apply(string text)
        {
            return "<b>" + _textFormat.Apply(text) + "</b>";
        }

        public override string Remove(string text)
        {
            return _textFormat.Remove(text).Replace("<b>", "").Replace("</b>", "");
        }
    }
}
