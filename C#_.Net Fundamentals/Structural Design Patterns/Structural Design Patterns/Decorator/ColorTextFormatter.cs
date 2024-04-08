using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Decorator
{
    public class ColorTextFormatter : BaseTextFormatter
    {
        private readonly string _color;

        public ColorTextFormatter(ITextFormat textFormat, string color) : base(textFormat) 
        { 
            _color = color;
        }
        public override string Apply(string text)
        {
            return $"<{_color}>{_textFormat.Apply(text)}</{_color}>";
        }

        public override string Remove(string text)
        {
            return _textFormat.Remove(text).Replace($"<{_color}>", "").Replace($"</{_color}>", "");
        }
    }
}
