using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDScript.WDScript
{
    internal struct RegexStrings
    {
        internal const string regex_identifier = @"\n* *([a-zA-Z_\u4e00-\u9fa5]+[a-zA-Z_0-9\u4e00-\u9fa5]+) *";

        internal const string regex_operator = @" *(>>=|<<=|\+\+|--|&&|\|\||!|>=|<=|>>|<<|\+=|-=|\*=|/=|&=|\|=|\^=|&|\||\^|\+|-|\*|/|%|>|<|=) *";
    }
}
