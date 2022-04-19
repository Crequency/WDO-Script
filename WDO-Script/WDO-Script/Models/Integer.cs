using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDScript.WDScript.Models.Standard;

using std = WDScript.WDScript.Models.Standard.StandardHelper;

namespace WDScript.WDScript.Models
{
    public struct Number
    {
        private string _integer { get; set; }

        private string _float { get; set; }

        public Number()
        {
            _integer = "0";
            _float = "0";
            Value = $"{_integer}.{_float}";
        }

        public string Value
        {
            get => Value;

            set
            {
                string[] vs = value.Split('.');
                if (vs.Length == 2)
                {
                    _integer = vs[0];
                    _float = vs[1];
                }
                else
                {
                    Executer.exceptionHandler.Throw(new Exceptions.Exception());
                }
            }
        }

        public static Number operator + (Number a, Number b)
        {
            var ans = new Number();
            var float_increase = false;

            var float_input_len = std.MaxValue(a._float.Length, b._float.Length);
            var float_arr = new char[2][]
            {
                new char[float_input_len],
                new char[float_input_len]
            };
            var float_arr_src = new char[2][]
            {
                a._float.ToCharArray(),
                b._float.ToCharArray()
            };

            std.HeadCpy(ref float_arr_src[0], ref float_arr[0]);
            std.HeadCpy(ref float_arr_src[1], ref float_arr[1]);

            var float_ans = new char[
                std.MaxValue(float_arr[0].Length, float_arr[1].Length) + 1
            ];

            for(int i = float_input_len - 1; i >= 0; -- i)
            {

            }

            var integer_arr = new char[2][]
            {
                a._integer.ToCharArray(),
                b._integer.ToCharArray()
            };

            return ans;
        }
    }
}
