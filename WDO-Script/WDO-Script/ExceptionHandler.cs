using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDScript.WDScript.Exceptions;

using Exception = WDScript.WDScript.Exceptions.Exception;

namespace WDScript.WDScript
{
    public class ExceptionHandler
    {
        public delegate void OnException(Exception exp);
        public event OnException? OnExceptionHappend;
        public event OnException? OnExceptionHandled;

        public bool Throw(Exception exp)
        {
            if (OnExceptionHappend != null)
                OnExceptionHappend.Invoke(exp);
            return exp.IsHandled;
        }
    }
}
