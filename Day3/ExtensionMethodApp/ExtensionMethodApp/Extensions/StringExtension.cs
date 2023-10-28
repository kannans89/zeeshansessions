using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp.Extensions
{
    internal static class StringExtension
    {

      public static string  Foo( this String input,string message="Foo") {

            return input + message;

        }
    }
}
