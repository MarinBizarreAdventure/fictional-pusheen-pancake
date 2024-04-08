using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Decorator
{
    public interface ITextFormat
    {
        string Apply(string text);
        string Remove(string text);
    }
}
