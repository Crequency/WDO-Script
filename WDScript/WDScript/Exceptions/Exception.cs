using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDScript.WDScript.Exceptions
{
    public class Exception
    {
        public bool IsHandled { get; set; }

        public string Message { get; set; }

        public string Position { get; set; }

        public string FileName { get; set; }
    }
}
