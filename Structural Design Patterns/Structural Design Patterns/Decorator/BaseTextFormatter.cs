using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Decorator
{
    public abstract class BaseTextFormatter : ITextFormat
    {
        protected ITextFormat _textFormat;

        public BaseTextFormatter(ITextFormat textFormat)
        {
            _textFormat = textFormat;
        }
        public abstract string Apply(string text);
           
 
        public abstract string Remove(string text);
        
    }
}
