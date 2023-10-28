using ExtensionMethodApp.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            IEnumerable<string> names = new string[] { "kannan","zeeshan","zee","Koenig" };
            var namesWithZ = names.Where(DoesNameHaveZ);
                                  

            var nameWithZAndLenghtMoreThan5 = namesWithZ.Where(BiggerName);



            //Deferred Execution

            // foreach (var name in namesWithZ)
            //{
            //    Console.WriteLine(name);

            //}

            List<string> zNames = nameWithZAndLenghtMoreThan5.ToList();



        }

        static bool BiggerName(string name) {
            return name.Length > 5;
        }
        static bool DoesNameHaveZ(string name)
        {

            return name.Contains("z");
        }
    }
}