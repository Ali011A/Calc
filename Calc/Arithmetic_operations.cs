using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal  class  Arithmetic_operations
    {
        public const string StringNotAllowedMessage = "string is not allowed";

        public static bool Validate<T>(T a, T? b)
        {
            if (a is string || b is string)
            {
                Console.WriteLine(StringNotAllowedMessage);
                return false;
            }
            return true;
        }
        public static bool Validate<T>(T a)
        {
            if (a is string)
            {
                Console.WriteLine(StringNotAllowedMessage);
                return false;
            }
            return true;
        }
        public  T? Add<T>(T a, T b)
        {


            if (!Validate(a, b))return default;
          
            dynamic at =a ;
            dynamic bt = b;
            return at + bt;
        }
        public  T? Subtract<T>(T a, T b)
        {
            if (!Validate(a, b)) return default;
            dynamic at = a;
            dynamic bt = b;
            return at - bt;
        }
        public  T? Multiply<T>(T a, T b)
        {

            if (!Validate(a, b)) return default;
            dynamic at = a;
            dynamic bt = b;
            return at * bt;
        }
        public  T? Divide<T>(T a, T b)
        {
            if (!Validate(a, b)) return default;
            dynamic at = a;
            dynamic bt = b;
            return at / bt;
        }
       
        public  T? Mod<T>(T a, T b)
        {
            if (!Validate(a, b)) return default;
            dynamic at = a;
            dynamic bt = b;
            return at % bt;
        }

        public T? Power<T>(T a, T b)
        {
            if (!Validate(a, b)) return default;
            dynamic at = a;
            dynamic bt = b;
            return Math.Pow(at, bt);
        }

        public  T? SquareRoot<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Sqrt(at);
        }

        public  T? CubeRoot<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Pow(at, 1.0 / 3);
        }

        public  T? Factorial<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            dynamic result = 1;
            for (int i = 1; i <= at; i++)
            {
                result *= i;
            }
            return result;
        }

        public  T? Log<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Log(at);
        }

        public  T? Log10<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Log10(at);
        }

        public  T? Sin<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Sin(at);
        }

        public  T? Cos<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Cos(at);
        }

        public  T? Tan<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Tan(at);
        }

        public  T? Sinh<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Sinh(at);
        }

        public  T? Cosh<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Cosh(at);
        }

        public  T? Tanh<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Tanh(at);
        }

        public  T? Asin<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Asin(at);
        }

        public  T? Acos<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Acos(at);
        }

        public  T? Atan<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Atan(at);
        }

        public  T? Abs<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Abs(at);
        }

        public  T? Ceil<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Ceiling(at);
        }

        public  T? Floor<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Floor(at);
        }

        public  T? Round<T>(T a)
        {
            if (!Validate(a)) return default;
            dynamic at = a;
            return Math.Round(at);
        }

        public  T? Max<T>(T a, T b)
        {
            if (!Validate(a, b)) return default;
            dynamic at = a;
            dynamic bt = b;
            return Math.Max(at, bt);
        }

        public  T? Min<T>(T a, T b)
        {
            if (!Validate(a, b)) return default;
            dynamic at = a;
            dynamic bt = b;
            return Math.Min(at, bt);
        }

       


    }
}
