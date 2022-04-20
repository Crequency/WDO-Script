using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDOScript.WDOScript.Exceptions;

using Exception = WDOScript.WDOScript.Exceptions.Exception;

namespace WDOScript.WDOScript
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
